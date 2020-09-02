using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        public void getSystemInformation(string filePath)
        {
            string line;

            System.IO.StreamReader file =
            new System.IO.StreamReader(filePath);
            List<string> data = new List<string>();
            while ((line = file.ReadLine()) != null)
                if (line.Length>0&&line[0] >= '0' && line[0] <= '9') data.Add(line);
            NumOfNewspapers = int.Parse(data[0]);
            NumOfRecords = int.Parse(data[1]);
            PurchasePrice = decimal.Parse(data[2]);
            ScrapPrice = decimal.Parse(data[3]);
            SellingPrice = decimal.Parse(data[4]);
            UnitProfit = SellingPrice - PurchasePrice;
            DayTypeDistribution typeTemp = new DayTypeDistribution();
            typeTemp.setData(data[5], DayTypeDistributions);
            DemandDistribution demandTemp = new DemandDistribution();
            for (int i = 6; i < data.Count(); i++)
            {
                demandTemp = new DemandDistribution();
                demandTemp.setData(data[i]);
                DemandDistributions.Add(demandTemp);
            }
            demandTemp.postProcess(DemandDistributions);
            file.Close();
        }
        public void fillSimulationTable()
        {
            for (int i = 1; i <= NumOfRecords; i++)
            {
                SimulationCase tempCase = new SimulationCase();
                tempCase.DayNo = i;
                tempCase.setNewsDayType(DayTypeDistributions);
                tempCase.setDemand(DemandDistributions);
                tempCase.fill(NumOfNewspapers, PurchasePrice, SellingPrice, ScrapPrice, UnitProfit);
                SimulationTable.Add(tempCase);
            }
        }

        public void runSystem(string filePath)
        {
            getSystemInformation(filePath);
            fillSimulationTable();
            PerformanceMeasures.datafill(SimulationTable);
        }
    }
}
