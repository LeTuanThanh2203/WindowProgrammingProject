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

                                content =
                                "Return only: add_student,edit_student,approve_account,overview,list_students,help,exit"
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
    }
}