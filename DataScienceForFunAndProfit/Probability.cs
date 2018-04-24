using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScienceForFunAndProfit
{
    public class Probability
    {
        public Horse Horse { get; set; }
        public double Value { get; set; }
        public string HorseName
        {
            get
            {
                return this.Horse.Name;
            }
        }
    }
}
