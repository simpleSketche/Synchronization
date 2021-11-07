using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ETABS_Listener
{
    public class ApiClient
    {
        public static HttpClient ApiClients{ get; set; }

        public static void InitializeClient()
        {
            ApiClients = new HttpClient();
            ApiClients.DefaultRequestHeaders.Accept.Clear();
            ApiClients.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
