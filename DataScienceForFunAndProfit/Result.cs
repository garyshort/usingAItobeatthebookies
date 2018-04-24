using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScienceForFunAndProfit
{
    public class Result
    {
        public DateTime RaceDate { get; set; }
        public string RaceTrack { get; set; }
        public List<Horse> Runners { get; set; }
        public Horse First { get; set; }
        public Horse Second { get; set; }
        public Horse Third { get; set; }
        

        public static List<Result> GetResults() {
            var results = new List<Result>();
            return results;
        }
    
    }
}
