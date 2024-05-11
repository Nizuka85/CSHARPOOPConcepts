
namespace PersonalTracking
{
    partial class FormEmployee
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
            chAdmin = new CheckBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnCheck = new Button();
            txtUserNo = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtSurname = new TextBox();
            label4 = new Label();
            txtImagePath = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            txtSalary = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cmbPosition = new TextBox();
            label8 = new Label();
            cmdDepartment = new TextBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label10 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chAdmin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 115);
            panel1.TabIndex = 0;
            // 
            // chAdmin
            // 
            chAdmin.AutoSize = true;
            chAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            chAdmin.Location = new Point(689, 19);
            chAdmin.Name = "chAdmin";
            chAdmin.Size = new Size(96, 25);
            chAdmin.TabIndex = 8;
            chAdmin.Text = "is Admin?";
            chAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(479, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 23);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(375, 14);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(261, 12);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(98, 27);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(91, 14);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(164, 23);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 4;
            label1.Text = "UserNo";
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 23);
            txtName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(143, 163);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(194, 23);
            txtSurname.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 165);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 11;
            label4.Text = "SurName";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(143, 199);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(194, 23);
            txtImagePath.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 199);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 13;
            label5.Text = "Imagem Path";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(575, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 144);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(356, 201);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(61, 22);
            btnBrowse.TabIndex = 15;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(143, 233);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(194, 23);
            txtSalary.TabIndex = 3;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 231);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 17;
            label6.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 307);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 21;
            label7.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.Location = new Point(143, 306);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(194, 29);
            cmbPosition.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 268);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 20;
            label8.Text = "Department";
            // 
            // cmdDepartment
            // 
            cmdDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdDepartment.Location = new Point(143, 267);
            cmdDepartment.Name = "cmdDepartment";
            cmdDepartment.Size = new Size(194, 29);
            cmdDepartment.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 348);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 23;
            label9.Text = "Bhirtday";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(143, 359);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 388);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(642, 96);
            textBox1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 388);
            label10.Name = "label10";
            label10.Size = new Size(56, 21);
            label10.TabIndex = 26;
            label10.Text = "Name";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(247, 490);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(143, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cmbPosition);
            Controls.Add(label8);
            Controls.Add(cmdDepartment);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox1);
            Controls.Add(txtImagePath);
            Controls.Add(label5);
            Controls.Add(txtSurname);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private TextBox txtUserNo;
        private Label label1;
        private Button btnCheck;
        private CheckBox chAdmin;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtSurname;
        private Label label4;
        private TextBox txtImagePath;
        private Label label5;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private TextBox txtSalary;
        private Label label6;
        private Label label7;
        private TextBox cmbPosition;
        private Label label8;
        private TextBox cmdDepartment;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label10;
        private Button btnClose;
        private Button btnSave;
    }
}