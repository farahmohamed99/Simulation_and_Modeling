using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class TimeDistribution
    {
        public TimeDistribution()
        {

        }

        public int Time { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public TimeDistribution setData(string data)
        {
            data.Replace(" ", "");
            string[] spilter = data.Split(',');
            TimeDistribution temp = new TimeDistribution();
            temp.Time = int.Parse(spilter[0]);
            temp.Probability = decimal.Parse(spilter[1]);
            return temp;
        }
        public List<TimeDistribution> postProcess(List<TimeDistribution> DelayTimeDistribution )
        {
            DelayTimeDistribution[0].CummProbability = DelayTimeDistribution[0].Probability;
            DelayTimeDistribution[0].MinRange = 1;
            DelayTimeDistribution[0].MaxRange = Decimal.ToInt32(DelayTimeDistribution[0].CummProbability * 100);
            for (int i=1; i< DelayTimeDistribution.Count; i++)
            {
                DelayTimeDistribution[i].CummProbability = DelayTimeDistribution[i].Probability + DelayTimeDistribution[i-1].CummProbability;
                DelayTimeDistribution[i].MinRange = DelayTimeDistribution[i-1].MaxRange+1;
                DelayTimeDistribution[i].MaxRange = Decimal.ToInt32(DelayTimeDistribution[i].CummProbability * 100);
            }
            return DelayTimeDistribution;
        }

    }
}
