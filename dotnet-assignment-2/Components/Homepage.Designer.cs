using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace dotnet_assignment_2.Components
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            addRecordBtn = new Button();
            filterMonthPck = new DateTimePicker();
            expenseVisBtn = new Button();
            netCashFlowBtn = new Button();
            TransactionTbl = new DataGridView();
            TransactionType = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Nominal = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TransactionTbl).BeginInit();
            SuspendLayout();
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = SystemColors.ControlLightLight;
            addRecordBtn.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            addRecordBtn.Location = new Point(2253, 44);
            addRecordBtn.Margin = new Padding(4, 2, 4, 2);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(292, 83);
            addRecordBtn.TabIndex = 1;
            addRecordBtn.Text = "+ Add Record";
            addRecordBtn.UseVisualStyleBackColor = false;
            addRecordBtn.Click += AddRecordBtnAction;
            // 
            // filterMonthPck
            // 
            filterMonthPck.CalendarFont = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            filterMonthPck.CustomFormat = "MMM-yyyy";
            filterMonthPck.Format = DateTimePickerFormat.Custom;
            filterMonthPck.Location = new Point(1165, 180);
            filterMonthPck.Name = "filterMonthPck";
            filterMonthPck.Size = new Size(252, 39);
            filterMonthPck.TabIndex = 3;
            filterMonthPck.ValueChanged += FilterMonthPck_ValueChanged;
            // 
            // expenseVisBtn
            // 
            expenseVisBtn.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            expenseVisBtn.Location = new Point(26, 44);
            expenseVisBtn.Name = "expenseVisBtn";
            expenseVisBtn.Size = new Size(682, 83);
            expenseVisBtn.TabIndex = 4;
            expenseVisBtn.Text = "Expenses Visualisation";
            expenseVisBtn.UseVisualStyleBackColor = true;
            expenseVisBtn.Click += ExpenseVisBtn_Click;
            // 
            // netCashFlowBtn
            // 
            netCashFlowBtn.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            netCashFlowBtn.Location = new Point(763, 44);
            netCashFlowBtn.Name = "netCashFlowBtn";
            netCashFlowBtn.Size = new Size(458, 83);
            netCashFlowBtn.TabIndex = 5;
            netCashFlowBtn.Text = "Net Cash Flow";
            netCashFlowBtn.UseVisualStyleBackColor = true;
            netCashFlowBtn.Click += NetCashFlowBtn_Click;
            // 
            // TransactionTbl
            // 
            TransactionTbl.AllowUserToAddRows = false;
            TransactionTbl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TransactionTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TransactionTbl.ColumnHeadersHeight = 100;
            TransactionTbl.Columns.AddRange(new DataGridViewColumn[] { TransactionType, Category, Date, Nominal, Notes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TransactionTbl.DefaultCellStyle = dataGridViewCellStyle2;
            TransactionTbl.Location = new Point(26, 256);
            TransactionTbl.Name = "TransactionTbl";
            TransactionTbl.ReadOnly = true;
            TransactionTbl.RowHeadersWidth = 82;
            TransactionTbl.RowTemplate.Height = 41;
            TransactionTbl.Size = new Size(2519, 847);
            TransactionTbl.TabIndex = 6;
            TransactionTbl.RowHeaderMouseClick += TransactionTbl_RowHeaderMouseClick;
            // 
            // TransactionType
            // 
            TransactionType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TransactionType.DataPropertyName = "TransactionType";
            TransactionType.HeaderText = "Transaction Type";
            TransactionType.MinimumWidth = 250;
            TransactionType.Name = "TransactionType";
            TransactionType.ReadOnly = true;
            TransactionType.Width = 410;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 350;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 350;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 300;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 300;
            // 
            // Nominal
            // 
            Nominal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Nominal.DataPropertyName = "Nominal";
            Nominal.HeaderText = "Nominal";
            Nominal.MinimumWidth = 400;
            Nominal.Name = "Nominal";
            Nominal.ReadOnly = true;
            Nominal.Width = 400;
            // 
            // Notes
            // 
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.DataPropertyName = "Notes";
            Notes.HeaderText = "Notes";
            Notes.MinimumWidth = 10;
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(2565, 1158);
            Controls.Add(TransactionTbl);
            Controls.Add(netCashFlowBtn);
            Controls.Add(expenseVisBtn);
            Controls.Add(filterMonthPck);
            Controls.Add(addRecordBtn);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Homepage";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)TransactionTbl).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addRecordBtn;
        private DateTimePicker dateTimePicker1;
        private Button expenseVisBtn;
        private Button netCashFlowBtn;
        private DataGridView TransactionTbl;
        private DateTimePicker filterMonthPck;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Nominal;
        private DataGridViewTextBoxColumn Notes;
    }
}