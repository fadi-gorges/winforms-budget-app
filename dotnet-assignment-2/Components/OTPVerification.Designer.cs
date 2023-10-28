namespace dotnet_assignment_2.Components
{
    partial class OTPVerification
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
            label5 = new Label();
            resendOTPBtn = new Button();
            SignUpBtn = new Button();
            panel1 = new Panel();
            codeTxt4 = new TextBox();
            codeTxt3 = new TextBox();
            codeTxt2 = new TextBox();
            codeTxt1 = new TextBox();
            SignUpLink = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(48, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(679, 86);
            label5.TabIndex = 17;
            label5.Text = "EMAIL VERIFICATION";
            // 
            // resendOTPBtn
            // 
            resendOTPBtn.BackColor = Color.FromArgb(39, 39, 39);
            resendOTPBtn.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 39);
            resendOTPBtn.ForeColor = SystemColors.ButtonFace;
            resendOTPBtn.Location = new Point(225, 464);
            resendOTPBtn.Name = "resendOTPBtn";
            resendOTPBtn.Size = new Size(329, 46);
            resendOTPBtn.TabIndex = 20;
            resendOTPBtn.Text = "Resend the code!";
            resendOTPBtn.UseVisualStyleBackColor = false;
            resendOTPBtn.Click += ResendOTPBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpBtn.Location = new Point(190, 335);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(399, 102);
            SignUpBtn.TabIndex = 19;
            SignUpBtn.Text = "SIGN UP";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(codeTxt4);
            panel1.Controls.Add(codeTxt3);
            panel1.Controls.Add(codeTxt2);
            panel1.Controls.Add(codeTxt1);
            panel1.Location = new Point(13, 141);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 168);
            panel1.TabIndex = 18;
            // 
            // codeTxt4
            // 
            codeTxt4.BackColor = Color.WhiteSmoke;
            codeTxt4.BorderStyle = BorderStyle.None;
            codeTxt4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            codeTxt4.Location = new Point(547, 48);
            codeTxt4.Margin = new Padding(4, 2, 4, 2);
            codeTxt4.Name = "codeTxt4";
            codeTxt4.Size = new Size(133, 72);
            codeTxt4.TabIndex = 17;
            codeTxt4.TextAlign = HorizontalAlignment.Center;
            codeTxt4.KeyPress += CodeTxt4_KeyPress;
            // 
            // codeTxt3
            // 
            codeTxt3.BackColor = Color.WhiteSmoke;
            codeTxt3.BorderStyle = BorderStyle.None;
            codeTxt3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            codeTxt3.Location = new Point(379, 48);
            codeTxt3.Margin = new Padding(4, 2, 4, 2);
            codeTxt3.Name = "codeTxt3";
            codeTxt3.Size = new Size(133, 72);
            codeTxt3.TabIndex = 16;
            codeTxt3.TextAlign = HorizontalAlignment.Center;
            codeTxt3.KeyPress += CodeTxt3_KeyPress;
            // 
            // codeTxt2
            // 
            codeTxt2.BackColor = Color.WhiteSmoke;
            codeTxt2.BorderStyle = BorderStyle.None;
            codeTxt2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            codeTxt2.Location = new Point(212, 48);
            codeTxt2.Margin = new Padding(4, 2, 4, 2);
            codeTxt2.Name = "codeTxt2";
            codeTxt2.Size = new Size(133, 72);
            codeTxt2.TabIndex = 15;
            codeTxt2.TextAlign = HorizontalAlignment.Center;
            codeTxt2.KeyPress += CodeTxt2_KeyPress;
            // 
            // codeTxt1
            // 
            codeTxt1.BackColor = Color.WhiteSmoke;
            codeTxt1.BorderStyle = BorderStyle.None;
            codeTxt1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            codeTxt1.Location = new Point(44, 48);
            codeTxt1.Margin = new Padding(4, 2, 4, 2);
            codeTxt1.Name = "codeTxt1";
            codeTxt1.Size = new Size(133, 72);
            codeTxt1.TabIndex = 14;
            codeTxt1.TextAlign = HorizontalAlignment.Center;
            codeTxt1.KeyPress += CodeTxt1_KeyPress;
            // 
            // SignUpLink
            // 
            SignUpLink.BackColor = Color.FromArgb(39, 39, 39);
            SignUpLink.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 39);
            SignUpLink.ForeColor = SystemColors.ButtonFace;
            SignUpLink.Location = new Point(225, 529);
            SignUpLink.Name = "SignUpLink";
            SignUpLink.Size = new Size(329, 46);
            SignUpLink.TabIndex = 21;
            SignUpLink.Text = "Don't have an account?";
            SignUpLink.UseVisualStyleBackColor = false;
            SignUpLink.Click += SignUpLink_Click;
            // 
            // OTPVerification
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(776, 600);
            Controls.Add(SignUpLink);
            Controls.Add(resendOTPBtn);
            Controls.Add(SignUpBtn);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "OTPVerification";
            Text = "OTPVerification";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button resendOTPBtn;
        private Button SignUpBtn;
        private Panel panel1;
        private TextBox codeTxt1;
        private TextBox codeTxt4;
        private TextBox codeTxt3;
        private TextBox codeTxt2;
        private Button SignUpLink;
    }
}