namespace MultiQueueSimulation
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ServerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdleProbability = new System.Windows.Forms.Label();
            this.AverageServiceTime = new System.Windows.Forms.Label();
            this.Utilization = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerChart
            // 
            this.ServerChart.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.ServerChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ServerChart.Legends.Add(legend2);
            this.ServerChart.Location = new System.Drawing.Point(121, 80);
            this.ServerChart.Name = "ServerChart";
            this.ServerChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))))};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Busy";
            this.ServerChart.Series.Add(series2);
            this.ServerChart.Size = new System.Drawing.Size(530, 247);
            this.ServerChart.TabIndex = 21;
            this.ServerChart.Text = "ServerChart";
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Minimize.Location = new System.Drawing.Point(713, 1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 40);
            this.Minimize.TabIndex = 23;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Close.Location = new System.Drawing.Point(757, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.TabIndex = 22;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ServerLabel.Location = new System.Drawing.Point(50, 21);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(97, 33);
            this.ServerLabel.TabIndex = 24;
            this.ServerLabel.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.label1.Location = new System.Drawing.Point(155, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Idle Probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(62, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Average Service Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(206, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Utilization";
            // 
            // IdleProbability
            // 
            this.IdleProbability.AutoSize = true;
            this.IdleProbability.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdleProbability.ForeColor = System.Drawing.Color.White;
            this.IdleProbability.Location = new System.Drawing.Point(393, 355);
            this.IdleProbability.Name = "IdleProbability";
            this.IdleProbability.Size = new System.Drawing.Size(22, 33);
            this.IdleProbability.TabIndex = 28;
            this.IdleProbability.Text = ".";
            // 
            // AverageServiceTime
            // 
            this.AverageServiceTime.AutoSize = true;
            this.AverageServiceTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageServiceTime.ForeColor = System.Drawing.Color.White;
            this.AverageServiceTime.Location = new System.Drawing.Point(393, 399);
            this.AverageServiceTime.Name = "AverageServiceTime";
            this.AverageServiceTime.Size = new System.Drawing.Size(22, 33);
            this.AverageServiceTime.TabIndex = 29;
            this.AverageServiceTime.Text = ".";
            // 
            // Utilization
            // 
            this.Utilization.AutoSize = true;
            this.Utilization.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilization.ForeColor = System.Drawing.Color.White;
            this.Utilization.Location = new System.Drawing.Point(393, 445);
            this.Utilization.Name = "Utilization";
            this.Utilization.Size = new System.Drawing.Size(22, 33);
            this.Utilization.TabIndex = 30;
            this.Utilization.Text = ".";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Utilization);
            this.Controls.Add(this.AverageServiceTime);
            this.Controls.Add(this.IdleProbability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ServerChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.ServerChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ServerChart;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IdleProbability;
        private System.Windows.Forms.Label AverageServiceTime;
        private System.Windows.Forms.Label Utilization;
    }
}