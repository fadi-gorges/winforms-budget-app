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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            filterMonthPck = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 852);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1439, 510);
            dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(33, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(1439, 739);
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
            // 
            // ExpenseVisualisation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1510, 1388);
            Controls.Add(filterMonthPck);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ExpenseVisualisation";
            Text = "ExpenseVisualisation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private DateTimePicker filterMonthPck;
    }
}