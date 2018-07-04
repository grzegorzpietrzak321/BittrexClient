using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BittrexClient
{
    class ConnectionHandler
    {
        public static async Task<String> GetMethodAsync(string apiMethod)
        {
            var client = new RestClient("https://bittrex.com/api/v1.1/");
            var request = new RestRequest(apiMethod, Method.GET);
            var resp = client.Execute(request);
            return resp.Content;
        }
    }
}
