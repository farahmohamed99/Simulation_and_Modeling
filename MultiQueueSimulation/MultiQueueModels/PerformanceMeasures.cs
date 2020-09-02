using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueModels
{
    public class PerformanceMeasures
    {
        public decimal AverageWaitingTime { get; set; }
        public int MaxQueueLength { get; set; }
        //public int MaxQueueLength2 { get; set; }

        public decimal WaitingProbability { get; set; }


        public void fill_data(List<SimulationCase> SimulationTable, decimal numberofCustomers)
        {

            decimal sum = 0;
            int num_of_waited = 0;
            int max_queue = -1;
            int num = 0;
            List<int> start_served = new List<int>();
            List<int> arrival = new List<int>();
            for (int i = 0; i < SimulationTable.Count; ++i)
            {
                //////// for performance
                sum += SimulationTable.ElementAt(i).TimeInQueue;

                if (SimulationTable.ElementAt(i).TimeInQueue != 0)
                {
                    start_served.Add(SimulationTable.ElementAt(i).StartTime);
                    arrival.Add(SimulationTable.ElementAt(i).ArrivalTime);
                    ++num_of_waited;
                }
                else if (SimulationTable.ElementAt(i).TimeInQueue == 0 && start_served.Count != 0)
                {
                    if (start_served.Count == 1)
                    {
                        max_queue = Math.Max(max_queue, 1);
                    }
                    else
                    {
                        for (int k = 1; k < start_served.Count; ++k)
                        {
                            num = 1;
                            int l = 0;
                            int r = k - 1;
                            int num_remind_greater = k;
                            while (l <= r)
                            {
                                int m = l + (r - l) / 2;

                                if (start_served.ElementAt(m) > arrival.ElementAt(k))
                                {
                                    num_remind_greater = m;
                                    r = m - 1;
                                }

                                else
                                    l = m + 1;
                            }

                            num += (k - num_remind_greater);
                            max_queue = Math.Max(max_queue, num);

                        }


                    }
                    start_served.Clear();
                    arrival.Clear();

                }

            }

            if (start_served.Count != 0)
            {

                if (start_served.Count == 1)
                {
                    max_queue = Math.Max(max_queue, 1);
                }
                else
                {
                    for (int k = 1; k < start_served.Count; ++k)
                    {
                        num = 1;
                        int l = 0;
                        int r = k - 1;
                        int num_remind_greater = k;
                        while (l <= r)
                        {
                            int m = l + (r - l) / 2;

                            if (start_served.ElementAt(m) > arrival.ElementAt(k))
                            {
                                num_remind_greater = m;
                                r = m - 1;
                            }

                            else
                                l = m + 1;
                        }

                        num += (k - num_remind_greater);
                        max_queue = Math.Max(max_queue, num);

                    }


                }
                start_served.Clear();
                arrival.Clear();

            }


            max_queue = Math.Max(0, max_queue);
            MaxQueueLength = max_queue;
            AverageWaitingTime = sum / (numberofCustomers);
            WaitingProbability = num_of_waited / (numberofCustomers);
        }



    }
}
