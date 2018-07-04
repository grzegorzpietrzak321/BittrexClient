using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BittrexClient
{
    class JsonHandler
    {
        public static Response Serialize(string str)
        {
            return (Response)Newtonsoft.Json.JsonConvert.DeserializeObject(str);
        }
    }
}
