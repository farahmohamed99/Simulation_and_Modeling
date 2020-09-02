using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationCase
    {
        public SimulationCase()
        {
            this.AssignedServer = new Server();
        }

        public int CustomerNumber { get; set; }
        public int RandomInterArrival { get; set; }
        public int InterArrival { get; set; }
        public int ArrivalTime { get; set; }
        public int RandomService { get; set; }
        public int ServiceTime { get; set; }
        public Server AssignedServer { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int TimeInQueue { get; set; }

        private static Random randomNo = new Random();
        public static int randomNumber()
        {
            return randomNo.Next(1, 101);
        }


        public void generateRandomDigits()
        {
            Random rnd = new Random();

            RandomService = randomNumber();
            RandomInterArrival = randomNumber();
        }

        public void setInterArrivalTime(List<TimeDistribution> InterarrivalDistribution)
        {
            for (int i = 0; i < InterarrivalDistribution.Count; ++i)
            {
                if (RandomInterArrival >= InterarrivalDistribution[i].MinRange && RandomInterArrival <= InterarrivalDistribution[i].MaxRange)
                    InterArrival = InterarrivalDistribution[i].Time;
            }
        }
        public void setArrivalTime(int previousCustomerArrivalTime)
        {
            ArrivalTime = InterArrival + previousCustomerArrivalTime;
        }

        public void fillRemainingInfo(Server server)
        {
            AssignedServer = server;
            for (int i = 0; i < server.TimeDistribution.Count; ++i)
            {
                if (RandomService >= server.TimeDistribution[i].MinRange && RandomService <= server.TimeDistribution[i].MaxRange)
                    ServiceTime = server.TimeDistribution[i].Time;
            }

            StartTime = Math.Max(server.busyTill, ArrivalTime);
            EndTime = StartTime + ServiceTime;
            TimeInQueue = EndTime - ArrivalTime - ServiceTime;
        }
    }
}
