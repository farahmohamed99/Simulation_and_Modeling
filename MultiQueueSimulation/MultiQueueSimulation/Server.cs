using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            ServerLabel.Text += " ";
            ServerLabel.Text += Form1.SelectedServer.ToString();
            int start = -1;
            int end = -1;
             for(int i = 0; i < Program.Sys.SimulationTable.Count;++i)
             {

                 if(Program.Sys.SimulationTable[i].AssignedServer.ID == Form1.SelectedServer)
                 {
                    end = Program.Sys.SimulationTable[i].StartTime - 1;
                    if(start != -1)
                    {
                        for(int j = start; j <= end; ++j)
                        {
                            ServerChart.Series["Busy"].Points.AddXY(j.ToString(), "0");
                        }
                    }
                    else
                    {
                        for(int j = 1; j <= end; ++j)
                        {
                            ServerChart.Series["Busy"].Points.AddXY(j.ToString(), "0");
                        }
                    }
                     for (int j = Program.Sys.SimulationTable[i].StartTime; j <= Program.Sys.SimulationTable[i].EndTime;++j)
                     {
                         ServerChart.Series["Busy"].Points.AddXY(j.ToString(), "1");
                     }
                    start = Program.Sys.SimulationTable[i].EndTime + 1;
                 }

             }

            if (start == -1)
                start = 1;
            for(int i = start; i <= Program.Sys.EndSimulationTime; ++i)
            {
                ServerChart.Series["Busy"].Points.AddXY(i.ToString(), "0");
            }


            IdleProbability.Text = Program.Sys.Servers[Form1.SelectedServer - 1].IdleProbability.ToString("0.###");
            AverageServiceTime.Text = Program.Sys.Servers[Form1.SelectedServer - 1].AverageServiceTime.ToString("0.###") ;
            Utilization.Text = Program.Sys.Servers[Form1.SelectedServer - 1].Utilization.ToString("0.###");



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
