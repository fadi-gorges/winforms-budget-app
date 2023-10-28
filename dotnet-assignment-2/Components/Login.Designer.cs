namespace dotnet_assignment_2.Components
{
    partial class Login
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
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            passowrdLbl = new Label();
            label1 = new Label();
            LoginBtn = new Button();
            label7 = new Label();
            label5 = new Label();
            SignUpBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(usernameTxt);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(passowrdLbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 159);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 256);
            panel1.TabIndex = 2;
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = Color.WhiteSmoke;
            usernameTxt.BorderStyle = BorderStyle.None;
            usernameTxt.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTxt.Location = new Point(556, 30);
            usernameTxt.Margin = new Padding(4, 2, 4, 2);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(643, 72);
            usernameTxt.TabIndex = 14;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.WhiteSmoke;
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxt.Location = new Point(556, 155);
            passwordTxt.Margin = new Padding(4, 2, 4, 2);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(643, 72);
            passwordTxt.TabIndex = 13;
            // 
            // passowrdLbl
            // 
            passowrdLbl.AutoSize = true;
            passowrdLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            passowrdLbl.ForeColor = Color.WhiteSmoke;
            passowrdLbl.Location = new Point(26, 155);
            passowrdLbl.Margin = new Padding(4, 0, 4, 0);
            passowrdLbl.Name = "passowrdLbl";
            passowrdLbl.RightToLeft = RightToLeft.Yes;
            passowrdLbl.Size = new Size(269, 72);
            passowrdLbl.TabIndex = 6;
            passowrdLbl.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(26, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 72);
            label1.TabIndex = 0;
            label1.Text = "Username/Email";
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(292, 447);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(692, 102);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "LOG IN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(431, 91);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(429, 50);
            label7.TabIndex = 18;
            label7.Text = "TO .NET BUDGETING 101";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(474, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(349, 86);
            label5.TabIndex = 17;
            label5.Text = "WELCOME";
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.FromArgb(39, 39, 39);
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 39);
            SignUpBtn.ForeColor = SystemColors.ButtonFace;
            SignUpBtn.Location = new Point(456, 582);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(329, 46);
            SignUpBtn.TabIndex = 19;
            SignUpBtn.Text = "Don't have an account?";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1299, 693);
            Controls.Add(SignUpBtn);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(LoginBtn);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "Login";
            Text = "Login - Budget App";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Label passowrdLbl;
        private Label label1;
        private Button LoginBtn;
        private Label label7;
        private Label label5;
        private Button SignUpBtn;
    }
}