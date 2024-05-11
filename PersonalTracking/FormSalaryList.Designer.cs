namespace PersonalTracking
{
    partial class FormSalaryList
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
            panel4 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            rbEqual = new RadioButton();
            rbLess = new RadioButton();
            rbMore = new RadioButton();
            label7 = new Label();
            cmbMonth = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            panel3 = new Panel();
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
            panel2 = new Panel();
            btnNew = new Button();
            btnUpDate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 173);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(cmbMonth);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(333, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 173);
            panel4.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(262, 118);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 42);
            btnClear.TabIndex = 45;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(157, 118);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 42);
            btnSearch.TabIndex = 44;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEqual);
            groupBox1.Controls.Add(rbLess);
            groupBox1.Controls.Add(rbMore);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(281, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 46);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            // 
            // rbEqual
            // 
            rbEqual.AutoSize = true;
            rbEqual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbEqual.Location = new Point(124, 19);
            rbEqual.Name = "rbEqual";
            rbEqual.Size = new Size(66, 21);
            rbEqual.TabIndex = 2;
            rbEqual.TabStop = true;
            rbEqual.Text = "Equals";
            rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            rbLess.AutoSize = true;
            rbLess.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbLess.Location = new Point(70, 19);
            rbLess.Name = "rbLess";
            rbLess.Size = new Size(52, 21);
            rbLess.TabIndex = 1;
            rbLess.TabStop = true;
            rbLess.Text = "Less";
            rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMore.Location = new Point(6, 19);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(58, 21);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 41);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 42;
            label7.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.Location = new Point(81, 39);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(194, 23);
            cmbMonth.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 11);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 41;
            label6.Text = "Year";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 70);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 40;
            label5.Text = "Salary";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cmbPosition);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cmdDepartment);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtSurname);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtUserNo);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 173);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 139);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 26;
            label4.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.Location = new Point(119, 136);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(194, 29);
            cmbPosition.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 100);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 25;
            label3.Text = "Department";
            // 
            // cmdDepartment
            // 
            cmdDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdDepartment.Location = new Point(119, 97);
            cmdDepartment.Name = "cmdDepartment";
            cmdDepartment.Size = new Size(194, 29);
            cmdDepartment.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 24;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(119, 68);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(194, 23);
            txtSurname.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(15, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(56, 21);
            txtName.TabIndex = 23;
            txtName.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(119, 7);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(194, 23);
            txtUserNo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 7);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 22;
            label1.Text = "UserNo";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnUpDate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 372);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 78);
            panel2.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(195, 18);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(98, 42);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpDate.Location = new Point(299, 18);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new Size(98, 42);
            btnUpDate.TabIndex = 6;
            btnUpDate.Text = "UpDate";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpDate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(403, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 42);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(507, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 42);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(852, 199);
            dataGridView1.TabIndex = 2;
            // 
            // FormSalaryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormSalaryList";
            Text = "SalaryList";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button btnNew;
        private Button btnUpDate;
        private Button btnDelete;
        private Button btnClose;
        private Panel panel4;
        private Label label4;
        private TextBox cmbPosition;
        private Label label3;
        private TextBox cmdDepartment;
        private Label label2;
        private TextBox txtSurname;
        private TextBox textBox1;
        private Label txtName;
        private TextBox txtUserNo;
        private Label label1;
        private Label label7;
        private TextBox cmbMonth;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton rbMore;
        private RadioButton rbEqual;
        private RadioButton rbLess;
        private Button btnClear;
        private Button btnSearch;
    }
}