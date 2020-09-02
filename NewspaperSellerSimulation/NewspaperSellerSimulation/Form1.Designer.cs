namespace NewspaperSellerSimulation
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
            this.TotalLostProfitfromExcessDemand = new System.Windows.Forms.Label();
            this.TotalCostofNewspapers = new System.Windows.Forms.Label();
            this.TotalSalesRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SimTable = new System.Windows.Forms.DataGridView();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofnewsday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randamdemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daliycost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenuefromsales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostprofitfromexcessdemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvagefromsalesofscrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyprofit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numberofdayshavingunsoldpapers = new System.Windows.Forms.Label();
            this.Numberofdayshavingexcessdemand = new System.Windows.Forms.Label();
            this.NetProfit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalSalvagefromsaleofScrappapers = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalLostProfitfromExcessDemand
            // 
            this.TotalLostProfitfromExcessDemand.AutoSize = true;
            this.TotalLostProfitfromExcessDemand.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLostProfitfromExcessDemand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.TotalLostProfitfromExcessDemand.Location = new System.Drawing.Point(1318, 507);
            this.TotalLostProfitfromExcessDemand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLostProfitfromExcessDemand.Name = "TotalLostProfitfromExcessDemand";
            this.TotalLostProfitfromExcessDemand.Size = new System.Drawing.Size(26, 40);
            this.TotalLostProfitfromExcessDemand.TabIndex = 23;
            this.TotalLostProfitfromExcessDemand.Text = ".";
            // 
            // TotalCostofNewspapers
            // 
            this.TotalCostofNewspapers.AutoSize = true;
            this.TotalCostofNewspapers.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostofNewspapers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.TotalCostofNewspapers.Location = new System.Drawing.Point(472, 564);
            this.TotalCostofNewspapers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCostofNewspapers.Name = "TotalCostofNewspapers";
            this.TotalCostofNewspapers.Size = new System.Drawing.Size(26, 40);
            this.TotalCostofNewspapers.TabIndex = 22;
            this.TotalCostofNewspapers.Text = ".";
            // 
            // TotalSalesRevenue
            // 
            this.TotalSalesRevenue.AutoSize = true;
            this.TotalSalesRevenue.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.TotalSalesRevenue.Location = new System.Drawing.Point(472, 507);
            this.TotalSalesRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalSalesRevenue.Name = "TotalSalesRevenue";
            this.TotalSalesRevenue.Size = new System.Drawing.Size(26, 40);
            this.TotalSalesRevenue.TabIndex = 21;
            this.TotalSalesRevenue.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(609, 507);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(604, 40);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total Lost Profit from Excess Demand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(13, 564);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 40);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total Cost of Newspapers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 507);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Sales Revenue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "News Paper Seller Simulation";
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Minimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Minimize.Location = new System.Drawing.Point(1338, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(53, 49);
            this.Minimize.TabIndex = 16;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Close.Location = new System.Drawing.Point(1399, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(53, 49);
            this.Close.TabIndex = 15;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SimTable
            // 
            this.SimTable.AllowUserToAddRows = false;
            this.SimTable.AllowUserToDeleteRows = false;
            this.SimTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SimTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day,
            this.randomtype,
            this.typeofnewsday,
            this.randamdemand,
            this.demand,
            this.daliycost,
            this.revenuefromsales,
            this.lostprofitfromexcessdemand,
            this.salvagefromsalesofscrap,
            this.dailyprofit});
            this.SimTable.Location = new System.Drawing.Point(20, 84);
            this.SimTable.Margin = new System.Windows.Forms.Padding(4);
            this.SimTable.Name = "SimTable";
            this.SimTable.ReadOnly = true;
            this.SimTable.Size = new System.Drawing.Size(1405, 391);
            this.SimTable.TabIndex = 14;
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            this.day.ReadOnly = true;
            // 
            // randomtype
            // 
            this.randomtype.HeaderText = "Random Digits For Type Of Newsday";
            this.randomtype.Name = "randomtype";
            this.randomtype.ReadOnly = true;
            // 
            // typeofnewsday
            // 
            this.typeofnewsday.HeaderText = "Type of Newsday";
            this.typeofnewsday.Name = "typeofnewsday";
            this.typeofnewsday.ReadOnly = true;
            // 
            // randamdemand
            // 
            this.randamdemand.HeaderText = "Random Digits for Demand";
            this.randamdemand.Name = "randamdemand";
            this.randamdemand.ReadOnly = true;
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            this.demand.ReadOnly = true;
            // 
            // daliycost
            // 
            this.daliycost.HeaderText = "Daily Cost";
            this.daliycost.Name = "daliycost";
            this.daliycost.ReadOnly = true;
            // 
            // revenuefromsales
            // 
            this.revenuefromsales.HeaderText = "Revenue from Sales";
            this.revenuefromsales.Name = "revenuefromsales";
            this.revenuefromsales.ReadOnly = true;
            // 
            // lostprofitfromexcessdemand
            // 
            this.lostprofitfromexcessdemand.HeaderText = "Lost Profit From Excess Demand";
            this.lostprofitfromexcessdemand.Name = "lostprofitfromexcessdemand";
            this.lostprofitfromexcessdemand.ReadOnly = true;
            // 
            // salvagefromsalesofscrap
            // 
            this.salvagefromsalesofscrap.HeaderText = "Salvage from Sales of Scrap";
            this.salvagefromsalesofscrap.Name = "salvagefromsalesofscrap";
            this.salvagefromsalesofscrap.ReadOnly = true;
            // 
            // dailyprofit
            // 
            this.dailyprofit.HeaderText = "Daily Profit";
            this.dailyprofit.Name = "dailyprofit";
            this.dailyprofit.ReadOnly = true;
            // 
            // Numberofdayshavingunsoldpapers
            // 
            this.Numberofdayshavingunsoldpapers.AutoSize = true;
            this.Numberofdayshavingunsoldpapers.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numberofdayshavingunsoldpapers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Numberofdayshavingunsoldpapers.Location = new System.Drawing.Point(1318, 657);
            this.Numberofdayshavingunsoldpapers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Numberofdayshavingunsoldpapers.Name = "Numberofdayshavingunsoldpapers";
            this.Numberofdayshavingunsoldpapers.Size = new System.Drawing.Size(26, 40);
            this.Numberofdayshavingunsoldpapers.TabIndex = 31;
            this.Numberofdayshavingunsoldpapers.Text = ".";
            // 
            // Numberofdayshavingexcessdemand
            // 
            this.Numberofdayshavingexcessdemand.AutoSize = true;
            this.Numberofdayshavingexcessdemand.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numberofdayshavingexcessdemand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Numberofdayshavingexcessdemand.Location = new System.Drawing.Point(1318, 607);
            this.Numberofdayshavingexcessdemand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Numberofdayshavingexcessdemand.Name = "Numberofdayshavingexcessdemand";
            this.Numberofdayshavingexcessdemand.Size = new System.Drawing.Size(26, 40);
            this.Numberofdayshavingexcessdemand.TabIndex = 30;
            this.Numberofdayshavingexcessdemand.Text = ".";
            // 
            // NetProfit
            // 
            this.NetProfit.AutoSize = true;
            this.NetProfit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.NetProfit.Location = new System.Drawing.Point(472, 612);
            this.NetProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Size = new System.Drawing.Size(26, 40);
            this.NetProfit.TabIndex = 29;
            this.NetProfit.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(612, 667);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(638, 40);
            this.label8.TabIndex = 28;
            this.label8.Text = "Number of days having unsold papers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(609, 612);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(668, 40);
            this.label9.TabIndex = 27;
            this.label9.Text = "Number of days having excess demand";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(13, 612);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 40);
            this.label10.TabIndex = 26;
            this.label10.Text = "Net Profit";
            // 
            // TotalSalvagefromsaleofScrappapers
            // 
            this.TotalSalvagefromsaleofScrappapers.AutoSize = true;
            this.TotalSalvagefromsaleofScrappapers.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalvagefromsaleofScrappapers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.TotalSalvagefromsaleofScrappapers.Location = new System.Drawing.Point(1318, 559);
            this.TotalSalvagefromsaleofScrappapers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalSalvagefromsaleofScrappapers.Name = "TotalSalvagefromsaleofScrappapers";
            this.TotalSalvagefromsaleofScrappapers.Size = new System.Drawing.Size(26, 40);
            this.TotalSalvagefromsaleofScrappapers.TabIndex = 33;
            this.TotalSalvagefromsaleofScrappapers.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(612, 559);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(659, 40);
            this.label12.TabIndex = 32;
            this.label12.Text = "Total Salvage from sale of Scrap papers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1445, 739);
            this.ControlBox = false;
            this.Controls.Add(this.TotalSalvagefromsaleofScrappapers);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Numberofdayshavingunsoldpapers);
            this.Controls.Add(this.Numberofdayshavingexcessdemand);
            this.Controls.Add(this.NetProfit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalLostProfitfromExcessDemand);
            this.Controls.Add(this.TotalCostofNewspapers);
            this.Controls.Add(this.TotalSalesRevenue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.SimTable);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalLostProfitfromExcessDemand;
        private System.Windows.Forms.Label TotalCostofNewspapers;
        private System.Windows.Forms.Label TotalSalesRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridView SimTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofnewsday;
        private System.Windows.Forms.DataGridViewTextBoxColumn randamdemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn daliycost;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenuefromsales;
        private System.Windows.Forms.DataGridViewTextBoxColumn lostprofitfromexcessdemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn salvagefromsalesofscrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyprofit;
        private System.Windows.Forms.Label Numberofdayshavingunsoldpapers;
        private System.Windows.Forms.Label Numberofdayshavingexcessdemand;
        private System.Windows.Forms.Label NetProfit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TotalSalvagefromsaleofScrappapers;
        private System.Windows.Forms.Label label12;
    }
}