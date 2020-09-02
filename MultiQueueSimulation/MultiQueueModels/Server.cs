using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        public int busyTill { get; set; }

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }

        public void fillTimeDistributionTable()
        {
            for (int i = 0; i < TimeDistribution.Count; ++i)
            {
                if (i == 0)
                    TimeDistribution[i].fillRemainingInfo(Convert.ToDecimal(0));
                else
                    TimeDistribution[i].fillRemainingInfo(TimeDistribution[i - 1].CummProbability);
            }
        }

        public void updateServer(SimulationCase customer)
        {
            busyTill = Math.Max(busyTill, customer.ArrivalTime) + customer.ServiceTime;
        }

        public void update_data(decimal customers_in_serv, decimal total_serv_time, decimal total_run_time)
        {
            if (customers_in_serv != 0)
            {
                AverageServiceTime = total_serv_time / customers_in_serv;
            }
            else
                AverageServiceTime = 0;

            IdleProbability = (total_run_time - total_serv_time) / total_run_time;
           Utilization = total_serv_time / total_run_time;
        }

    }
}
