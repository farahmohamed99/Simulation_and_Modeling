using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class Distribution
    {
        public Distribution()
        {

        }
        public int Value { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public void fillRemainingInfo(decimal lastCummProbability)
        {
            CummProbability = lastCummProbability + Probability;
            MinRange = Convert.ToInt32(lastCummProbability * 100) + 1;
            MaxRange = Convert.ToInt32(CummProbability * 100);
        }
    }
}
