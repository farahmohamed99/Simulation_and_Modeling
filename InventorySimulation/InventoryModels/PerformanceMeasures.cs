using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {

        }
        public decimal EndingInventoryAverage { get; set; }

        public decimal ShortageQuantityAverage { get; set; }

        public void calculatePerformanceMeasures(List<SimulationCase> SimulationTable)
        {
            int EndingInventoryTotal = 0;
            int ShortageQuantityTotal = 0;
            for (int i = 0; i < SimulationTable.Count; ++i)
            {
                EndingInventoryTotal += SimulationTable[i].EndingInventory;
                ShortageQuantityTotal += SimulationTable[i].ShortageQuantity;
            }

            EndingInventoryAverage = Convert.ToDecimal(EndingInventoryTotal) / Convert.ToDecimal(SimulationTable.Count);
            ShortageQuantityAverage = Convert.ToDecimal(ShortageQuantityTotal) / Convert.ToDecimal(SimulationTable.Count);


        }

    }
}
