using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
namespace ETABS_Listener
{
    class ApiCall_ListenToChanges
    {
        public async Task<ResponseObject> LoadChange()
        {
            string url = "http://127.0.0.1:5000/";

            using (HttpResponseMessage response = await ApiClient.ApiClients.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    ResponseObject jsonResult =  JsonConvert.DeserializeObject<ResponseObject>(result);
                    return jsonResult;
                }
                return null;
            }
        }
    }
}
