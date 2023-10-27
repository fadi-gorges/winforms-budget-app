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
            panel1 = new Panel();
            label1 = new Label();
            filterMonthPck = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            incomeTxt = new TextBox();
            expenseTxt = new TextBox();
            netTxt = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(35, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(1439, 739);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(35, 1032);
            label1.Name = "label1";
            label1.Size = new Size(505, 86);
            label1.TabIndex = 1;
            label1.Text = "Net Cash Flow:";
            // 
            // filterMonthPck
            // 
            filterMonthPck.CalendarFont = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            filterMonthPck.CustomFormat = "MMM-yyyy";
            filterMonthPck.Format = DateTimePickerFormat.Custom;
            filterMonthPck.Location = new Point(651, 42);
            filterMonthPck.Name = "filterMonthPck";
            filterMonthPck.Size = new Size(252, 39);
            filterMonthPck.TabIndex = 4;
            filterMonthPck.ValueChanged += FilterMonthPck_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(35, 946);
            label3.Name = "label3";
            label3.Size = new Size(247, 71);
            label3.TabIndex = 5;
            label3.Text = "Expense:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(35, 875);
            label4.Name = "label4";
            label4.Size = new Size(228, 71);
            label4.TabIndex = 6;
            label4.Text = "Income:";
            // 
            // incomeTxt
            // 
            incomeTxt.BackColor = Color.FromArgb(39, 39, 39);
            incomeTxt.BorderStyle = BorderStyle.None;
            incomeTxt.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            incomeTxt.ForeColor = Color.MediumSeaGreen;
            incomeTxt.Location = new Point(674, 875);
            incomeTxt.Name = "incomeTxt";
            incomeTxt.Size = new Size(800, 72);
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
            expenseTxt.Location = new Point(674, 945);
            expenseTxt.Name = "expenseTxt";
            expenseTxt.Size = new Size(800, 72);
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
            netTxt.Location = new Point(674, 1032);
            netTxt.Name = "netTxt";
            netTxt.Size = new Size(800, 87);
            netTxt.TabIndex = 11;
            netTxt.Text = "0";
            netTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // NetCashFlow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1509, 1141);
            Controls.Add(netTxt);
            Controls.Add(expenseTxt);
            Controls.Add(incomeTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(filterMonthPck);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "NetCashFlow";
            Text = "NetCashFlow";
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
    }
}