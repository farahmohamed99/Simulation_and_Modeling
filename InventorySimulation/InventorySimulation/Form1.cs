using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;
using System.IO;


namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var testCasePath = Path.GetFullPath(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) + @"\TestCases\TestCase4.txt");
            Program.inventorySystem.fillSystemInformation(testCasePath);

            Program.inventorySystem.fillSystemDistributionTables();

            Program.inventorySystem.runSystem();

            MessageBox.Show(TestingManager.Test(Program.inventorySystem, Constants.FileNames.TestCase4));

            for (int i = 0; i < Program.inventorySystem.SimulationTable.Count; ++i)
            {
                int rowId = SimTable.Rows.Add();
                DataGridViewRow row = SimTable.Rows[rowId];

                row.Cells[0].Value = Program.inventorySystem.SimulationTable[i].Day;
                row.Cells[1].Value = Program.inventorySystem.SimulationTable[i].Cycle;
                row.Cells[2].Value = Program.inventorySystem.SimulationTable[i].DayWithinCycle;
                row.Cells[3].Value = Program.inventorySystem.SimulationTable[i].BeginningInventory;
                row.Cells[4].Value = Program.inventorySystem.SimulationTable[i].RandomDemand;
                row.Cells[5].Value = Program.inventorySystem.SimulationTable[i].Demand;
                row.Cells[6].Value = Program.inventorySystem.SimulationTable[i].EndingInventory;
                row.Cells[7].Value = Program.inventorySystem.SimulationTable[i].ShortageQuantity;
                row.Cells[8].Value = Program.inventorySystem.SimulationTable[i].OrderQuantity;
                row.Cells[9].Value = Program.inventorySystem.SimulationTable[i].RandomLeadDays;
                row.Cells[10].Value = Program.inventorySystem.SimulationTable[i].LeadDays;
                row.Cells[11].Value = Program.inventorySystem.SimulationTable[i].DaysUntilOrderArrives;

            }
            EndingInventoryAverage.Text = Program.inventorySystem.PerformanceMeasures.EndingInventoryAverage.ToString();
            ShortageQuantityAverage.Text = Program.inventorySystem.PerformanceMeasures.ShortageQuantityAverage.ToString();



        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
