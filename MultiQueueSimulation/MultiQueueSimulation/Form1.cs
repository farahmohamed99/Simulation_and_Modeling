using MultiQueueTesting;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public static int SelectedServer;
        public Form1()
        {
            InitializeComponent();
            var p = Path.GetFullPath(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +@"\TestCases\TestCase2.txt");
            Program.Sys.runSystem(p);
            MessageBox.Show(Program.Sys.SelectionMethod.ToString());
            MessageBox.Show(TestingManager.Test(Program.Sys, Constants.FileNames.TestCase2));        

            for(int i = 0;i < Program.Sys.SimulationTable.Count; ++i)
            {
                int rowId = SimTable.Rows.Add();
                DataGridViewRow row = SimTable.Rows[rowId];

                row.Cells[0].Value = Program.Sys.SimulationTable[i].CustomerNumber;
                row.Cells[1].Value = Program.Sys.SimulationTable[i].RandomInterArrival;
                row.Cells[2].Value = Program.Sys.SimulationTable[i].InterArrival;
                row.Cells[3].Value = Program.Sys.SimulationTable[i].ArrivalTime;
                row.Cells[4].Value = Program.Sys.SimulationTable[i].RandomService;
                row.Cells[5].Value = Program.Sys.SimulationTable[i].AssignedServer.ID;
                row.Cells[6].Value = Program.Sys.SimulationTable[i].StartTime;
                row.Cells[7].Value = Program.Sys.SimulationTable[i].ServiceTime;
                row.Cells[8].Value = Program.Sys.SimulationTable[i].EndTime;
                row.Cells[9].Value = Program.Sys.SimulationTable[i].TimeInQueue;
            }
            AverageWaitingTime.Text = Program.Sys.PerformanceMeasures.AverageWaitingTime.ToString();
            MaxQueueLength.Text = Program.Sys.PerformanceMeasures.MaxQueueLength.ToString();
            WaitingProbability.Text = Program.Sys.PerformanceMeasures.WaitingProbability.ToString();


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

        private void ServerNumber_Click(object sender, EventArgs e)
        {
            ServerNumber.Text = "";
        }

        private void ShowServerInfo_Click(object sender, EventArgs e)
        {
            Form1.SelectedServer = int.Parse(ServerNumber.Text);
            Form f = new Server();
            f.Show();
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
