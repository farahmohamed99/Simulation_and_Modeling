using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineTesting;
using System.IO;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var path = Path.GetFullPath(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) + @"\TestCases\TestCase1.txt"); //get fule path
            Program.Sys.runSystem(path); //Sys is object from SimulationSystem
            MessageBox.Show(TestingManager.Test(Program.Sys, Constants.FileNames.TestCase1));
            ////// fill datagridview for current policy
            CurrentSimTable.ColumnCount = 6;
            CurrentSimTable.Columns[0].HeaderText = "index";
            CurrentSimTable.Columns[1].HeaderText = "RD*";
            CurrentSimTable.Columns[2].HeaderText = "Life";
            CurrentSimTable.Columns[3].HeaderText = "Accumulated life";
            CurrentSimTable.Columns[4].HeaderText = "RD";
            CurrentSimTable.Columns[5].HeaderText = "Delay";
            for (int i = 0; i < Program.Sys.CurrentSimulationTable.Count; ++i)
            {
                int rowId = CurrentSimTable.Rows.Add();
                DataGridViewRow row = CurrentSimTable.Rows[rowId];

                row.Cells[0].Value = Program.Sys.CurrentSimulationTable[i].Bearing.Index;
                row.Cells[1].Value = Program.Sys.CurrentSimulationTable[i].Bearing.RandomHours;
                row.Cells[2].Value = Program.Sys.CurrentSimulationTable[i].Bearing.Hours;
                row.Cells[3].Value = Program.Sys.CurrentSimulationTable[i].AccumulatedHours;
                row.Cells[4].Value = Program.Sys.CurrentSimulationTable[i].RandomDelay;
                row.Cells[5].Value = Program.Sys.CurrentSimulationTable[i].Delay;
            }
            CostOfBearings1.Text = Program.Sys.CurrentPerformanceMeasures.BearingCost.ToString();
            CostOfDelayTime1.Text = Program.Sys.CurrentPerformanceMeasures.DelayCost.ToString();
            CostOfDowntimeDuringrepairs1.Text = Program.Sys.CurrentPerformanceMeasures.DowntimeCost.ToString();
            CostOfRapairpersons1.Text = Program.Sys.CurrentPerformanceMeasures.RepairPersonCost.ToString();
            TotalCost1.Text = Program.Sys.CurrentPerformanceMeasures.TotalCost.ToString();



            ////// fill datagridview for current policy
            ////// fill datagridview for proppsed policy
            ProposedSimTable.ColumnCount = 5 + Program.Sys.NumberOfBearings;
            ProposedSimTable.Columns[0].HeaderText = "index";
            int x = 1;
            for (int i = 0; i < Program.Sys.NumberOfBearings; ++i)
            {
                ProposedSimTable.Columns[i + 1].HeaderText = "Bearing " + (i+1).ToString() + " life";
                x++;
            }
            ProposedSimTable.Columns[x].HeaderText = "First Failure";
            ProposedSimTable.Columns[x + 1].HeaderText = "Accumulated life";
            ProposedSimTable.Columns[x + 2].HeaderText = "RD";
            ProposedSimTable.Columns[x + 3].HeaderText = "Delay";

            for (int i = 0; i < Program.Sys.ProposedSimulationTable.Count; ++i)
            {
                int rowId = ProposedSimTable.Rows.Add();
                DataGridViewRow row = ProposedSimTable.Rows[rowId];

                row.Cells[0].Value = i+1;
                int z = 1;
                for (int j = 0; j < Program.Sys.NumberOfBearings; ++j)
                {
                    row.Cells[j+1].Value = Program.Sys.ProposedSimulationTable[i].Bearings[j].Hours;
                    z++;
                }

                row.Cells[z].Value = Program.Sys.ProposedSimulationTable[i].FirstFailure;
                row.Cells[z+1].Value = Program.Sys.ProposedSimulationTable[i].AccumulatedHours;
                row.Cells[z + 2].Value = Program.Sys.ProposedSimulationTable[i].RandomDelay;
                row.Cells[z + 3].Value = Program.Sys.ProposedSimulationTable[i].Delay;
            }
            CostOfBearings2.Text = Program.Sys.ProposedPerformanceMeasures.BearingCost.ToString();
            CostOfDelayTime2.Text = Program.Sys.ProposedPerformanceMeasures.DelayCost.ToString();
            CostOfDowntimeDuringrepairs2.Text = Program.Sys.ProposedPerformanceMeasures.DowntimeCost.ToString();
            CostOfRapairpersons2.Text = Program.Sys.ProposedPerformanceMeasures.RepairPersonCost.ToString();
            TotalCost2.Text = Program.Sys.ProposedPerformanceMeasures.TotalCost.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TotalCost1_Click(object sender, EventArgs e)
        {

        }

        private void CurrentSimTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProposedSimTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
