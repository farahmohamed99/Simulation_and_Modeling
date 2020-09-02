using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MultiQueueModels
{
    public class SimulationSystem
    {

        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }


        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public int EndSimulationTime { get; set; }
        public List<Server> Servers { get; set; }
        public decimal numberofCustomers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }
        public decimal[] total_serv_time { get; set; }
        public decimal[] customers_in_serv { get; set; }
        public decimal total_run_time { get; set; }
        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }


        public void fillSystemInformation(string filePath)
        {
            FileStream testCaseFile = new FileStream(filePath, FileMode.Open);
            StreamReader teseCaseReader = new StreamReader(testCaseFile);

            for (int i = 0; i < 13; ++i)
            {
                string Line = teseCaseReader.ReadLine();

                if (i % 3 == 1)
                {
                    if (i / 3 == 0)
                    {
                        this.NumberOfServers = int.Parse(Line);
                    }
                    else if (i / 3 == 1)
                    {
                        this.StoppingNumber = int.Parse(Line);
                    }
                    else if (i / 3 == 2)
                    {

                        this.StoppingCriteria = (Enums.StoppingCriteria)(int.Parse(Line));
                    }
                    else
                    {
                        this.SelectionMethod = (Enums.SelectionMethod)(int.Parse(Line));
                    }
                }
            }

            while (true)
            {
                string Line = teseCaseReader.ReadLine();
                if (String.IsNullOrEmpty(Line) || String.IsNullOrWhiteSpace(Line)) break;

                Line = Line.Replace(" ", "");
                string[] values = Line.Split(',');

                TimeDistribution Element = new TimeDistribution();
                Element.Time = int.Parse(values[0]);
                Element.Probability = decimal.Parse(values[1]);
                this.InterarrivalDistribution.Add(Element);
            }

            for (int i = 1; i <= this.NumberOfServers; ++i)
            {
                Server newServer = new Server();
                newServer.ID = i;
                string Line = teseCaseReader.ReadLine();
                while (true)
                {
                    Line = teseCaseReader.ReadLine();
                    if (String.IsNullOrEmpty(Line) || String.IsNullOrWhiteSpace(Line)) break;

                    Line = Line.Replace(" ", "");
                    string[] values = Line.Split(',');


                    TimeDistribution Element = new TimeDistribution();
                    Element.Time = int.Parse(values[0]);
                    Element.Probability = decimal.Parse(values[1]);
                    newServer.TimeDistribution.Add(Element);
                }
                this.Servers.Add(newServer);
            }
            testCaseFile.Close();
        }

        public void fillInterarrivalDistributionTable()
        {
            for (int i = 0; i < InterarrivalDistribution.Count; ++i)
            {
                if (i == 0)
                    InterarrivalDistribution[i].fillRemainingInfo(Convert.ToDecimal(0));
                else
                    InterarrivalDistribution[i].fillRemainingInfo(InterarrivalDistribution[i - 1].CummProbability);
            }
        }


        public void fillSystemDistributionTables()
        {
            fillInterarrivalDistributionTable();
            for (int i = 0; i < NumberOfServers; ++i)
                Servers[i].fillTimeDistributionTable();
        }

        public void fillSimulationTable()
        {
            total_serv_time = new Decimal[Servers.Count + 1];
             customers_in_serv = new Decimal[Servers.Count + 1];
             total_run_time = -1;
            int customerID = 1;
            while (true)
            {
                if (StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                {
                    if (customerID > StoppingNumber) break;
                }

                SimulationCase currentCustomer = new SimulationCase();
                currentCustomer.CustomerNumber = customerID;

                currentCustomer.generateRandomDigits();

                if (customerID != 1)
                {
                    currentCustomer.setInterArrivalTime(InterarrivalDistribution);
                }


                if (customerID == 1)
                    currentCustomer.ArrivalTime = 0;
                else
                    currentCustomer.setArrivalTime(SimulationTable[customerID - 2].ArrivalTime);


                if (StoppingCriteria == Enums.StoppingCriteria.SimulationEndTime)
                {
                    if (currentCustomer.ArrivalTime > StoppingNumber) break;
                }

                List<Tuple<int, int>> IdleServers = new List<Tuple<int, int>>();

                for (int i = 0; i < NumberOfServers; ++i)
                    IdleServers.Add(new Tuple<int, int>(Servers[i].busyTill, i));

                IdleServers = IdleServers.OrderBy(t => t.Item1).ToList();

                List<Tuple<int, int>> IdleEqualServers = new List<Tuple<int, int>>();
                IdleEqualServers.Add(IdleServers[0]);
                for (int i = 1; i < IdleServers.Count; ++i)
                    if (IdleServers[i].Item1 == IdleServers[0].Item1 || IdleServers[i].Item1 <= currentCustomer.ArrivalTime)
                    {
                        IdleEqualServers.Add(IdleServers[i]);
                    }

                if (IdleEqualServers.Count == 1)
                {
                    int serverIndex = IdleEqualServers[0].Item2;
                    currentCustomer.fillRemainingInfo(Servers[serverIndex]);
                    Servers[serverIndex].updateServer(currentCustomer);
                    total_serv_time[currentCustomer.AssignedServer.ID] += currentCustomer.ServiceTime;
                    customers_in_serv[currentCustomer.AssignedServer.ID]++;
                    total_run_time = Math.Max(total_run_time, currentCustomer.EndTime);
                }
                else
                {
                    List<int> freeServerIndexes = new List<int>();

                    int highestServerIndex = 1000;
                    if (SelectionMethod == Enums.SelectionMethod.HighestPriority)
                    {
                        for (int i = 0; i < IdleEqualServers.Count; ++i)
                        {
                            freeServerIndexes.Add(IdleEqualServers[i].Item2);
                            if (IdleEqualServers[i].Item2 < highestServerIndex)
                                highestServerIndex = IdleEqualServers[i].Item2;
                        }

                        int serverIndex = highestServerIndex;
                        currentCustomer.fillRemainingInfo(Servers[serverIndex]);
                        Servers[serverIndex].updateServer(currentCustomer);

                        total_serv_time[currentCustomer.AssignedServer.ID] += currentCustomer.ServiceTime;
                        customers_in_serv[currentCustomer.AssignedServer.ID]++;
                        total_run_time = Math.Max(total_run_time, currentCustomer.EndTime);
                    }
                    else if (SelectionMethod == Enums.SelectionMethod.Random)
                    {
                        int selectedServer = new Random().Next(0, IdleEqualServers.Count-1);
                        int serverIndex = IdleEqualServers[selectedServer].Item2;
                        currentCustomer.fillRemainingInfo(Servers[serverIndex]);
                        Servers[serverIndex].updateServer(currentCustomer);

                        total_serv_time[currentCustomer.AssignedServer.ID] += currentCustomer.ServiceTime;
                        customers_in_serv[currentCustomer.AssignedServer.ID]++;
                        total_run_time = Math.Max(total_run_time, currentCustomer.EndTime);
                    }
                    else if(SelectionMethod == Enums.SelectionMethod.LeastUtilization)
                    {  

                        ///to get newest run time 
                        new_updates_inserv();
                        int min_index=0;
                        decimal min_utilization = 100000;
                        for (int i = 0; i < IdleEqualServers.Count; ++i)
                        { 
                            int serv_ind = IdleEqualServers[i].Item2;
                            decimal val = decimal.Compare(Servers[serv_ind].Utilization, min_utilization);
                            if (Convert.ToInt32(val)<0)
                            {
                                min_index = serv_ind;
                                min_utilization = Servers[serv_ind].Utilization;
                            }
                            else if (Convert.ToInt32(val) == 0)
                            {    if(Servers[serv_ind].ID<Servers[min_index].ID)
                                min_index = serv_ind;
                                min_utilization = Servers[serv_ind].Utilization;
                            }

                        }
                        currentCustomer.fillRemainingInfo(Servers[min_index]);
                        Servers[min_index].updateServer(currentCustomer);

                        total_serv_time[currentCustomer.AssignedServer.ID] += currentCustomer.ServiceTime;
                        customers_in_serv[currentCustomer.AssignedServer.ID]++;
                        total_run_time = Math.Max(total_run_time, currentCustomer.EndTime);
                    }
                }
                ++customerID;
                SimulationTable.Add(currentCustomer);
            }
            numberofCustomers = customerID - 1;
        }

       
        public void runSystem(string filePath)
        {
            fillSystemInformation(filePath);
            fillSystemDistributionTables();
            fillSimulationTable();
            PerformanceMeasures.fill_data(SimulationTable, numberofCustomers);
            new_updates_inserv();
            EndSimulationTime = (int)(total_run_time);
        }

        public void new_updates_inserv()
        {
            for (int i = 0; i < Servers.Count; ++i)
            {
                Servers[i].update_data(customers_in_serv[i + 1], total_serv_time[i + 1], total_run_time);
            }

        }
    }
}
