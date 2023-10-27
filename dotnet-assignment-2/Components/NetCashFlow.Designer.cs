namespace dotnet_assignment_2.Components
{
    partial class NetCashFlow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label1 = new Label();
            filterMonthPck = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            incomeTxt = new TextBox();
            expenseTxt = new TextBox();
            netTxt = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(chart1);
            panel1.Location = new Point(19, 55);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 346);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(19, 484);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 45);
            label1.TabIndex = 1;
            label1.Text = "Net Cash Flow:";
            // 
            // filterMonthPck
            // 
            filterMonthPck.CalendarFont = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            filterMonthPck.CustomFormat = "MMM-yyyy";
            filterMonthPck.Format = DateTimePickerFormat.Custom;
            filterMonthPck.Location = new Point(351, 20);
            filterMonthPck.Margin = new Padding(2, 1, 2, 1);
            filterMonthPck.Name = "filterMonthPck";
            filterMonthPck.Size = new Size(138, 23);
            filterMonthPck.TabIndex = 4;
            filterMonthPck.ValueChanged += FilterMonthPck_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(19, 443);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 5;
            label3.Text = "Expense:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(19, 410);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 37);
            label4.TabIndex = 6;
            label4.Text = "Income:";
            // 
            // incomeTxt
            // 
            incomeTxt.BackColor = Color.FromArgb(39, 39, 39);
            incomeTxt.BorderStyle = BorderStyle.None;
            incomeTxt.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            incomeTxt.ForeColor = Color.MediumSeaGreen;
            incomeTxt.Location = new Point(363, 410);
            incomeTxt.Margin = new Padding(2, 1, 2, 1);
            incomeTxt.Name = "incomeTxt";
            incomeTxt.Size = new Size(431, 36);
            incomeTxt.TabIndex = 9;
            incomeTxt.Text = "0";
            incomeTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // expenseTxt
            // 
            expenseTxt.BackColor = Color.FromArgb(39, 39, 39);
            expenseTxt.BorderStyle = BorderStyle.None;
            expenseTxt.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            expenseTxt.ForeColor = Color.IndianRed;
            expenseTxt.Location = new Point(363, 443);
            expenseTxt.Margin = new Padding(2, 1, 2, 1);
            expenseTxt.Name = "expenseTxt";
            expenseTxt.Size = new Size(431, 36);
            expenseTxt.TabIndex = 10;
            expenseTxt.Text = "0";
            expenseTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // netTxt
            // 
            netTxt.BackColor = Color.FromArgb(39, 39, 39);
            netTxt.BorderStyle = BorderStyle.None;
            netTxt.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            netTxt.ForeColor = SystemColors.ControlLight;
            netTxt.Location = new Point(363, 484);
            netTxt.Margin = new Padding(2, 1, 2, 1);
            netTxt.Name = "netTxt";
            netTxt.Size = new Size(431, 44);
            netTxt.TabIndex = 11;
            netTxt.Text = "0";
            netTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Expenses";
            chart1.Series.Add(series1);
            chart1.Size = new Size(775, 346);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // NetCashFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(813, 535);
            Controls.Add(netTxt);
            Controls.Add(expenseTxt);
            Controls.Add(incomeTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(filterMonthPck);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "NetCashFlow";
            Text = "NetCashFlow";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker filterMonthPck;
        private Label label3;
        private Label label4;
        private TextBox incomeTxt;
        private TextBox expenseTxt;
        private TextBox netTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}