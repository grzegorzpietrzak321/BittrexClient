using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexClient.Models
{
    class Settings
    {
        public string Market { get; set; }
        public List<String> CurrenciesList { get; set; }
        public string ReadKey { get; set; }
        public string TradeKey { get; set; }
        public string WithdrawKey { get; set; }
    }
}
