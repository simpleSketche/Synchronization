using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace syncDesktopApp
{
    class ApiCallListenToChanges
    {
        public static async Task<ResponseObject> LoadChange(string message)
        {
            string url = $"http://127.0.0.1:5000/{ message }";

            using (HttpResponseMessage response = await ApiClient.ApiClients.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    ResponseObject jsonResult = JsonConvert.DeserializeObject<ResponseObject>(result);
                    return jsonResult;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
