using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace _31927_Assignment_2
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
            addRecordBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            expenseVisBtn = new Button();
            netCashFlowBtn = new Button();
            dataGridView1 = new DataGridView();
            transactionType = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            nominal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "MMM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1165, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 39);
            dateTimePicker1.TabIndex = 3;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transactionType, category, date, nominal });
            dataGridView1.Location = new Point(26, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(2519, 847);
            dataGridView1.TabIndex = 6;
            // 
            // transactionType
            // 
            transactionType.HeaderText = "Transaction Type";
            transactionType.MinimumWidth = 10;
            transactionType.Name = "transactionType";
            transactionType.ReadOnly = true;
            transactionType.Width = 200;
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.MinimumWidth = 10;
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 200;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 10;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 200;
            // 
            // nominal
            // 
            nominal.HeaderText = "Nominal";
            nominal.MinimumWidth = 10;
            nominal.Name = "nominal";
            nominal.ReadOnly = true;
            nominal.Width = 200;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(2565, 1158);
            Controls.Add(dataGridView1);
            Controls.Add(netCashFlowBtn);
            Controls.Add(expenseVisBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(addRecordBtn);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Homepage";
            Text = "Dashboard";
            FormClosing += Homepage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addRecordBtn;
        private DateTimePicker dateTimePicker1;
        private Button expenseVisBtn;
        private Button netCashFlowBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn transactionType;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn nominal;
    }
}