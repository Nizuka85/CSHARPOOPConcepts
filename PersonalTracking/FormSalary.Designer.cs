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
            cmbPosition = new ComboBox();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            labelName = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtSalary = new TextBox();
            label6 = new Label();
            txtYear = new TextBox();
            label7 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cmbMonth = new ComboBox();
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
            panel1.Location = new Point(578, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 600);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 180);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(336, 420);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbPosition);
            panel2.Controls.Add(cmbDepartment);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 180);
            panel2.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(77, 122);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(223, 28);
            cmbPosition.TabIndex = 26;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(77, 47);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(227, 28);
            cmbDepartment.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 91);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 24;
            label4.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 16);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 23;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 30;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(144, 97);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(221, 27);
            txtSurname.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 59);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 26;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(25, 61);
            labelName.Name = "labelName";
            labelName.Size = new Size(68, 28);
            labelName.TabIndex = 29;
            labelName.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(144, 16);
            txtUserNo.Margin = new Padding(3, 4, 3, 4);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(221, 27);
            txtUserNo.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 28;
            label1.Text = "UserNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 152);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 32;
            label5.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(144, 149);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(221, 27);
            txtSalary.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 205);
            label6.Name = "label6";
            label6.Size = new Size(52, 28);
            label6.TabIndex = 34;
            label6.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(144, 203);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(221, 27);
            txtYear.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 260);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 36;
            label7.Text = "Month";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(285, 496);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(81, 39);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(166, 496);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(144, 260);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(223, 28);
            cmbMonth.TabIndex = 37;
            // 
            // FormSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cmbMonth);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtYear);
            Controls.Add(label5);
            Controls.Add(txtSalary);
            Controls.Add(label2);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSalary";
            Text = "FormSalary";
            Load += FormSalary_Load;
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
        private TextBox txtName;
        private Label labelName;
        private TextBox txtUserNo;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtSalary;
        private Label label6;
        private TextBox txtYear;
        private Label label7;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cmbDepartment;
        private ComboBox cmbPosition;
        private ComboBox cmbMonth;
    }
}