using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataScienceForFunAndProfit
{
    public class Horse
    {
        public string Name { get; set; }
        public string Trainer { get; set; }
        public string Owner { get; set; }
        public Rider Rider { get; set; }
        public List<int> Finishes { get; set; }
        public List<double> MileTimes { get; set; }

        public static List<Horse> GetRunnersAndRiders()
        {
            var runnersAndRiders = new List<Horse>();

            runnersAndRiders.Add(new Horse { Name = "Horse 1", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 2.0, 2.2, 2.4, 2.6, 2.8 }, Finishes = new List<int> { 1, 5, 3, 7, 2, 8, 2, 3 } });
            runnersAndRiders.Add(new Horse { Name = "Horse 2", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 3.0, 3.2, 3.4, 3.6, 3.8 }, Finishes = new List<int> { 5, 7, 4, 7, 9, 2, 5, 1 } });
            runnersAndRiders.Add(new Horse { Name = "Horse 3", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 4.0, 4.2, 4.4, 4.6, 4.8 }, Finishes = new List<int> { 6, 4, 2, 8, 1, 1 } });
            runnersAndRiders.Add(new Horse { Name = "Horse 4", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 5.0, 5.2, 5.4, 5.6, 5.8 }, Finishes = new List<int> { 1, 7, 8, 1, 3, 1, 4, 5 } });
            runnersAndRiders.Add(new Horse { Name = "Horse 5", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 6.0, 6.2, 6.4, 6.6, 6.8 }, Finishes = new List<int> { 7, 3, 8, 2 } });
            runnersAndRiders.Add(new Horse { Name = "Horse 6", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 7.0, 7.2, 7.4, 7.6, 7.8 }, Finishes = new List<int> { 9, 2, 4, 6, 1, 7, 1, 9, 9, 3 } });
            runnersAndRiders.Add(new Horse { Name = "Horse 7", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 8.0, 8.2, 8.4, 8.6, 8.8 }, Finishes = new List<int> { 3, 5, 2, 8, 2 } });
            runnersAndRiders.Add(new Horse { Name = "Horse 8", Owner = "", Rider = new Rider(""), Trainer = "", MileTimes = new List<double> { 9.0, 9.2, 9.4, 9.6, 9.8 }, Finishes = new List<int> { 9, 5, 7, 3, 6, 2, 6, 2 } });

            return runnersAndRiders;
        }
    }
}
