using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class TimeDistribution
    {
        public int Time { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public TimeDistribution()
        {

        }

        public void fillRemainingInfo(decimal lastCumm)
        {
            CummProbability = lastCumm + Probability;
            MinRange = Convert.ToInt32(lastCumm * 100) + 1;
            MaxRange = Convert.ToInt32(CummProbability * 100);
        }

    }
}