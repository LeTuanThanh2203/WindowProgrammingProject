using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Configuration;
namespace LoginForm
{
    internal class AIService
    {
        private readonly string apiKey =
            ConfigurationManager.AppSettings["OpenRouterKey"];

        public async Task<string> AskAI(
            string prompt)
        {
            try
            {
                using (HttpClient client =
                    new HttpClient())
                {
                    // HEADER
                    client.DefaultRequestHeaders
                        .Add(
                        "Authorization",
                        $"Bearer {apiKey}");

                    client.DefaultRequestHeaders
                        .Add(
                        "HTTP-Referer",
                        "http://localhost");

                    client.DefaultRequestHeaders
                        .Add(
                        "X-Title",
                        "Student Management");

                    // BODY
                    var body = new
                    {
                        model =
                        "baidu/cobuddy:free",

                        messages = new[]
                        {
                            new
                            {
                                role = "system",

                                //content =
                                //"Return only: add_student,edit_student,approve_account,overview,list_students,help,exit"
                                content =
                                @"VN command mapping:

                                thêm sinh viên=add_student
                                sửa sinh viên=edit_student
                                duyệt tài khoản=approve_account
                                tổng quan=overview
                                danh sách sinh viên=list_students
                                trợ giúp=help
                                thoát=exit

                                Only return command."
                            },

                            new
                            {
                                role = "user",

                                content = prompt
                            }
                        }
                    };

                    string json =
                        JsonConvert
                        .SerializeObject(body);

                    var content =
                        new StringContent(
                            json,
                            Encoding.UTF8,
                            "application/json");

                    // SEND REQUEST
                    HttpResponseMessage response =
                        await client.PostAsync(
                        "https://openrouter.ai/api/v1/chat/completions",
                        content);

                    // GET RESPONSE
                    string result =
                        await response.Content
                        .ReadAsStringAsync();

                    // DEBUG
                    // MessageBox.Show(result);

                    JObject obj =
                        JObject.Parse(result);

                    // SUCCESS
                    if (obj["choices"] != null)
                    {
                        return obj["choices"][0]
                            ["message"]["content"]
                            .ToString()
                            .ToLower()
                            .Replace(".", "")
                            .Replace("\n", "")
                            .Replace("\r", "")
                            .Trim();
                    }

                    // ERROR
                    if (obj["error"] != null)
                    {
                        return obj["error"]
                            ["message"]
                            .ToString();
                    }

                    return "unknown";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }




        public async Task<string>
ReadStudentCard(
byte[] imageBytes)
        {
            try
            {
                using (HttpClient client =
                    new HttpClient())
                {
                    // HEADER
                    client.DefaultRequestHeaders
                        .Add(
                        "Authorization",
                        $"Bearer {apiKey}");

                    client.DefaultRequestHeaders
                        .Add(
                        "HTTP-Referer",
                        "http://localhost");

                    client.DefaultRequestHeaders
                        .Add(
                        "X-Title",
                        "Student Management");


                    string base64 =
                        Convert.ToBase64String(
                            imageBytes);

                    // BODY
                    var body = new
                    {
                        model =
     "nvidia/nemotron-3-nano-omni-30b-a3b-reasoning:free",

                        messages = new object[]
     {
        new
        {
            role="system",

            content=
            @"Bạn là OCR cho hệ thống quản lý sinh viên.

            Chỉ trả về JSON.

            Không markdown.
            Không giải thích.
            Không suy luận."
        },

        new
        {
            role="user",

            content=new object[]
            {
                new
                {
                    type="text",

//                    text=
//@"Đây là ảnh CCCD hoặc thẻ sinh viên.

//Đọc thông tin nếu nhìn thấy.

//Chỉ trả:

//{
//""MSSV"":"""",
//""Fname"":"""",
//""Lname"":"""",
//""Phone"":"""",
//""Address"":""""
//}

//Nếu không thấy thì để rỗng."
                text=
                @"Đây là ảnh CCCD hoặc thẻ sinh viên.

                Đọc thông tin nếu nhìn thấy.

                Tách họ và tên:
                - Lname = họ
                - Fname = tên + tên đệm

                Ngày sinh dùng định dạng yyyy-MM-dd

                Giới tính:
                Nam hoặc Nữ

                Chỉ trả JSON:

                {
                ""MSSV"":"""",
                ""Fname"":"""",
                ""Lname"":"""",
                ""Dob"":"""",
                ""Gender"":"""",
                ""Phone"":"""",
                ""Address"":"""",
                ""Hometown"":"""",
                ""Email"":""""
                }

                Nếu không thấy thì để rỗng.

                Không giải thích."
                },

                new
                {
                    type="image_url",

                    image_url=
                    new
                    {
                        url=
$"data:image/jpeg;base64,{base64}"
                    }
                }
            }
        }
     }
                    };

                    string json =
                        JsonConvert
                        .SerializeObject(body);

                    var content =
                        new StringContent(
                            json,
                            Encoding.UTF8,
                            "application/json");


                    HttpResponseMessage response =
                        await client.PostAsync(
                        "https://openrouter.ai/api/v1/chat/completions",
                        content);


                    string result =
                        await response.Content
                        .ReadAsStringAsync();


                    JObject obj =
                        JObject.Parse(result);


                    if (obj["choices"] != null)
                    {
                        string data =
                            obj["choices"][0]
                            ["message"]
                            ["content"]
                            .ToString();


                        data =
                            data.Replace(
                            "```json", "");

                        data =
                            data.Replace(
                            "```", "");

                        data =
                            data.Trim();


                        int start =
                            data.IndexOf("{");

                        int end =
                            data.LastIndexOf("}");

                        if (start != -1 &&
                            end != -1)
                        {
                            data =
                                data.Substring(
                                    start,
                                    end - start + 1);
                        }

                        return data;
                    }


                    if (obj["error"] != null)
                    {
                        return obj["error"]
                        ["message"]
                        .ToString();
                    }

                    return "unknown";
                }
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }




    }
}
