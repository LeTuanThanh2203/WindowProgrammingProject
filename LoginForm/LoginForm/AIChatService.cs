using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;

namespace LoginForm
{
    /// <summary>
    /// AI Chat Service — xử lý hội thoại chatbot với OpenRouter API.
    /// Hỗ trợ 4 capability: phân tích học tập, cố vấn đăng ký, thống kê giảng viên, thực hiện lệnh.
    /// </summary>
    internal class AIChatService
    {
        public class ChatSettings
        {
            public string ApiKey { get; set; } = "";
            public string BaseUrl { get; set; } = "";
            public string ModelName { get; set; } = "";
        }

        private static readonly string SettingsPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ai_settings.json");
        public ChatSettings Settings { get; private set; } = new ChatSettings();

        private readonly List<ChatMessage> conversationHistory = new List<ChatMessage>();

        private class ChatMessage
        {
            public string role { get; set; }
            public string content { get; set; }
        }

        public AIChatService()
        {
            // Load custom settings
            LoadSettings();

            // System prompt khởi tạo
            string systemPrompt = BuildSystemPrompt();
            conversationHistory.Add(new ChatMessage
            {
                role = "system",
                content = systemPrompt
            });
        }

        public void LoadSettings()
        {
            try
            {
                if (System.IO.File.Exists(SettingsPath))
                {
                    Settings = JsonConvert.DeserializeObject<ChatSettings>(System.IO.File.ReadAllText(SettingsPath)) ?? new ChatSettings();
                }
                else
                {
                    Settings = new ChatSettings();
                    string configKey = ConfigurationManager.AppSettings["OpenRouterKey"];
                    if (!string.IsNullOrEmpty(configKey))
                        Settings.ApiKey = configKey;
                }
            }
            catch
            {
                Settings = new ChatSettings();
            }
        }

        public void SaveSettings(string apiKey, string baseUrl, string modelName)
        {
            apiKey = apiKey.Trim();
            // Tự động làm sạch nếu người dùng lỡ dán trùng nhiều lần tiền tố "sk-"
            while (apiKey.StartsWith("sk-sk-", StringComparison.OrdinalIgnoreCase))
            {
                apiKey = apiKey.Substring(3);
            }

            Settings.ApiKey = apiKey;
            Settings.BaseUrl = baseUrl.Trim();
            Settings.ModelName = modelName.Trim();
            try
            {
                System.IO.File.WriteAllText(SettingsPath, JsonConvert.SerializeObject(Settings, Formatting.Indented));
            }
            catch { }
        }

        /// <summary>
        /// Gửi 1 tin nhắn nhỏ để kiểm tra kết nối API.
        /// Trả về (thành công, thời gian ms, thông báo lỗi nếu có).
        /// </summary>
        public async Task<(bool ok, long ms, string error)> TestConnectionAsync(string apiKey, string baseUrl, string modelName)
        {
            apiKey = apiKey.Trim();
            while (apiKey.StartsWith("sk-sk-", StringComparison.OrdinalIgnoreCase))
                apiKey = apiKey.Substring(3);

            string url = baseUrl.Trim();
            if (!url.EndsWith("/chat/completions"))
                url = url.TrimEnd('/') + "/chat/completions";

            var sw = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                using var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(15);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                client.DefaultRequestHeaders.Add("HTTP-Referer", "http://localhost");
                client.DefaultRequestHeaders.Add("X-Title", "Student Management AI Chat");

                var body = new
                {
                    model = modelName.Trim(),
                    messages = new[]
                    {
                        new { role = "user", content = "Hi" }
                    },
                    max_tokens = 5,
                    temperature = 0.1
                };

                string json = JsonConvert.SerializeObject(body);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, httpContent);
                sw.Stop();

                string raw = await response.Content.ReadAsStringAsync();
                
                if (!response.IsSuccessStatusCode)
                {
                    try
                    {
                        JObject errObj = JObject.Parse(raw);
                        string errText = errObj["error"]?["message"]?.ToString() ?? errObj["error"]?.ToString();
                        if (!string.IsNullOrEmpty(errText))
                        {
                            return (false, sw.ElapsedMilliseconds, $"HTTP {(int)response.StatusCode}: {errText}");
                        }
                    }
                    catch { }

                    string snippet = raw.Length > 100 ? raw.Substring(0, 100) + "..." : raw;
                    return (false, sw.ElapsedMilliseconds, $"HTTP {(int)response.StatusCode} - {response.ReasonPhrase}. Response: {snippet}");
                }

                JObject obj;
                try
                {
                    obj = JObject.Parse(raw);
                }
                catch (JsonReaderException)
                {
                    string snippet = raw.Length > 100 ? raw.Substring(0, 100) + "..." : raw;
                    return (false, sw.ElapsedMilliseconds, $"Lỗi định dạng phản hồi (Không phải JSON). Response: {snippet}");
                }

                if (obj["choices"] != null)
                    return (true, sw.ElapsedMilliseconds, null);

                string errMsg = obj["error"]?["message"]?.ToString() ?? $"Lỗi không xác định (HTTP {(int)response.StatusCode})";
                return (false, sw.ElapsedMilliseconds, errMsg);
            }
            catch (TaskCanceledException)
            {
                sw.Stop();
                return (false, sw.ElapsedMilliseconds, "Timeout — không phản hồi sau 15 giây");
            }
            catch (Exception ex)
            {
                sw.Stop();
                return (false, sw.ElapsedMilliseconds, ex.Message);
            }
        }

        private string BuildSystemPrompt()
        {
            string role = Globals.Role ?? "User";
            string username = Globals.Username ?? "Unknown";
            int userId = Globals.GlobalUserId;

            string basePrompt = $@"Bạn là trợ lý AI thông minh cho hệ thống Quản lý Sinh viên (Student Management System).
Người dùng hiện tại: {username}, Role: {role}, UserID: {userId}.

BẠN CÓ 4 KHẢNĂNG CHÍNH:

1. 📊 PHÂN TÍCH HỌC TẬP:
   - Phân tích điểm số, đánh giá xu hướng, chỉ ra môn cần cải thiện
   - Với sinh viên: phân tích điểm cá nhân
   - Với giảng viên: phân tích điểm lớp mình dạy

2. 📚 CỐ VẤN ĐĂNG KÝ MÔN HỌC:
   - Tư vấn môn tiên quyết, mô tả môn học, số tín chỉ
   - Kiểm tra điều kiện đăng ký

3. 📈 THỐNG KÊ CHO GIẢNG VIÊN:
   - Tổng hợp điểm lớp, tỉ lệ đạt/rớt
   - Phân tích xu hướng điểm

4. ⚡ THỰC HIỆN CHỨC NĂNG:
   - Khi người dùng yêu cầu mở form hay thực hiện thao tác, trả về JSON command:
     {{""command"": ""tên_lệnh""}}
   - Các lệnh có sẵn:
     add_student, edit_student, list_students, approve_account, overview,
     list_courses, course_registration, score, class_list, schedule,
     information, assign, contact, export, help, exit

QUY TẮC:
- Trả lời bằng tiếng Việt, thân thiện, chuyên nghiệp
- Khi cần dữ liệu DB, nói cho người dùng biết bạn đang lấy dữ liệu
- Khi thực hiện lệnh, chỉ trả JSON {{""command"": ""...""}} KHÔNG kèm text khác
- Nếu người dùng không đủ quyền, từ chối lịch sự
- Format đẹp: dùng emoji, bullet points khi cần";

            return basePrompt;
        }

        /// <summary>
        /// Gửi tin nhắn và nhận response từ AI
        /// </summary>
        public async Task<string> SendMessageAsync(string userMessage)
        {
            try
            {
                // Thêm context data nếu cần
                string enrichedMessage = await EnrichMessageWithData(userMessage);

                // Thêm tin nhắn user vào history
                conversationHistory.Add(new ChatMessage
                {
                    role = "user",
                    content = enrichedMessage
                });

                // Giới hạn history để không vượt token limit
                TrimHistory();

                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(30);

                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Settings.ApiKey}");
                    client.DefaultRequestHeaders.Add("HTTP-Referer", "http://localhost");
                    client.DefaultRequestHeaders.Add("X-Title", "Student Management AI Chat");

                    var body = new
                    {
                        model = Settings.ModelName,
                        messages = conversationHistory,
                        max_tokens = 2048,
                        temperature = 0.7
                    };

                    string json = JsonConvert.SerializeObject(body);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    string requestUrl = Settings.BaseUrl;
                    if (!requestUrl.EndsWith("/chat/completions"))
                    {
                        if (requestUrl.EndsWith("/"))
                            requestUrl += "chat/completions";
                        else
                            requestUrl += "/chat/completions";
                    }

                    HttpResponseMessage response = await client.PostAsync(requestUrl, content);
                    string result = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        try
                        {
                            JObject errObj = JObject.Parse(result);
                            string errText = errObj["error"]?["message"]?.ToString() ?? errObj["error"]?.ToString();
                            if (!string.IsNullOrEmpty(errText))
                            {
                                return $"⚠️ Lỗi API (HTTP {(int)response.StatusCode}): {errText}";
                            }
                        }
                        catch { }

                        string snippet = result.Length > 100 ? result.Substring(0, 100) + "..." : result;
                        return $"⚠️ Lỗi HTTP {(int)response.StatusCode} ({response.ReasonPhrase}): {snippet}";
                    }

                    JObject obj;
                    try
                    {
                        obj = JObject.Parse(result);
                    }
                    catch (JsonReaderException)
                    {
                        string snippet = result.Length > 100 ? result.Substring(0, 100) + "..." : result;
                        return $"⚠️ Phản hồi không đúng định dạng JSON: {snippet}";
                    }

                    if (obj["choices"] != null)
                    {
                        string aiResponse = obj["choices"][0]["message"]["content"].ToString();

                        // Lưu response vào history
                        conversationHistory.Add(new ChatMessage
                        {
                            role = "assistant",
                            content = aiResponse
                        });

                        return aiResponse;
                    }

                    if (obj["error"] != null)
                    {
                        string errorMsg = obj["error"]["message"]?.ToString() ?? "Unknown error";
                        return $"⚠️ Lỗi API: {errorMsg}";
                    }

                    return "⚠️ Không nhận được phản hồi hợp lệ từ AI.";
                }
            }
            catch (TaskCanceledException)
            {
                return "⏳ Yêu cầu quá thời gian. Vui lòng thử lại.";
            }
            catch (Exception ex)
            {
                return $"❌ Lỗi: {ex.Message}";
            }
        }

        /// <summary>
        /// Tự động bổ sung dữ liệu DB vào message nếu phát hiện intent cần data
        /// </summary>
        private async Task<string> EnrichMessageWithData(string message)
        {
            string lower = message.ToLower();

            // Detect intent: phân tích điểm
            if (lower.Contains("phân tích") && (lower.Contains("điểm") || lower.Contains("học tập") || lower.Contains("kết quả")))
            {
                string scoreData = GetScoreData();
                if (!string.IsNullOrEmpty(scoreData))
                {
                    return message + "\n\n[DỮ LIỆU ĐIỂM TỪ HỆ THỐNG]:\n" + scoreData;
                }
            }

            // Detect intent: cố vấn đăng ký môn
            if (lower.Contains("đăng ký") || lower.Contains("môn học") || lower.Contains("tiên quyết") || lower.Contains("tín chỉ"))
            {
                string courseData = GetCourseData();
                if (!string.IsNullOrEmpty(courseData))
                {
                    return message + "\n\n[DỮ LIỆU MÔN HỌC TỪ HỆ THỐNG]:\n" + courseData;
                }
            }

            // Detect intent: thống kê
            if (lower.Contains("thống kê") || lower.Contains("tổng hợp") || lower.Contains("tỉ lệ"))
            {
                string statsData = GetStatisticsData();
                if (!string.IsNullOrEmpty(statsData))
                {
                    return message + "\n\n[DỮ LIỆU THỐNG KÊ TỪ HỆ THỐNG]:\n" + statsData;
                }
            }

            return message;
        }

        /// <summary>
        /// Lấy dữ liệu điểm từ DB
        /// </summary>
        private string GetScoreData()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();
                    string query;

                    if (Globals.Role == "User")
                    {
                        // Sinh viên: lấy điểm cá nhân
                        query = @"SELECT co.CourseName, sc.MidtermScore, sc.FinalScore, sc.TotalScore, sc.Overview 
                                  FROM Score sc 
                                  JOIN Class cl ON sc.ClassID = cl.ClassID 
                                  JOIN Course co ON cl.CourseID = co.CourseID
                                  WHERE sc.ID = @userId
                                  ORDER BY co.CourseName";
                    }
                    else
                    {
                        // Giảng viên/Admin: lấy tổng hợp
                        query = @"SELECT TOP 20 co.CourseName, 
                                  AVG(sc.TotalScore) as AvgScore,
                                  COUNT(*) as StudentCount,
                                  SUM(CASE WHEN sc.TotalScore >= 5 THEN 1 ELSE 0 END) as PassCount
                                  FROM Score sc 
                                  JOIN Class cl ON sc.ClassID = cl.ClassID 
                                  JOIN Course co ON cl.CourseID = co.CourseID
                                  GROUP BY co.CourseName
                                  ORDER BY AVG(sc.TotalScore) ASC";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                    {
                        if (Globals.Role == "User")
                            cmd.Parameters.AddWithValue("@userId", Globals.GlobalUserId.ToString());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                if (Globals.Role == "User")
                                {
                                    sb.AppendLine($"- {reader["CourseName"]}: GK={reader["MidtermScore"]}, CK={reader["FinalScore"]}, TB={reader["TotalScore"]}, Xếp loại={reader["Overview"]}");
                                }
                                else
                                {
                                    sb.AppendLine($"- {reader["CourseName"]}: TB={reader["AvgScore"]:F1}, SV={reader["StudentCount"]}, Đạt={reader["PassCount"]}");
                                }
                            }
                            return sb.Length > 0 ? sb.ToString() : null;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Lấy dữ liệu môn học từ DB
        /// </summary>
        private string GetCourseData()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();
                    string query = @"SELECT TOP 30 CourseID, CourseName, Credits, PrerequisiteID, Description 
                                     FROM Course 
                                     ORDER BY CourseName";

                    using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        while (reader.Read())
                        {
                            string prereq = reader["PrerequisiteID"]?.ToString();
                            string desc = reader["Description"]?.ToString();
                            sb.AppendLine($"- [{reader["CourseID"]}] {reader["CourseName"]} ({reader["Credits"]} TC)" +
                                          (string.IsNullOrEmpty(prereq) ? "" : $" | Tiên quyết: {prereq}") +
                                          (string.IsNullOrEmpty(desc) ? "" : $" | {desc}"));
                        }
                        return sb.Length > 0 ? sb.ToString() : null;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Lấy dữ liệu thống kê từ DB
        /// </summary>
        private string GetStatisticsData()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();
                    StringBuilder sb = new StringBuilder();

                    // Tổng sinh viên
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student", db.getConnection))
                    {
                        sb.AppendLine($"Tổng sinh viên: {cmd.ExecuteScalar()}");
                    }

                    // Tổng môn
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Course", db.getConnection))
                    {
                        sb.AppendLine($"Tổng môn học: {cmd.ExecuteScalar()}");
                    }

                    // Tổng lớp
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Class", db.getConnection))
                    {
                        sb.AppendLine($"Tổng lớp: {cmd.ExecuteScalar()}");
                    }

                    // Điểm TB chung
                    string avgQuery = @"SELECT co.CourseName, AVG(sc.TotalScore) as AvgScore, COUNT(*) as Cnt
                                        FROM Score sc 
                                        JOIN Class cl ON sc.ClassID = cl.ClassID
                                        JOIN Course co ON cl.CourseID = co.CourseID
                                        GROUP BY co.CourseName ORDER BY AVG(sc.TotalScore) ASC";
                    using (SqlCommand cmd = new SqlCommand(avgQuery, db.getConnection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        sb.AppendLine("\nĐiểm trung bình theo môn:");
                        while (reader.Read())
                        {
                            sb.AppendLine($"  - {reader["CourseName"]}: TB={Convert.ToDouble(reader["AvgScore"]):F1} ({reader["Cnt"]} SV)");
                        }
                    }

                    return sb.ToString();
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Giới hạn conversation history (giữ system prompt + 20 messages gần nhất)
        /// </summary>
        private void TrimHistory()
        {
            int maxMessages = 21; // 1 system + 20 messages
            if (conversationHistory.Count > maxMessages)
            {
                // Giữ system prompt (index 0) + 20 messages cuối
                var systemMsg = conversationHistory[0];
                int removeCount = conversationHistory.Count - maxMessages;
                conversationHistory.RemoveRange(1, removeCount);
            }
        }

        /// <summary>
        /// Kiểm tra response có phải command không
        /// </summary>
        public static bool TryParseCommand(string response, out string command)
        {
            command = null;
            try
            {
                // Tìm JSON trong response
                int start = response.IndexOf('{');
                int end = response.LastIndexOf('}');
                if (start >= 0 && end > start)
                {
                    string jsonStr = response.Substring(start, end - start + 1);
                    JObject obj = JObject.Parse(jsonStr);
                    if (obj["command"] != null)
                    {
                        command = obj["command"].ToString().Trim().ToLower();
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }

        /// <summary>
        /// Reset conversation
        /// </summary>
        public void ClearHistory()
        {
            conversationHistory.Clear();
            conversationHistory.Add(new ChatMessage
            {
                role = "system",
                content = BuildSystemPrompt()
            });
        }
    }
}
