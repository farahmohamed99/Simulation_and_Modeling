using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }



        public void fillSystemInformation(string filePath)
        {
            FileStream testCaseFile = new FileStream(filePath, FileMode.Open);
            StreamReader teseCaseReader = new StreamReader(testCaseFile);
            string Line;
            for(int i = 0; i < 6; ++i)
            {
                for(int j = 0; j < 3; ++j)
                {
                    Line = teseCaseReader.ReadLine();
                    if(j == 1)
                    {
                        switch (i)
                        {
                            case 0:
                                OrderUpTo = int.Parse(Line);
                                break;
                            case 1:
                                ReviewPeriod = int.Parse(Line);
                                break;
                            case 2:
                                StartInventoryQuantity = int.Parse(Line);
                                break;
                            case 3:
                                StartLeadDays = int.Parse(Line);
                                break;
                            case 4:
                                StartOrderQuantity = int.Parse(Line);
                                break;
                            case 5:
                                NumberOfDays = int.Parse(Line);
                                break;
                            default:
                                break;
                        }

                    }

                }
            }
            //Demand Dist.
            Line = teseCaseReader.ReadLine();

            while (true)
            {
                Line = teseCaseReader.ReadLine();
                if (String.IsNullOrEmpty(Line) || String.IsNullOrWhiteSpace(Line)) break;

                Line = Line.Replace(" ", "");
                string[] values = Line.Split(',');

                Distribution Element = new Distribution();
                Element.Value = int.Parse(values[0]);
                Element.Probability = decimal.Parse(values[1]);
                this.DemandDistribution.Add(Element);
            }

            //Lead days Dist.
            Line = teseCaseReader.ReadLine();

            while (true)
            {
                Line = teseCaseReader.ReadLine();
                if (String.IsNullOrEmpty(Line) || String.IsNullOrWhiteSpace(Line)) break;

                Line = Line.Replace(" ", "");
                string[] values = Line.Split(',');

                Distribution Element = new Distribution();
                Element.Value = int.Parse(values[0]);
                Element.Probability = decimal.Parse(values[1]);
                this.LeadDaysDistribution.Add(Element);
                
            }
            testCaseFile.Close();
        }


        public void fillSystemDistributionTables()
        {
            for (int i = 0; i < DemandDistribution.Count; ++i)
            {
                if (i == 0)
                    DemandDistribution[i].fillRemainingInfo(Convert.ToDecimal(0));
                else
                    DemandDistribution[i].fillRemainingInfo(DemandDistribution[i - 1].CummProbability);
            }

            for (int i = 0; i < LeadDaysDistribution.Count; ++i)
            {
                if (i == 0)
                    LeadDaysDistribution[i].fillRemainingInfo(Convert.ToDecimal(0));
                else
                    LeadDaysDistribution[i].fillRemainingInfo(LeadDaysDistribution[i - 1].CummProbability);
            }
        }


        // public int OrderUpTo { get; set; }
        private static Random randomNo = new Random();
        public static int randomNumber()
        {
            return randomNo.Next(1, 101);
        }

        public void runSystem()
        {
            
            int currentQuantity = StartInventoryQuantity;
            int currentShortage = 0;
            int nextOrderLeadDays = StartLeadDays - 1;
            int nextOrderQuantity = StartOrderQuantity;
            bool flag = true;
            for(int i = 0; i < NumberOfDays; ++i)
            {

                SimulationCase nCase = new SimulationCase();
                nCase.Day = i + 1;

                if(nextOrderLeadDays == 0 && flag)
                {
                    currentQuantity += nextOrderQuantity;
                    nCase.BeginningInventory = currentQuantity;
                    currentQuantity -= currentShortage;
                    currentShortage = 0;
                    flag = false;
                }
                else 
                    nCase.BeginningInventory = currentQuantity;

                nCase.Cycle = nCase.Day / ReviewPeriod;
                if (nCase.Day % ReviewPeriod != 0)
                    ++nCase.Cycle;

                nCase.DayWithinCycle = nCase.Day % ReviewPeriod;
                if (nCase.DayWithinCycle == 0)
                    nCase.DayWithinCycle = ReviewPeriod;


                nCase.RandomDemand = randomNumber();
                for(int j = 0; j < DemandDistribution.Count; ++j)
                {
                    if (nCase.RandomDemand >= DemandDistribution[j].MinRange && nCase.RandomDemand <= DemandDistribution[j].MaxRange)
                         nCase.Demand = DemandDistribution[j].Value;
                }

                if (nCase.Demand <= currentQuantity)
                    currentQuantity -= nCase.Demand;
                else
                {
                    currentShortage += nCase.Demand - currentQuantity;
                    currentQuantity = 0;
                }

                nCase.EndingInventory = currentQuantity;
                nCase.ShortageQuantity = currentShortage;

                if (nCase.Day % ReviewPeriod == 0)
                {
                    nCase.OrderQuantity = (OrderUpTo - currentQuantity) + currentShortage;
                    nextOrderQuantity = nCase.OrderQuantity;
                    nCase.RandomLeadDays = randomNumber();
                    for (int j = 0; j < LeadDaysDistribution.Count; ++j)
                    {
                        if (nCase.RandomLeadDays >= LeadDaysDistribution[j].MinRange && nCase.RandomLeadDays <= LeadDaysDistribution[j].MaxRange)
                            nCase.LeadDays = LeadDaysDistribution[j].Value;
                    }
                    nextOrderLeadDays = nCase.LeadDays + 1;
                    flag = true;
                }
                else
                    nCase.OrderQuantity = nCase.RandomLeadDays = nCase.LeadDays = 0;


                if (nextOrderLeadDays > 0 && i != 0)
                    --nextOrderLeadDays;
                nCase.DaysUntilOrderArrives = nextOrderLeadDays;
                
                SimulationTable.Add(nCase);
            }
            PerformanceMeasures.calculatePerformanceMeasures(SimulationTable);

        }









    }
}
