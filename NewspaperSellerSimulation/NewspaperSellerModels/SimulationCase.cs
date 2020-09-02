using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationCase
    {
        public int DayNo { get; set; }
        public int RandomNewsDayType { get; set; }
        public Enums.DayType NewsDayType { get; set; }
        public int RandomDemand { get; set; }
        public int Demand { get; set; }
        public decimal DailyCost { get; set; }
        public decimal SalesProfit { get; set; }
        public decimal LostProfit { get; set; }
        public decimal ScrapProfit { get; set; }
        public decimal DailyNetProfit { get; set; }
        private static Random radNum= new Random();
        public int randomNum()
        {
            return radNum.Next(1, 101);
        }
        public void setNewsDayType(List<DayTypeDistribution> DayTypeDistributions) 
        {
            RandomNewsDayType = randomNum();
            foreach(var i in DayTypeDistributions)
                if (RandomNewsDayType <= i.MaxRange){
                    NewsDayType = i.DayType;
                    break;
                }
        }
        public void setDemand(List<DemandDistribution> DemandDistributions)
        {
            RandomDemand = randomNum();
            int dayType=0;
            if(NewsDayType==Enums.DayType.Fair)dayType=1;
            if(NewsDayType==Enums.DayType.Poor)dayType=2;
            foreach (var i in DemandDistributions){
                if (RandomDemand <= i.DayTypeDistributions[dayType].MaxRange){
                    Demand = i.Demand;
                    break;
                }
            }
        }
        public void fill(int NumOfNewspapers, decimal PurchasePrice, decimal SellingPrice, decimal ScrapPrice, decimal UnitProfit)
        {
            DailyCost = PurchasePrice * NumOfNewspapers;
            SalesProfit = SellingPrice * Math.Min(Demand, NumOfNewspapers);
            ScrapProfit = 0; LostProfit = 0;
            if (Demand > NumOfNewspapers) LostProfit = (Demand - NumOfNewspapers) * UnitProfit;
            else ScrapProfit = (NumOfNewspapers - Demand) * ScrapPrice;
            DailyNetProfit = SalesProfit - DailyCost - LostProfit + ScrapProfit;
        }
    }
}
