namespace dotnet_assignment_2.Components
{
    partial class ExpenseVisualisation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            expenseTbl = new DataGridView();
            panel1 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            filterMonthPck = new DateTimePicker();
            Cat = new DataGridViewTextBoxColumn();
            Nominal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)expenseTbl).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // expenseTbl
            // 
            expenseTbl.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            expenseTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            expenseTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expenseTbl.Location = new Point(18, 425);
            expenseTbl.Margin = new Padding(2, 1, 2, 1);
            expenseTbl.Columns.AddRange(new DataGridViewColumn[] { Cat, Nominal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            expenseTbl.DefaultCellStyle = dataGridViewCellStyle2;
            expenseTbl.Name = "expenseTbl";
            expenseTbl.RowHeadersWidth = 82;
            expenseTbl.RowTemplate.Height = 41;
            expenseTbl.Size = new Size(775, 199);
            expenseTbl.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(chart1);
            panel1.Location = new Point(18, 43);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 370);
            panel1.TabIndex = 2;
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
            chart1.Size = new Size(775, 370);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // filterMonthPck
            // 
            filterMonthPck.CalendarFont = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            filterMonthPck.CustomFormat = "MMM-yyyy";
            filterMonthPck.Format = DateTimePickerFormat.Custom;
            filterMonthPck.Location = new Point(344, 13);
            filterMonthPck.Margin = new Padding(2, 1, 2, 1);
            filterMonthPck.Name = "filterMonthPck";
            filterMonthPck.Size = new Size(138, 23);
            filterMonthPck.TabIndex = 5;
            filterMonthPck.ValueChanged += FilterMonthPck_ValueChanged;
            // 
            // Cat
            // 
            Cat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cat.DataPropertyName = "Name";
            Cat.HeaderText = "Category";
            Cat.MinimumWidth = 10;
            Cat.Name = "Category";
            // 
            // Nominal
            // 
            Nominal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nominal.DataPropertyName = "Nominal";
            Nominal.HeaderText = "Nominal";
            Nominal.MinimumWidth = 10;
            Nominal.Name = "Nominal";
            // 
            // ExpenseVisualisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(813, 635);
            Controls.Add(filterMonthPck);
            Controls.Add(expenseTbl);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ExpenseVisualisation";
            Text = "ExpenseVisualisation";
            ((System.ComponentModel.ISupportInitialize)expenseTbl).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView expenseTbl;
        private Panel panel1;
        private DateTimePicker filterMonthPck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn Cat;
        private DataGridViewTextBoxColumn Nominal;
    }
}