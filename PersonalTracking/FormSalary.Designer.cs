namespace PersonalTracking
{
    partial class FormSalary
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            cmbPosition = new TextBox();
            label3 = new Label();
            cmdDepartment = new TextBox();
            label2 = new Label();
            txtSurname = new TextBox();
            textBox1 = new TextBox();
            txtName = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            cmbMonth = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(506, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 450);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(294, 315);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbPosition);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmdDepartment);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 135);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 68);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 24;
            label4.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.Location = new Point(62, 92);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(194, 29);
            cmbPosition.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 12);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 23;
            label3.Text = "Department";
            // 
            // cmdDepartment
            // 
            cmdDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdDepartment.Location = new Point(62, 36);
            cmdDepartment.Name = "cmdDepartment";
            cmdDepartment.Size = new Size(194, 29);
            cmdDepartment.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 30;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(126, 73);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(194, 23);
            txtSurname.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 44);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(22, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(56, 21);
            txtName.TabIndex = 29;
            txtName.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(126, 12);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(194, 23);
            txtUserNo.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 28;
            label1.Text = "UserNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 114);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 32;
            label5.Text = "Salary";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 154);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 34;
            label6.Text = "Year";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 195);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 36;
            label7.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.Location = new Point(126, 193);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(194, 23);
            cmbMonth.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(249, 372);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(145, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(cmbMonth);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtSurname);
            Controls.Add(textBox1);
            Controls.Add(txtName);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormSalary";
            Text = "FormSalary";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private TextBox txtSurname;
        private TextBox textBox1;
        private Label txtName;
        private TextBox txtUserNo;
        private Label label1;
        private Label label4;
        private TextBox cmbPosition;
        private Label label3;
        private TextBox cmdDepartment;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox cmbMonth;
        private Button btnClose;
        private Button btnSave;
    }
}