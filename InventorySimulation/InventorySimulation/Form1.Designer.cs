namespace InventorySimulation
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
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SimTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daycycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginningInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomLeadDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysUntilOrderArrives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageQuantityAverage = new System.Windows.Forms.Label();
            this.EndingInventoryAverage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Minimize.Location = new System.Drawing.Point(1013, 11);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 40);
            this.Minimize.TabIndex = 6;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.Close.Location = new System.Drawing.Point(1057, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.TabIndex = 5;
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
            this.cycle,
            this.daycycle,
            this.beginningInventory,
            this.randomDemand,
            this.Demand,
            this.endingInventory,
            this.shortage,
            this.order,
            this.randomLeadDays,
            this.leadDays,
            this.daysUntilOrderArrives});
            this.SimTable.Location = new System.Drawing.Point(2, 89);
            this.SimTable.Name = "SimTable";
            this.SimTable.ReadOnly = true;
            this.SimTable.Size = new System.Drawing.Size(1095, 378);
            this.SimTable.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "A Refrigerator Inventory Problem";
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            this.day.ReadOnly = true;
            this.day.Width = 40;
            // 
            // cycle
            // 
            this.cycle.HeaderText = "Cycle";
            this.cycle.Name = "cycle";
            this.cycle.ReadOnly = true;
            this.cycle.Width = 40;
            // 
            // daycycle
            // 
            this.daycycle.HeaderText = "Day within cycle";
            this.daycycle.Name = "daycycle";
            this.daycycle.ReadOnly = true;
            this.daycycle.Width = 80;
            // 
            // beginningInventory
            // 
            this.beginningInventory.HeaderText = "Beginning Inventory";
            this.beginningInventory.Name = "beginningInventory";
            this.beginningInventory.ReadOnly = true;
            // 
            // randomDemand
            // 
            this.randomDemand.HeaderText = "Random Demand";
            this.randomDemand.Name = "randomDemand";
            this.randomDemand.ReadOnly = true;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            // 
            // endingInventory
            // 
            this.endingInventory.HeaderText = "Ending Inventory";
            this.endingInventory.Name = "endingInventory";
            this.endingInventory.ReadOnly = true;
            // 
            // shortage
            // 
            this.shortage.HeaderText = "Shortage Quantity";
            this.shortage.Name = "shortage";
            this.shortage.ReadOnly = true;
            // 
            // order
            // 
            this.order.HeaderText = "Order Quantity";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // randomLeadDays
            // 
            this.randomLeadDays.HeaderText = "Random Lead Days";
            this.randomLeadDays.Name = "randomLeadDays";
            this.randomLeadDays.ReadOnly = true;
            // 
            // leadDays
            // 
            this.leadDays.HeaderText = "Lead Days";
            this.leadDays.Name = "leadDays";
            this.leadDays.ReadOnly = true;
            // 
            // daysUntilOrderArrives
            // 
            this.daysUntilOrderArrives.HeaderText = "Days Until Order Arrives";
            this.daysUntilOrderArrives.Name = "daysUntilOrderArrives";
            this.daysUntilOrderArrives.ReadOnly = true;
            // 
            // ShortageQuantityAverage
            // 
            this.ShortageQuantityAverage.AutoSize = true;
            this.ShortageQuantityAverage.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortageQuantityAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.ShortageQuantityAverage.Location = new System.Drawing.Point(385, 545);
            this.ShortageQuantityAverage.Name = "ShortageQuantityAverage";
            this.ShortageQuantityAverage.Size = new System.Drawing.Size(22, 33);
            this.ShortageQuantityAverage.TabIndex = 14;
            this.ShortageQuantityAverage.Text = ".";
            // 
            // EndingInventoryAverage
            // 
            this.EndingInventoryAverage.AutoSize = true;
            this.EndingInventoryAverage.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingInventoryAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.EndingInventoryAverage.Location = new System.Drawing.Point(385, 498);
            this.EndingInventoryAverage.Name = "EndingInventoryAverage";
            this.EndingInventoryAverage.Size = new System.Drawing.Size(22, 33);
            this.EndingInventoryAverage.TabIndex = 13;
            this.EndingInventoryAverage.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Shortage Quantity Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ending Inventory Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.ShortageQuantityAverage);
            this.Controls.Add(this.EndingInventoryAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimTable);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SimTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridView SimTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn daycycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginningInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortage;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomLeadDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysUntilOrderArrives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShortageQuantityAverage;
        private System.Windows.Forms.Label EndingInventoryAverage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}