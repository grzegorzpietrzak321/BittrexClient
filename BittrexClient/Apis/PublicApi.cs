using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BittrexClient;

namespace BittrexClient
{
    public class PublicApi
    {
        private Response response = new Response();

        public Response GetMarkets()
        {
            response.Result = new Market();
            await ConnectionHandler.GetMethodAsync("/public/getmarkets");

            return response;
        }

        public void GetCurrencies()
        {

        }

        public void GetTicker(string market)
        {

        }

        public void GetMarketSummaries()
        {

        }

        public void GetMarketSummary(string market)
        {

        }

        public void GetOrderBook(string market, string type)
        {

        }

        public void GetMarketHistory(string market)
        {

        }
    }
}
