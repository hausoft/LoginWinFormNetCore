namespace LoginFormNetCore
{
    partial class FrmLogin
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnSignUp = new System.Windows.Forms.Panel();
            this.lblSign_LastName = new System.Windows.Forms.Label();
            this.lblSign_FirstName = new System.Windows.Forms.Label();
            this.lblSign_Password = new System.Windows.Forms.Label();
            this.lblSign_EmailAddress = new System.Windows.Forms.Label();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.txtSign_Password = new System.Windows.Forms.TextBox();
            this.txtSign_EmailAddress = new System.Windows.Forms.TextBox();
            this.txtSign_LastName = new System.Windows.Forms.TextBox();
            this.txtSign_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lblLogin_Password = new System.Windows.Forms.Label();
            this.lblLogin_EmailAddress = new System.Windows.Forms.Label();
            this.btnLoginSystem = new System.Windows.Forms.Button();
            this.txtLogin_Password = new System.Windows.Forms.TextBox();
            this.txtLogin_EmailAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnSignUp.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(179)))), ((int)(((byte)(176)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(43, 53);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(199, 55);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(242, 53);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(199, 55);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // pnSignUp
            // 
            this.pnSignUp.Controls.Add(this.lblSign_LastName);
            this.pnSignUp.Controls.Add(this.lblSign_FirstName);
            this.pnSignUp.Controls.Add(this.lblSign_Password);
            this.pnSignUp.Controls.Add(this.lblSign_EmailAddress);
            this.pnSignUp.Controls.Add(this.btnGetStarted);
            this.pnSignUp.Controls.Add(this.txtSign_Password);
            this.pnSignUp.Controls.Add(this.txtSign_EmailAddress);
            this.pnSignUp.Controls.Add(this.txtSign_LastName);
            this.pnSignUp.Controls.Add(this.txtSign_FirstName);
            this.pnSignUp.Controls.Add(this.label1);
            this.pnSignUp.Location = new System.Drawing.Point(46, 124);
            this.pnSignUp.Name = "pnSignUp";
            this.pnSignUp.Size = new System.Drawing.Size(398, 341);
            this.pnSignUp.TabIndex = 2;
            this.pnSignUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            // 
            // lblSign_LastName
            // 
            this.lblSign_LastName.AutoSize = true;
            this.lblSign_LastName.BackColor = System.Drawing.Color.White;
            this.lblSign_LastName.Font = new System.Drawing.Font("Georgia", 18F);
            this.lblSign_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.lblSign_LastName.Location = new System.Drawing.Point(212, 85);
            this.lblSign_LastName.Name = "lblSign_LastName";
            this.lblSign_LastName.Size = new System.Drawing.Size(126, 29);
            this.lblSign_LastName.TabIndex = 11;
            this.lblSign_LastName.Text = "Last Name";
            this.lblSign_LastName.Click += new System.EventHandler(this.LblSign_LastName_Click);
            // 
            // lblSign_FirstName
            // 
            this.lblSign_FirstName.AutoSize = true;
            this.lblSign_FirstName.BackColor = System.Drawing.Color.White;
            this.lblSign_FirstName.Font = new System.Drawing.Font("Georgia", 18F);
            this.lblSign_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.lblSign_FirstName.Location = new System.Drawing.Point(38, 85);
            this.lblSign_FirstName.Name = "lblSign_FirstName";
            this.lblSign_FirstName.Size = new System.Drawing.Size(131, 29);
            this.lblSign_FirstName.TabIndex = 10;
            this.lblSign_FirstName.Text = "Fisrt Name";
            this.lblSign_FirstName.Click += new System.EventHandler(this.LblSign_FirstName_Click);
            // 
            // lblSign_Password
            // 
            this.lblSign_Password.AutoSize = true;
            this.lblSign_Password.BackColor = System.Drawing.Color.White;
            this.lblSign_Password.Font = new System.Drawing.Font("Georgia", 18F);
            this.lblSign_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.lblSign_Password.Location = new System.Drawing.Point(40, 197);
            this.lblSign_Password.Name = "lblSign_Password";
            this.lblSign_Password.Size = new System.Drawing.Size(132, 29);
            this.lblSign_Password.TabIndex = 9;
            this.lblSign_Password.Text = "Password *";
            this.lblSign_Password.Click += new System.EventHandler(this.LblSign_Password_Click);
            // 
            // lblSign_EmailAddress
            // 
            this.lblSign_EmailAddress.AutoSize = true;
            this.lblSign_EmailAddress.BackColor = System.Drawing.Color.White;
            this.lblSign_EmailAddress.Font = new System.Drawing.Font("Georgia", 18F);
            this.lblSign_EmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.lblSign_EmailAddress.Location = new System.Drawing.Point(40, 137);
            this.lblSign_EmailAddress.Name = "lblSign_EmailAddress";
            this.lblSign_EmailAddress.Size = new System.Drawing.Size(185, 29);
            this.lblSign_EmailAddress.TabIndex = 8;
            this.lblSign_EmailAddress.Text = "Email Address *";
            this.lblSign_EmailAddress.Click += new System.EventHandler(this.LblSign_EmailAddress_Click);
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.Location = new System.Drawing.Point(25, 255);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(348, 55);
            this.btnGetStarted.TabIndex = 5;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.BtnGetStarted_Click);
            // 
            // txtSign_Password
            // 
            this.txtSign_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSign_Password.Font = new System.Drawing.Font("Georgia", 18F);
            this.txtSign_Password.Location = new System.Drawing.Point(25, 194);
            this.txtSign_Password.Multiline = true;
            this.txtSign_Password.Name = "txtSign_Password";
            this.txtSign_Password.PasswordChar = '*';
            this.txtSign_Password.Size = new System.Drawing.Size(348, 38);
            this.txtSign_Password.TabIndex = 4;
            this.txtSign_Password.Enter += new System.EventHandler(this.TxtSign_Password_Enter);
            this.txtSign_Password.Leave += new System.EventHandler(this.TxtSign_Password_Leave);
            // 
            // txtSign_EmailAddress
            // 
            this.txtSign_EmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSign_EmailAddress.Font = new System.Drawing.Font("Georgia", 18F);
            this.txtSign_EmailAddress.Location = new System.Drawing.Point(25, 134);
            this.txtSign_EmailAddress.Multiline = true;
            this.txtSign_EmailAddress.Name = "txtSign_EmailAddress";
            this.txtSign_EmailAddress.Size = new System.Drawing.Size(348, 38);
            this.txtSign_EmailAddress.TabIndex = 3;
            this.txtSign_EmailAddress.Enter += new System.EventHandler(this.TxtSign_EmailAddress_Enter);
            this.txtSign_EmailAddress.Leave += new System.EventHandler(this.TxtSign_EmailAddress_Leave);
            // 
            // txtSign_LastName
            // 
            this.txtSign_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSign_LastName.Font = new System.Drawing.Font("Georgia", 18F);
            this.txtSign_LastName.Location = new System.Drawing.Point(204, 80);
            this.txtSign_LastName.Multiline = true;
            this.txtSign_LastName.Name = "txtSign_LastName";
            this.txtSign_LastName.Size = new System.Drawing.Size(169, 38);
            this.txtSign_LastName.TabIndex = 2;
            this.txtSign_LastName.Enter += new System.EventHandler(this.TxtSign_LastName_Enter);
            this.txtSign_LastName.Leave += new System.EventHandler(this.TxtSign_LastName_Leave);
            // 
            // txtSign_FirstName
            // 
            this.txtSign_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSign_FirstName.Font = new System.Drawing.Font("Georgia", 18F);
            this.txtSign_FirstName.Location = new System.Drawing.Point(25, 80);
            this.txtSign_FirstName.Multiline = true;
            this.txtSign_FirstName.Name = "txtSign_FirstName";
            this.txtSign_FirstName.Size = new System.Drawing.Size(169, 38);
            this.txtSign_FirstName.TabIndex = 1;
            this.txtSign_FirstName.Enter += new System.EventHandler(this.TxtSign_FirstName_Enter);
            this.txtSign_FirstName.Leave += new System.EventHandler(this.TxtSign_FirstName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up for Free";
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.lblLogin_Password);
            this.pnLogin.Controls.Add(this.lblLogin_EmailAddress);
            this.pnLogin.Controls.Add(this.btnLoginSystem);
            this.pnLogin.Controls.Add(this.txtLogin_Password);
            this.pnLogin.Controls.Add(this.txtLogin_EmailAddress);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Location = new System.Drawing.Point(46, 124);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(398, 341);
            this.pnLogin.TabIndex = 3;
            this.pnLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            // 
            // lblLogin_Password
            // 
            this.lblLogin_Password.AutoSize = true;
            this.lblLogin_Password.BackColor = System.Drawing.Color.White;
            this.lblLogin_Password.Font = new System.Drawing.Font("Georgia", 18F);
            this.lblLogin_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.lblLogin_Password.Location = new System.Drawing.Point(46, 146);
            this.lblLogin_Password.Name = "lblLogin_Password";
            this.lblLogin_Password.Size = new System.Drawing.Size(132, 29);
            this.lblLogin_Password.TabIndex = 7;
            this.lblLogin_Password.Text = "Password *";
            this.lblLogin_Password.Click += new System.EventHandler(this.LblLogin_Password_Click);
            // 
            // lblLogin_EmailAddress
            // 
            this.lblLogin_EmailAddress.AutoSize = true;
            this.lblLogin_EmailAddress.BackColor = System.Drawing.Color.White;
            this.lblLogin_EmailAddress.Font = new System.Drawing.Font("Georgia", 18F);
            this.lblLogin_EmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.lblLogin_EmailAddress.Location = new System.Drawing.Point(46, 86);
            this.lblLogin_EmailAddress.Name = "lblLogin_EmailAddress";
            this.lblLogin_EmailAddress.Size = new System.Drawing.Size(185, 29);
            this.lblLogin_EmailAddress.TabIndex = 6;
            this.lblLogin_EmailAddress.Text = "Email Address *";
            this.lblLogin_EmailAddress.Click += new System.EventHandler(this.LblLogin_EmailAddress_Click);
            // 
            // btnLoginSystem
            // 
            this.btnLoginSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.btnLoginSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSystem.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSystem.ForeColor = System.Drawing.Color.White;
            this.btnLoginSystem.Location = new System.Drawing.Point(25, 202);
            this.btnLoginSystem.Name = "btnLoginSystem";
            this.btnLoginSystem.Size = new System.Drawing.Size(348, 55);
            this.btnLoginSystem.TabIndex = 5;
            this.btnLoginSystem.Text = "LOG IN";
            this.btnLoginSystem.UseVisualStyleBackColor = false;
            this.btnLoginSystem.Click += new System.EventHandler(this.BtnLoginSystem_Click);
            // 
            // txtLogin_Password
            // 
            this.txtLogin_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin_Password.Font = new System.Drawing.Font("Georgia", 18F);
            this.txtLogin_Password.Location = new System.Drawing.Point(25, 141);
            this.txtLogin_Password.Multiline = true;
            this.txtLogin_Password.Name = "txtLogin_Password";
            this.txtLogin_Password.PasswordChar = '*';
            this.txtLogin_Password.Size = new System.Drawing.Size(348, 38);
            this.txtLogin_Password.TabIndex = 4;
            this.txtLogin_Password.Enter += new System.EventHandler(this.TxtLogin_Password_Enter);
            this.txtLogin_Password.Leave += new System.EventHandler(this.TxtLogin_Password_Leave);
            // 
            // txtLogin_EmailAddress
            // 
            this.txtLogin_EmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin_EmailAddress.Font = new System.Drawing.Font("Georgia", 18F);
            this.txtLogin_EmailAddress.Location = new System.Drawing.Point(25, 81);
            this.txtLogin_EmailAddress.Multiline = true;
            this.txtLogin_EmailAddress.Name = "txtLogin_EmailAddress";
            this.txtLogin_EmailAddress.Size = new System.Drawing.Size(348, 38);
            this.txtLogin_EmailAddress.TabIndex = 3;
            this.txtLogin_EmailAddress.Enter += new System.EventHandler(this.TxtLogin_EmailAddress_Enter);
            this.txtLogin_EmailAddress.Leave += new System.EventHandler(this.TxtLogin_EmailAddress_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome Back!";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(447, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(491, 513);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnSignUp);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            this.pnSignUp.ResumeLayout(false);
            this.pnSignUp.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Panel pnSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSign_FirstName;
        private System.Windows.Forms.TextBox txtSign_LastName;
        private System.Windows.Forms.TextBox txtSign_EmailAddress;
        private System.Windows.Forms.TextBox txtSign_Password;
        private System.Windows.Forms.Button btnGetStarted;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Button btnLoginSystem;
        private System.Windows.Forms.TextBox txtLogin_Password;
        private System.Windows.Forms.TextBox txtLogin_EmailAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin_EmailAddress;
        private System.Windows.Forms.Label lblLogin_Password;
        private System.Windows.Forms.Label lblSign_LastName;
        private System.Windows.Forms.Label lblSign_FirstName;
        private System.Windows.Forms.Label lblSign_Password;
        private System.Windows.Forms.Label lblSign_EmailAddress;
        private System.Windows.Forms.Button btnClose;
    }
}

