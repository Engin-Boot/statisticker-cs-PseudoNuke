using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<Double> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count > 0) {
                obj.max = numbers.Max();
                obj.min = numbers.Min();
                obj.average = numbers.Average();
            }
            else {
                obj.max = Double.NaN;
                obj.min = Double.NaN;
                obj.average = Double.NaN;
            }
            return obj;
        }
    }
}
