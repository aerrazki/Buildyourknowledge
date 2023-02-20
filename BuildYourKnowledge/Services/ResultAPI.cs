using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using static System.Net.WebRequestMethods;

namespace BuildYourKnowledge.Services
{
    public class ResultAPI
    {
        public HttpClient http = new HttpClient();
        public ResultAPI() { }

        public async Task<string> CallAPI(string query, bool toDebug)
        {
            http.DefaultRequestHeaders.Add("Authorization", ConfigAPI.API_AUTH);

            var jsonRequestMetaData = new
            {
                prompt = query,
                model = ConfigAPI.MODEL,
                max_tokens = ConfigAPI.MAX_TOKENS
            };

            var responseContent = await http.PostAsync(ConfigAPI.API_URI, new StringContent(JsonConvert.SerializeObject(jsonRequestMetaData), Encoding.UTF8, "application/json"));

            var resContext = await responseContent.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<dynamic>(resContext);

            var resdata = data.choices[0].text;
            if (toDebug)
                Console.WriteLine($"The output : \n {resdata}");

            return resdata;

        }
        public async void TestAPI()
        {
            var query = "Type OK and nothing else";

            await CallAPI(query,true);
        }

    }
}
