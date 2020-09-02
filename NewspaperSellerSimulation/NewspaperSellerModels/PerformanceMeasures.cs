using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class PerformanceMeasures
    {
        public decimal TotalSalesProfit { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalLostProfit { get; set; }
        public decimal TotalScrapProfit { get; set; }
        public decimal TotalNetProfit { get; set; }
        public int DaysWithMoreDemand { get; set; }
        public int DaysWithUnsoldPapers { get; set; }
        public void datafill(List<SimulationCase> SimulationTalbe)
        {
            TotalCost = 0; TotalLostProfit = 0; TotalNetProfit = 0; TotalScrapProfit = 0; TotalSalesProfit = 0; DaysWithMoreDemand = 0; DaysWithUnsoldPapers = 0;
            foreach (var i in SimulationTalbe){
                TotalCost += i.DailyCost;
                TotalSalesProfit += i.SalesProfit;
                TotalNetProfit += i.DailyNetProfit;
                TotalLostProfit += i.LostProfit;
                TotalScrapProfit += i.ScrapProfit;
                if (i.LostProfit > i.ScrapProfit) DaysWithMoreDemand++;
                else if (i.LostProfit < i.ScrapProfit) DaysWithUnsoldPapers++;
            }
        }
    }

    
}
