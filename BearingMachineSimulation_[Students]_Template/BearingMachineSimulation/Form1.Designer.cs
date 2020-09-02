namespace BearingMachineSimulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentSimTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CostOfBearings1 = new System.Windows.Forms.Label();
            this.CostOfDelayTime1 = new System.Windows.Forms.Label();
            this.CostOfDowntimeDuringrepairs1 = new System.Windows.Forms.Label();
            this.CostOfRapairpersons1 = new System.Windows.Forms.Label();
            this.TotalCost1 = new System.Windows.Forms.Label();
            this.ProposedSimTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalCost2 = new System.Windows.Forms.Label();
            this.CostOfRapairpersons2 = new System.Windows.Forms.Label();
            this.CostOfDowntimeDuringrepairs2 = new System.Windows.Forms.Label();
            this.CostOfDelayTime2 = new System.Windows.Forms.Label();
            this.CostOfBearings2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentSimTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProposedSimTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Policy";
            // 
            // CurrentSimTable
            // 
            this.CurrentSimTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentSimTable.Location = new System.Drawing.Point(5, 42);
            this.CurrentSimTable.Name = "CurrentSimTable";
            this.CurrentSimTable.RowHeadersWidth = 51;
            this.CurrentSimTable.Size = new System.Drawing.Size(524, 337);
            this.CurrentSimTable.TabIndex = 1;
            this.CurrentSimTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentSimTable_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost Of Bearings :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost Of Delay Time :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost Of Downtime During repairs :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cost Of Repairpersons :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Cost :";
            // 
            // CostOfBearings1
            // 
            this.CostOfBearings1.AutoSize = true;
            this.CostOfBearings1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfBearings1.Location = new System.Drawing.Point(305, 392);
            this.CostOfBearings1.Name = "CostOfBearings1";
            this.CostOfBearings1.Size = new System.Drawing.Size(15, 22);
            this.CostOfBearings1.TabIndex = 9;
            this.CostOfBearings1.Text = ".";
            // 
            // CostOfDelayTime1
            // 
            this.CostOfDelayTime1.AutoSize = true;
            this.CostOfDelayTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfDelayTime1.Location = new System.Drawing.Point(305, 430);
            this.CostOfDelayTime1.Name = "CostOfDelayTime1";
            this.CostOfDelayTime1.Size = new System.Drawing.Size(15, 22);
            this.CostOfDelayTime1.TabIndex = 10;
            this.CostOfDelayTime1.Text = ".";
            this.CostOfDelayTime1.Click += new System.EventHandler(this.label9_Click);
            // 
            // CostOfDowntimeDuringrepairs1
            // 
            this.CostOfDowntimeDuringrepairs1.AutoSize = true;
            this.CostOfDowntimeDuringrepairs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfDowntimeDuringrepairs1.Location = new System.Drawing.Point(305, 475);
            this.CostOfDowntimeDuringrepairs1.Name = "CostOfDowntimeDuringrepairs1";
            this.CostOfDowntimeDuringrepairs1.Size = new System.Drawing.Size(15, 22);
            this.CostOfDowntimeDuringrepairs1.TabIndex = 11;
            this.CostOfDowntimeDuringrepairs1.Text = ".";
            // 
            // CostOfRapairpersons1
            // 
            this.CostOfRapairpersons1.AutoSize = true;
            this.CostOfRapairpersons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfRapairpersons1.Location = new System.Drawing.Point(305, 513);
            this.CostOfRapairpersons1.Name = "CostOfRapairpersons1";
            this.CostOfRapairpersons1.Size = new System.Drawing.Size(15, 22);
            this.CostOfRapairpersons1.TabIndex = 12;
            this.CostOfRapairpersons1.Text = ".";
            this.CostOfRapairpersons1.Click += new System.EventHandler(this.label11_Click);
            // 
            // TotalCost1
            // 
            this.TotalCost1.AutoSize = true;
            this.TotalCost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost1.Location = new System.Drawing.Point(305, 559);
            this.TotalCost1.Name = "TotalCost1";
            this.TotalCost1.Size = new System.Drawing.Size(15, 22);
            this.TotalCost1.TabIndex = 13;
            this.TotalCost1.Text = ".";
            this.TotalCost1.Click += new System.EventHandler(this.TotalCost1_Click);
            // 
            // ProposedSimTable
            // 
            this.ProposedSimTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProposedSimTable.Location = new System.Drawing.Point(557, 41);
            this.ProposedSimTable.Name = "ProposedSimTable";
            this.ProposedSimTable.RowHeadersWidth = 51;
            this.ProposedSimTable.Size = new System.Drawing.Size(508, 337);
            this.ProposedSimTable.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 39);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proposed Policy";
            // 
            // TotalCost2
            // 
            this.TotalCost2.AutoSize = true;
            this.TotalCost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost2.Location = new System.Drawing.Point(959, 559);
            this.TotalCost2.Name = "TotalCost2";
            this.TotalCost2.Size = new System.Drawing.Size(15, 22);
            this.TotalCost2.TabIndex = 25;
            this.TotalCost2.Text = ".";
            // 
            // CostOfRapairpersons2
            // 
            this.CostOfRapairpersons2.AutoSize = true;
            this.CostOfRapairpersons2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfRapairpersons2.Location = new System.Drawing.Point(959, 513);
            this.CostOfRapairpersons2.Name = "CostOfRapairpersons2";
            this.CostOfRapairpersons2.Size = new System.Drawing.Size(15, 22);
            this.CostOfRapairpersons2.TabIndex = 24;
            this.CostOfRapairpersons2.Text = ".";
            // 
            // CostOfDowntimeDuringrepairs2
            // 
            this.CostOfDowntimeDuringrepairs2.AutoSize = true;
            this.CostOfDowntimeDuringrepairs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfDowntimeDuringrepairs2.Location = new System.Drawing.Point(959, 475);
            this.CostOfDowntimeDuringrepairs2.Name = "CostOfDowntimeDuringrepairs2";
            this.CostOfDowntimeDuringrepairs2.Size = new System.Drawing.Size(15, 22);
            this.CostOfDowntimeDuringrepairs2.TabIndex = 23;
            this.CostOfDowntimeDuringrepairs2.Text = ".";
            // 
            // CostOfDelayTime2
            // 
            this.CostOfDelayTime2.AutoSize = true;
            this.CostOfDelayTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfDelayTime2.Location = new System.Drawing.Point(959, 430);
            this.CostOfDelayTime2.Name = "CostOfDelayTime2";
            this.CostOfDelayTime2.Size = new System.Drawing.Size(15, 22);
            this.CostOfDelayTime2.TabIndex = 22;
            this.CostOfDelayTime2.Text = ".";
            // 
            // CostOfBearings2
            // 
            this.CostOfBearings2.AutoSize = true;
            this.CostOfBearings2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostOfBearings2.Location = new System.Drawing.Point(959, 382);
            this.CostOfBearings2.Name = "CostOfBearings2";
            this.CostOfBearings2.Size = new System.Drawing.Size(15, 22);
            this.CostOfBearings2.TabIndex = 21;
            this.CostOfBearings2.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(640, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Total Cost :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(641, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 22);
            this.label14.TabIndex = 19;
            this.label14.Text = "Cost Of Repairpersons :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(641, 475);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(283, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "Cost Of Downtime During repairs :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(640, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 22);
            this.label16.TabIndex = 17;
            this.label16.Text = "Cost Of Delay Time :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(641, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 22);
            this.label17.TabIndex = 16;
            this.label17.Text = "Cost Of Bearings :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1080, 598);
            this.Controls.Add(this.TotalCost2);
            this.Controls.Add(this.CostOfRapairpersons2);
            this.Controls.Add(this.CostOfDowntimeDuringrepairs2);
            this.Controls.Add(this.CostOfDelayTime2);
            this.Controls.Add(this.CostOfBearings2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ProposedSimTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalCost1);
            this.Controls.Add(this.CostOfRapairpersons1);
            this.Controls.Add(this.CostOfDowntimeDuringrepairs1);
            this.Controls.Add(this.CostOfDelayTime1);
            this.Controls.Add(this.CostOfBearings1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentSimTable);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentSimTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProposedSimTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CurrentSimTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CostOfBearings1;
        private System.Windows.Forms.Label CostOfDelayTime1;
        private System.Windows.Forms.Label CostOfDowntimeDuringrepairs1;
        private System.Windows.Forms.Label CostOfRapairpersons1;
        private System.Windows.Forms.Label TotalCost1;
        private System.Windows.Forms.DataGridView ProposedSimTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalCost2;
        private System.Windows.Forms.Label CostOfRapairpersons2;
        private System.Windows.Forms.Label CostOfDowntimeDuringrepairs2;
        private System.Windows.Forms.Label CostOfDelayTime2;
        private System.Windows.Forms.Label CostOfBearings2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}