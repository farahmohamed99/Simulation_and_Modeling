using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DemandDistribution
    {
        public DemandDistribution()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
        }
        public int Demand { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }

        public void setData(string data)
        {
            data.Replace(" ", "");
            string[] spilter = data.Split(',');
            Demand = int.Parse(spilter[0]);
            for (int i = 1; i < 4; i++)
            {
                DayTypeDistribution temp = new DayTypeDistribution();
                temp.DayType = (Enums.DayType)(i-1);
                temp.Probability = decimal.Parse(spilter[i]);
                temp.CummProbability = temp.Probability;
                temp.MinRange = 1;
                temp.MaxRange = Convert.ToInt32(temp.Probability * 100);
                DayTypeDistributions.Add(temp);
            }
        }
        public void postProcess(List<DemandDistribution> DemandDistributions)
        {
            for (int i = 1; i < DemandDistributions.Count(); i++)
            {
                for(int j = 0 ; j < 3 ; j++)
                {
                    DemandDistributions[i].DayTypeDistributions[j].MinRange = 
                        DemandDistributions[i - 1].DayTypeDistributions[j].MaxRange + 1;

                    DemandDistributions[i].DayTypeDistributions[j].CummProbability =
                        DemandDistributions[i - 1].DayTypeDistributions[j].CummProbability + DemandDistributions[i].DayTypeDistributions[j].Probability;

                    DemandDistributions[i].DayTypeDistributions[j].MaxRange = 
                        Convert.ToInt32(DemandDistributions[i].DayTypeDistributions[j].CummProbability * 100);
                }
            }
        }
    }
}

