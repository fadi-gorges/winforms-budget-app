namespace dotnet_assignment_2.Components
{
    partial class TransactionDetails
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
            cancelBtn = new Button();
            saveBtn = new Button();
            panel1 = new Panel();
            transactionTypeCmb = new ComboBox();
            categoryCmb = new ComboBox();
            datePckr = new DateTimePicker();
            notesTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            nominalTxt = new TextBox();
            label1 = new Label();
            deleteBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(40, 727);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(681, 102);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.MediumAquamarine;
            saveBtn.BackgroundImageLayout = ImageLayout.None;
            saveBtn.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(40, 852);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(1362, 102);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += SaveBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(transactionTypeCmb);
            panel1.Controls.Add(categoryCmb);
            panel1.Controls.Add(datePckr);
            panel1.Controls.Add(notesTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(nominalTxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 36);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1362, 658);
            panel1.TabIndex = 3;
            // 
            // transactionTypeCmb
            // 
            transactionTypeCmb.BackColor = Color.DimGray;
            transactionTypeCmb.DisplayMember = "(none)";
            transactionTypeCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            transactionTypeCmb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            transactionTypeCmb.FormattingEnabled = true;
            transactionTypeCmb.Items.AddRange(new object[] { "Income", "Expense" });
            transactionTypeCmb.Location = new Point(615, 154);
            transactionTypeCmb.Name = "transactionTypeCmb";
            transactionTypeCmb.Size = new Size(721, 73);
            transactionTypeCmb.TabIndex = 13;
            transactionTypeCmb.TextChanged += TransactionTypeCmb_TextChanged;
            // 
            // categoryCmb
            // 
            categoryCmb.BackColor = Color.DimGray;
            categoryCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryCmb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            categoryCmb.FormattingEnabled = true;
            categoryCmb.Items.AddRange(new object[] { "Eating Out", "Groceries", "Shopping", "House", "Transportation", "Entertainment", "Health", "Financial Expenses", "Utilities", "Others" });
            categoryCmb.Location = new Point(615, 287);
            categoryCmb.Name = "categoryCmb";
            categoryCmb.Size = new Size(721, 73);
            categoryCmb.TabIndex = 12;
            // 
            // datePckr
            // 
            datePckr.CalendarForeColor = Color.DimGray;
            datePckr.CalendarMonthBackground = Color.DimGray;
            datePckr.CalendarTitleForeColor = Color.DimGray;
            datePckr.CustomFormat = "ddd MMM dd, yyyy HH:mm";
            datePckr.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            datePckr.Format = DateTimePickerFormat.Custom;
            datePckr.Location = new Point(615, 422);
            datePckr.Name = "datePckr";
            datePckr.Size = new Size(721, 71);
            datePckr.TabIndex = 11;
            // 
            // notesTxt
            // 
            notesTxt.BackColor = Color.WhiteSmoke;
            notesTxt.BorderStyle = BorderStyle.None;
            notesTxt.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            notesTxt.Location = new Point(615, 548);
            notesTxt.Margin = new Padding(4, 2, 4, 2);
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(721, 72);
            notesTxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(26, 548);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 72);
            label4.TabIndex = 9;
            label4.Text = "Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(26, 421);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 72);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(26, 284);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 72);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(26, 155);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(458, 72);
            label6.TabIndex = 6;
            label6.Text = "Transaction Type";
            // 
            // nominalTxt
            // 
            nominalTxt.BackColor = Color.WhiteSmoke;
            nominalTxt.BorderStyle = BorderStyle.None;
            nominalTxt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nominalTxt.Location = new Point(615, 38);
            nominalTxt.Margin = new Padding(4, 2, 4, 2);
            nominalTxt.Name = "nominalTxt";
            nominalTxt.Size = new Size(721, 64);
            nominalTxt.TabIndex = 5;
            nominalTxt.Text = "0";
            nominalTxt.KeyPress += NominalTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(26, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 72);
            label1.TabIndex = 0;
            label1.Text = "Nominal";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Firebrick;
            deleteBtn.BackgroundImageLayout = ImageLayout.None;
            deleteBtn.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = SystemColors.ButtonFace;
            deleteBtn.Location = new Point(737, 727);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(665, 102);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += DeleteBtn_Click;
            // 
            // TransactionDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1449, 999);
            Controls.Add(deleteBtn);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(panel1);
            Name = "TransactionDetails";
            Text = "TransactionDetails";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private Panel panel1;
        private ComboBox transactionTypeCmb;
        private ComboBox categoryCmb;
        private DateTimePicker datePckr;
        private TextBox notesTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox nominalTxt;
        private Label label1;
        private Button deleteBtn;
    }
}