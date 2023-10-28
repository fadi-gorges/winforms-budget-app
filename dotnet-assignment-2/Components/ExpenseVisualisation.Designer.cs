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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            expenseTbl = new DataGridView();
            panel1 = new Panel();
            filterMonthPck = new DateTimePicker();
            Category = new DataGridViewTextBoxColumn();
            Nominal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)expenseTbl).BeginInit();
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
            expenseTbl.Columns.AddRange(new DataGridViewColumn[] { Category, Nominal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            expenseTbl.DefaultCellStyle = dataGridViewCellStyle2;
            expenseTbl.Location = new Point(33, 906);
            expenseTbl.Name = "expenseTbl";
            expenseTbl.RowHeadersWidth = 82;
            expenseTbl.RowTemplate.Height = 41;
            expenseTbl.Size = new Size(1439, 425);
            expenseTbl.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(33, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(1439, 790);
            panel1.TabIndex = 2;
            // 
            // filterMonthPck
            // 
            filterMonthPck.CalendarFont = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            filterMonthPck.CustomFormat = "MMM-yyyy";
            filterMonthPck.Format = DateTimePickerFormat.Custom;
            filterMonthPck.Location = new Point(638, 27);
            filterMonthPck.Name = "filterMonthPck";
            filterMonthPck.Size = new Size(252, 39);
            filterMonthPck.TabIndex = 5;
            filterMonthPck.ValueChanged += FilterMonthPck_ValueChanged;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 10;
            Category.Name = "Category";
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1510, 1354);
            Controls.Add(filterMonthPck);
            Controls.Add(expenseTbl);
            Controls.Add(panel1);
            Name = "ExpenseVisualisation";
            Text = "ExpenseVisualisation";
            ((System.ComponentModel.ISupportInitialize)expenseTbl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView expenseTbl;
        private Panel panel1;
        private DateTimePicker filterMonthPck;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Nominal;
    }
}