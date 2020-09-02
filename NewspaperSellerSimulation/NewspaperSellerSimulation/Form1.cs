using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var path = Path.GetFullPath(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) + @"\TestCases\TestCase2.txt");
            Program.Sys.runSystem(path);
            MessageBox.Show(TestingManager.Test(Program.Sys, Constants.FileNames.TestCase2)); 
            for (int i = 0; i < Program.Sys.SimulationTable.Count; ++i)
            {
                int rowId = SimTable.Rows.Add();
                DataGridViewRow row = SimTable.Rows[rowId];

                row.Cells[0].Value = Program.Sys.SimulationTable[i].DayNo;
                row.Cells[1].Value = Program.Sys.SimulationTable[i].RandomNewsDayType;
                row.Cells[2].Value = Program.Sys.SimulationTable[i].NewsDayType;
                row.Cells[3].Value = Program.Sys.SimulationTable[i].RandomDemand;
                row.Cells[4].Value = Program.Sys.SimulationTable[i].Demand;
                row.Cells[5].Value = Program.Sys.SimulationTable[i].DailyCost;
                row.Cells[6].Value = Program.Sys.SimulationTable[i].SalesProfit;
                row.Cells[7].Value = Program.Sys.SimulationTable[i].LostProfit;
                row.Cells[8].Value = Program.Sys.SimulationTable[i].ScrapProfit;
                row.Cells[9].Value = Program.Sys.SimulationTable[i].DailyNetProfit;
            }
            TotalSalesRevenue.Text = Program.Sys.PerformanceMeasures.TotalSalesProfit.ToString();
            TotalCostofNewspapers.Text = Program.Sys.PerformanceMeasures.TotalCost.ToString();
            TotalLostProfitfromExcessDemand.Text = Program.Sys.PerformanceMeasures.TotalLostProfit.ToString();
            TotalSalvagefromsaleofScrappapers.Text = Program.Sys.PerformanceMeasures.TotalScrapProfit.ToString();
            NetProfit.Text = Program.Sys.PerformanceMeasures.TotalNetProfit.ToString();
            Numberofdayshavingexcessdemand.Text = Program.Sys.PerformanceMeasures.DaysWithMoreDemand.ToString();
            Numberofdayshavingunsoldpapers.Text = Program.Sys.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SimTable.BorderStyle = BorderStyle.None;

            SimTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 241, 249);
            SimTable.RowsDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);

            SimTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SimTable.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            SimTable.DefaultCellStyle.SelectionForeColor = Color.White;
            SimTable.BackgroundColor = Color.White;
            SimTable.EnableHeadersVisualStyles = false;
            SimTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            SimTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 112, 136);
            SimTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SimTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Bold);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
