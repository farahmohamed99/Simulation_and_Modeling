using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DelayTimeDistribution = new List<TimeDistribution>();
            BearingLifeDistribution = new List<TimeDistribution>();

            CurrentSimulationTable = new List<CurrentSimulationCase>();
            CurrentPerformanceMeasures = new PerformanceMeasures();

            ProposedSimulationTable = new List<ProposedSimulationCase>();
            ProposedPerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////
        public int DowntimeCost { get; set; }
        public int RepairPersonCost { get; set; }
        public int BearingCost { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfBearings { get; set; }
        public int RepairTimeForOneBearing { get; set; }
        public int RepairTimeForAllBearings { get; set; }
        public List<TimeDistribution> DelayTimeDistribution { get; set; }
        public List<TimeDistribution> BearingLifeDistribution { get; set; }

        ///////////// OUTPUTS /////////////
        public List<CurrentSimulationCase> CurrentSimulationTable { get; set; }
        public PerformanceMeasures CurrentPerformanceMeasures { get; set; }
        public List<ProposedSimulationCase> ProposedSimulationTable { get; set; }
        public PerformanceMeasures ProposedPerformanceMeasures { get; set; }


        public List<int> Sets, AccumulatedSetsNumbers;
        public int MaxNumOfSets = 0;
        public void getSystemInformation(string filePath)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            List<string> data = new List<string>();
            while ((line = file.ReadLine()) != null)
                if (line.Length > 0 && line[0] >= '0' && line[0] <= '9') data.Add(line);
            DowntimeCost = int.Parse(data[0]);
            RepairPersonCost = int.Parse(data[1]);
            BearingCost = int.Parse(data[2]);
            NumberOfHours = int.Parse(data[3]);
            NumberOfBearings = int.Parse(data[4]);
            RepairTimeForOneBearing = int.Parse(data[5]);
            RepairTimeForAllBearings = int.Parse(data[6]);
            TimeDistribution DelayTimeDistributionTemp = new TimeDistribution();
            for (int i = 7; i < 10; i++)
            {
                DelayTimeDistributionTemp = new TimeDistribution();
                DelayTimeDistribution.Add(DelayTimeDistributionTemp.setData(data[i]));
            }
            DelayTimeDistribution = DelayTimeDistributionTemp.postProcess(DelayTimeDistribution);
            TimeDistribution BearingLifeDistributionTemp = new TimeDistribution();
            for (int i = 10; i < data.Count; i++)
            {
                BearingLifeDistributionTemp = new TimeDistribution();
                BearingLifeDistribution.Add(BearingLifeDistributionTemp.setData(data[i]));
            }
            BearingLifeDistribution = BearingLifeDistributionTemp.postProcess(BearingLifeDistribution);
            file.Close();
        }
        public int SearchForHours(int RandomHours, List<TimeDistribution> currentList)
        {
            int hours = 0;
            for (int i = 0; i < currentList.Count; i++)
            {
                if (RandomHours >= currentList[i].MinRange && RandomHours <= currentList[i].MaxRange)
                {
                    hours = currentList[i].Time;
                    break;
                }
            }
            return hours;
        }
        public void fillSimulationTableForCurrent()
        {
            int SumOfDelayTime = 0;
            Sets = new List<int>();
            AccumulatedSetsNumbers = new List<int>();
            AccumulatedSetsNumbers.Add(0);

            //Console.WriteLine(AccumulatedSetsNumbers.Count.ToString());
            AccumulatedSetsNumbers[0] = 0;
            Random rand = new Random();
            CurrentSimulationCase row = new CurrentSimulationCase();
            for (int i = 0; i < NumberOfBearings; i++)
            {
                int cnt = 1;
                row = new CurrentSimulationCase();
                row.Bearing.Index = i + 1;
                row.Bearing.RandomHours = rand.Next(1, 100);
                row.Bearing.Hours = SearchForHours(row.Bearing.RandomHours, BearingLifeDistribution);
                row.AccumulatedHours = row.Bearing.Hours;
                row.RandomDelay = rand.Next(1, 100);
                row.Delay = SearchForHours(row.RandomDelay, DelayTimeDistribution);
                CurrentSimulationTable.Add(row);
                SumOfDelayTime += row.Delay;

                while (true)
                {
                    if (row.AccumulatedHours >= NumberOfHours) break;


                    row = new CurrentSimulationCase();
                    row.Bearing.Index = i + 1;
                    row.Bearing.RandomHours = rand.Next(1, 100);
                    row.Bearing.Hours = SearchForHours(row.Bearing.RandomHours, BearingLifeDistribution);
                    row.AccumulatedHours = row.Bearing.Hours + CurrentSimulationTable[CurrentSimulationTable.Count - 1].AccumulatedHours;
                    row.RandomDelay = rand.Next(1, 100);
                    row.Delay = SearchForHours(row.RandomDelay, DelayTimeDistribution);
                    CurrentSimulationTable.Add(row);
                    SumOfDelayTime += row.Delay;
                    cnt++;

                }
                MaxNumOfSets = Math.Max(MaxNumOfSets, cnt);
                Sets.Add(cnt);
                AccumulatedSetsNumbers.Add(AccumulatedSetsNumbers[i] + Sets[i]);
            }
            CurrentPerformanceMeasures.BearingCost = Convert.ToDecimal(CurrentSimulationTable.Count) * Convert.ToDecimal(BearingCost);
            CurrentPerformanceMeasures.DelayCost = Convert.ToDecimal(SumOfDelayTime) * Convert.ToDecimal(DowntimeCost);
            CurrentPerformanceMeasures.DowntimeCost = Convert.ToDecimal(CurrentSimulationTable.Count) * Convert.ToDecimal(RepairTimeForOneBearing) * Convert.ToDecimal(DowntimeCost);
            CurrentPerformanceMeasures.RepairPersonCost = Convert.ToDecimal(CurrentSimulationTable.Count) * Convert.ToDecimal(RepairTimeForOneBearing) * Convert.ToDecimal(RepairPersonCost) / Convert.ToDecimal(60);
            CurrentPerformanceMeasures.TotalCost = CurrentPerformanceMeasures.BearingCost + CurrentPerformanceMeasures.DelayCost + CurrentPerformanceMeasures.DowntimeCost + CurrentPerformanceMeasures.RepairPersonCost;
        }
        public void fillSimulationTableForProposed()
        {
            int SumOfDelayTime = 0;
            int min = 1000000;
            Random rand = new Random();
            ProposedSimulationCase row = new ProposedSimulationCase();
            for (int j = 0; j < NumberOfBearings; j++)
            {
                Bearing bearing = new Bearing();
                bearing.Index = j + 1;
                bearing.RandomHours = CurrentSimulationTable[AccumulatedSetsNumbers[j]].Bearing.RandomHours;
                bearing.Hours = CurrentSimulationTable[AccumulatedSetsNumbers[j]].Bearing.Hours;
                row.Bearings.Add(bearing);
                if (min > bearing.Hours) min = bearing.Hours;
            }
            row.FirstFailure = min;
            row.AccumulatedHours = row.FirstFailure;
            row.RandomDelay = rand.Next(1, 100);
            row.Delay = SearchForHours(row.RandomDelay, DelayTimeDistribution);
            ProposedSimulationTable.Add(row);
            SumOfDelayTime += row.Delay;
            min = 100000;
            int i = 1;
            while (ProposedSimulationTable[i - 1].AccumulatedHours <= NumberOfHours)
            {
                row = new ProposedSimulationCase();
               
                for (int j = 0; j < NumberOfBearings; j++)
                {
                    Bearing bearing = new Bearing();
                    bearing.Index = j + 1;
                    if (AccumulatedSetsNumbers[j] + i < AccumulatedSetsNumbers[j + 1])
                    {

                        bearing.RandomHours = CurrentSimulationTable[AccumulatedSetsNumbers[j] + i].Bearing.RandomHours;
                        bearing.Hours = CurrentSimulationTable[AccumulatedSetsNumbers[j] + i].Bearing.Hours;
                        row.Bearings.Add(bearing);
                    }
                    else
                    {

                        bearing.RandomHours = rand.Next(1, 100);
                        bearing.Hours = SearchForHours(bearing.RandomHours, BearingLifeDistribution);
                        row.Bearings.Add(bearing);
                    }
                    if (min > bearing.Hours) min = bearing.Hours;
                }
                row.FirstFailure = min;
                row.AccumulatedHours = row.FirstFailure + ProposedSimulationTable[i - 1].AccumulatedHours;
                row.RandomDelay = rand.Next(1, 100);
                row.Delay = SearchForHours(row.RandomDelay, DelayTimeDistribution);
                ProposedSimulationTable.Add(row);
                SumOfDelayTime += row.Delay;
                min = 100000;
                i++;
            }
            ProposedPerformanceMeasures.BearingCost = Convert.ToDecimal(ProposedSimulationTable.Count) * NumberOfBearings * Convert.ToDecimal(BearingCost);
            ProposedPerformanceMeasures.DelayCost = Convert.ToDecimal(SumOfDelayTime) * Convert.ToDecimal(DowntimeCost);
            ProposedPerformanceMeasures.DowntimeCost = Convert.ToDecimal(ProposedSimulationTable.Count) * Convert.ToDecimal(RepairTimeForAllBearings) * Convert.ToDecimal(DowntimeCost);
            ProposedPerformanceMeasures.RepairPersonCost = Convert.ToDecimal(ProposedSimulationTable.Count) * Convert.ToDecimal(RepairTimeForAllBearings) * (Convert.ToDecimal(RepairPersonCost) / Convert.ToDecimal(60));
            ProposedPerformanceMeasures.TotalCost = ProposedPerformanceMeasures.BearingCost + ProposedPerformanceMeasures.DelayCost + ProposedPerformanceMeasures.DowntimeCost + ProposedPerformanceMeasures.RepairPersonCost;
        }
        public void runSystem(string filePath)
        {
            getSystemInformation(filePath);
            fillSimulationTableForCurrent();
            fillSimulationTableForProposed();
        }
    }
}