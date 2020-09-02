namespace MultiQueueSimulation
{
    partial class Form1
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
            this.SimTable = new System.Windows.Forms.DataGridView();
            this.customerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomInterArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AverageWaitingTime = new System.Windows.Forms.Label();
            this.MaxQueueLength = new System.Windows.Forms.Label();
            this.WaitingProbability = new System.Windows.Forms.Label();
            this.ServerNumber = new System.Windows.Forms.TextBox();
            this.ShowServerInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SimTable
            // 
            this.SimTable.AllowUserToAddRows = false;
            this.SimTable.AllowUserToDeleteRows = false;
            this.SimTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SimTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNo,
            this.randomInterArrival,
            this.interArrival,
            this.Arrival,
            this.randomService,
            this.server,
            this.startTime,
            this.serviceTime,
            this.endTime,
            this.waiting});
            this.SimTable.Location = new System.Drawing.Point(3, 65);
            this.SimTable.Name = "SimTable";
            this.SimTable.ReadOnly = true;
            this.SimTable.Size = new System.Drawing.Size(1074, 318);
            this.SimTable.TabIndex = 0;
            // 
            // customerNo
            // 
            this.customerNo.HeaderText = "Customer No.";
            this.customerNo.Name = "customerNo";
            this.customerNo.ReadOnly = true;
            // 
            // randomInterArrival
            // 
            this.randomInterArrival.HeaderText = "Random Digits for Arrival";
            this.randomInterArrival.Name = "randomInterArrival";
            this.randomInterArrival.ReadOnly = true;
            // 
            // interArrival
            // 
            this.interArrival.HeaderText = "Time between Arrivals";
            this.interArrival.Name = "interArrival";
            this.interArrival.ReadOnly = true;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Clock Time of Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            // 
            // randomService
            // 
            this.randomService.HeaderText = "Random Digits for Service";
            this.randomService.Name = "randomService";
            this.randomService.ReadOnly = true;
            // 
            // server
            // 
            this.server.HeaderText = "Assigned Server";
            this.server.Name = "server";
            this.server.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start Time";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // serviceTime
            // 
            this.serviceTime.HeaderText = "Service Time";
            this.serviceTime.Name = "serviceTime";
            this.serviceTime.ReadOnly = true;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "End Time";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            // 
            // waiting
            // 
            this.waiting.HeaderText = "Time in Queue";
            this.waiting.Name = "waiting";
            this.waiting.ReadOnly = true;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Close.Location = new System.Drawing.Point(1046, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.TabIndex = 3;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Minimize.Location = new System.Drawing.Point(1002, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 40);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Multi-Queue Simulation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(49, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Average Waiting Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(87, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Queue Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(94, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Waiting Probability";
            // 
            // AverageWaitingTime
            // 
            this.AverageWaitingTime.AutoSize = true;
            this.AverageWaitingTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageWaitingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.AverageWaitingTime.Location = new System.Drawing.Point(370, 397);
            this.AverageWaitingTime.Name = "AverageWaitingTime";
            this.AverageWaitingTime.Size = new System.Drawing.Size(22, 33);
            this.AverageWaitingTime.TabIndex = 9;
            this.AverageWaitingTime.Text = ".";
            // 
            // MaxQueueLength
            // 
            this.MaxQueueLength.AutoSize = true;
            this.MaxQueueLength.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxQueueLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.MaxQueueLength.Location = new System.Drawing.Point(370, 444);
            this.MaxQueueLength.Name = "MaxQueueLength";
            this.MaxQueueLength.Size = new System.Drawing.Size(22, 33);
            this.MaxQueueLength.TabIndex = 10;
            this.MaxQueueLength.Text = ".";
            // 
            // WaitingProbability
            // 
            this.WaitingProbability.AutoSize = true;
            this.WaitingProbability.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingProbability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.WaitingProbability.Location = new System.Drawing.Point(370, 489);
            this.WaitingProbability.Name = "WaitingProbability";
            this.WaitingProbability.Size = new System.Drawing.Size(22, 33);
            this.WaitingProbability.TabIndex = 11;
            this.WaitingProbability.Text = ".";
            // 
            // ServerNumber
            // 
            this.ServerNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerNumber.Location = new System.Drawing.Point(764, 430);
            this.ServerNumber.Multiline = true;
            this.ServerNumber.Name = "ServerNumber";
            this.ServerNumber.Size = new System.Drawing.Size(241, 32);
            this.ServerNumber.TabIndex = 12;
            this.ServerNumber.Text = "Enter Server No.";
            this.ServerNumber.Click += new System.EventHandler(this.ServerNumber_Click);
            // 
            // ShowServerInfo
            // 
            this.ShowServerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.ShowServerInfo.FlatAppearance.BorderSize = 0;
            this.ShowServerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowServerInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowServerInfo.ForeColor = System.Drawing.Color.White;
            this.ShowServerInfo.Location = new System.Drawing.Point(779, 468);
            this.ShowServerInfo.Name = "ShowServerInfo";
            this.ShowServerInfo.Size = new System.Drawing.Size(213, 44);
            this.ShowServerInfo.TabIndex = 13;
            this.ShowServerInfo.Text = "Show Server Information";
            this.ShowServerInfo.UseVisualStyleBackColor = false;
            this.ShowServerInfo.Click += new System.EventHandler(this.ShowServerInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1089, 541);
            this.Controls.Add(this.ShowServerInfo);
            this.Controls.Add(this.ServerNumber);
            this.Controls.Add(this.WaitingProbability);
            this.Controls.Add(this.MaxQueueLength);
            this.Controls.Add(this.AverageWaitingTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.SimTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SimTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomInterArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn interArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomService;
        private System.Windows.Forms.DataGridViewTextBoxColumn server;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiting;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AverageWaitingTime;
        private System.Windows.Forms.Label MaxQueueLength;
        private System.Windows.Forms.Label WaitingProbability;
        private System.Windows.Forms.TextBox ServerNumber;
        private System.Windows.Forms.Button ShowServerInfo;
    }
}

