using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public Enums.DayType DayType { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public List<DayTypeDistribution> setData(string data,List<DayTypeDistribution> DayTypeDistributions)
        {   
            data.Replace(" ", "");
            string[] spilter = data.Split(',');
            decimal cummTemp = 0;
            int startRang = 1;
            for (int i = 0; i < 3 ; i++)
            {
                DayTypeDistribution temp = new DayTypeDistribution();
                temp.DayType = (Enums.DayType)(i);
                temp.Probability = decimal.Parse(spilter[i]);
                cummTemp += temp.Probability;
                temp.CummProbability = cummTemp;
                temp.MinRange = startRang;
                temp.MaxRange = Convert.ToInt32(temp.CummProbability * 100);
                startRang = temp.MaxRange + 1;
                DayTypeDistributions.Add(temp);
            }
            return DayTypeDistributions;
        }
    }

}
