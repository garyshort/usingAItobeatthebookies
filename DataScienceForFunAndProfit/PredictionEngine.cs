using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DataScienceForFunAndProfit
{
    public class PredictionEngine
    {
        private List<Horse> runnersAndRiders = new List<Horse>();

        /// <summary>
        /// Initializes a new instance of the PredictionEngine class.
        /// </summary>
        /// <param name="runnersAndRiders"></param>
        public PredictionEngine(List<Horse> runnersAndRiders)
        {
            this.runnersAndRiders = runnersAndRiders;
        }

        public List<Probability> ConditionedOnRunners()
        {
            List<Probability> probabilites = 
                new List<Probability>();
            this.runnersAndRiders.ForEach(horse =>
            {
                probabilites.Add(new Probability
                {
                    Horse = horse,
                    Value = Math.Round((double)1 /
                        this.runnersAndRiders.Count(), 2)
                });
            });
            return probabilites;
        }

        public List<Probability> ConditionedOnMileTimes()
        {
            Dictionary<Horse, double> horseMileTimeAverages 
                =
                new Dictionary<Horse, double>();

            this.runnersAndRiders.ForEach(each =>
            {
                double av = each.MileTimes.Average();
                double sd = 
                    this.StandardDeviation(each.MileTimes);

                double correctedAverage = 
                    this.StandardDeviationTooBig(av, sd)
                        ? 0
                        : av;

                horseMileTimeAverages.Add(each, 
                    correctedAverage);
            });

            // Smallest is best, so calculate how much better

            // First find the highest value
            double largest = horseMileTimeAverages.Values.Max();

            // Now divide the largest number by each number in the collection
            foreach (Horse h in horseMileTimeAverages.Keys.ToList())
            {
                // If the value is zero, skip it
                if (horseMileTimeAverages[h] == 0)
                {
                    continue;
                }

                // Otherwise do the calculation
                double old = horseMileTimeAverages[h];
                horseMileTimeAverages[h] = largest / old;
            }

            // Unify the averages to 1 by dividing each by their sum
            double sum = horseMileTimeAverages.Values.Sum();
            horseMileTimeAverages.Keys.ToList().ForEach(horse =>
            {
                horseMileTimeAverages[horse] /= sum;
            });

            // Return the probabilities
            List<Probability> probs = new List<Probability>();
            foreach (KeyValuePair<Horse, double> kvp in horseMileTimeAverages)
            {
                probs.Add(new Probability
                {
                    Horse = kvp.Key,
                    Value = kvp.Value
                });
            }

            return probs;
        }

        private double StandardDeviation(List<double> doubles)
        {
            return Math.Sqrt(
                doubles.Select(x => 
                    Math.Pow(x - doubles.Average(), 2))
                    .Average()
                    );
        }

        private bool StandardDeviationTooBig(
            double average,
            double standardDeviation)
        {
            const double threshold = 0.25d;
            return standardDeviation / average >= threshold;
        }

        public List<Probability> ConditionedOnFinishingPosition()
        {
            // Create storage for the horse and it's probability of winning
            Dictionary<Horse, double> probabilities = new Dictionary<Horse, double>();

            this.runnersAndRiders.ForEach(horse => {
                int numberOfFirsts = 
                    horse
                    .Finishes
                    .FindAll(each => each == 1)
                    .Count;

                double probabilityOfWin = 
                    (double)numberOfFirsts / (double)horse.Finishes.Count;

                probabilities.Add(horse, probabilityOfWin);
            });

            // Unify the probabilities
            double sum = probabilities.Values.Sum();
            Dictionary<Horse, double> cleanedProbs = new Dictionary<Horse, double>();
            foreach (KeyValuePair<Horse, double> kvp in probabilities)
            {
                cleanedProbs.Add(kvp.Key, kvp.Value / sum);
            }

            // Return the probabilities
            List<Probability> probs = new List<Probability>();
            foreach (KeyValuePair<Horse, double> kvp in cleanedProbs)
            {
                probs.Add(new Probability
                {
                    Horse = kvp.Key,
                    Value = kvp.Value
                });
            }

            return probs;
        }

        public List<Probability> UnifiedProbability()
        {
            // Fetch all the probabilities
            List<Probability> probs1 = this.ConditionedOnRunners();
            List<Probability> probs2 = this.ConditionedOnMileTimes();
            List<Probability> probs3 = this.ConditionedOnFinishingPosition();

            // Apply any weightings required
            probs2.ForEach(prob => prob.Value *= 1.10d);
            probs3.ForEach(prob => prob.Value *= 1.05d);

            // Concatenate the sets
            List<Probability> result = probs1
                .Concat(probs2)
                .Concat(probs3)
                .ToList();

            // Group on horse name and sum the values
            List<Probability> unifiedProbs = new List<Probability>();
            result
                .GroupBy(each => each.HorseName)
                .ToList()
                .ForEach(grouping =>
                {
                    unifiedProbs.Add(new Probability
                    {
                        Horse = grouping.ToList().First().Horse,
                        Value = grouping.ToList().Sum(prob => prob.Value)
                    });
                });

            // Unify the scores to 1
            double sum = unifiedProbs.Sum(each => each.Value);
            unifiedProbs.ForEach(each => each.Value /= sum);

            return unifiedProbs;
        }

        public List<Probability> BayesProbWinningFromStall6()
        {
            var data = new
            {
                Stall6 = (double)1 / 8,
                NotStall6 = (double)7 / 8,
                stall6Win = (double)15 / 100,
                stall6NotWin = (double)5 / 100,
                NotStall6Win = (double)40 / 100,
                NotStall6NotWin = (double)40 / 100,
                RacesRan = (double) 100d
            };

            // Assert the probabilites sum to 1
            Debug.Assert(data.Stall6 + data.NotStall6 == 1d);
            Debug.Assert(
                data.stall6Win
                + data.stall6NotWin
                + data.NotStall6Win
                + data.NotStall6NotWin
                == 1d
                );

            // Calculate the probability
            // Bayes Theorem: P(A|B) = P(B|A) * P(A) /P(B)
            // Let A = Win
            // Let B = Horse is in stall 6
            double probStall6GivenWin = data.stall6Win /
                (data.stall6Win + data.NotStall6Win);
            double probWin = (data.NotStall6Win + data.stall6Win) / data.RacesRan;
            double probWinningGivenStall6 =
                probStall6GivenWin * probWin / data.Stall6;

            // Package it up
            List<Probability> prob = new List<Probability>();
            prob.Add(new Probability
            {
                Horse = new Horse { Name = "Horse 1" },
                Value = probWinningGivenStall6
            });

            prob.Add(new Probability
            {
                Horse = new Horse { Name = "Other Horses" },
                Value = 1d - probWinningGivenStall6
            });

            // Ship it out
            return prob;
        }
    }
}
