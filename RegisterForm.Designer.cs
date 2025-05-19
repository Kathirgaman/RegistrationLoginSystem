namespace UserAuthSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbEmailID = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.Location = new System.Drawing.Point(433, 218);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(57, 16);
            this.lblEmailID.TabIndex = 1;
            this.lblEmailID.Text = "Email ID";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(436, 280);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Password";
            // 
            // tbEmailID
            // 
            this.tbEmailID.Location = new System.Drawing.Point(618, 215);
            this.tbEmailID.Name = "tbEmailID";
            this.tbEmailID.Size = new System.Drawing.Size(200, 22);
            this.tbEmailID.TabIndex = 3;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(618, 156);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(200, 22);
            this.tbusername.TabIndex = 4;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(618, 280);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(200, 22);
            this.TBPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(571, 472);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.Location = new System.Drawing.Point(502, 531);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(241, 35);
            this.btnLOGIN.TabIndex = 7;
            this.btnLOGIN.Text = "Already have an account? Login";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "What is your mother\'s maiden name?",
            "",
            "",
            "What is the name of your first pet?",
            "",
            "",
            "What is your favorite color?",
            "",
            "",
            "What city were you born in?",
            "",
            "",
            "What is your favorite food?"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(618, 351);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(200, 24);
            this.cmbSecurityQuestion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Security Question";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(618, 408);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(200, 22);
            this.txtSecurityAnswer.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSecurityQuestion);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbEmailID);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmailID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbEmailID;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label label3;
    }
}

