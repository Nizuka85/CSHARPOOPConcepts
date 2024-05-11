namespace PersonalTracking
{
    partial class FormLogin
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
            label1 = new Label();
            txtUserNo = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "UserNo";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(126, 26);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(194, 23);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 65);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 23);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 65);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(41, 159);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(194, 159);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 260);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserNo;
        private TextBox txtPassword;
        private Label label2;
        private Button btnExit;
        private Button btnLogin;
    }
}
