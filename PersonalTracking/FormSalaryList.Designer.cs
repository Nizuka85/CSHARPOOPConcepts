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
            cmbMonth = new ComboBox();
            btnClear = new Button();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            rbEqual = new RadioButton();
            rbLess = new RadioButton();
            rbMore = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            txtYear = new TextBox();
            label5 = new Label();
            txtsalary = new TextBox();
            panel3 = new Panel();
            cmbPosition = new ComboBox();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            labelN = new Label();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 231);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbMonth);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtYear);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtsalary);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(381, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(593, 231);
            panel4.TabIndex = 1;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(93, 55);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(221, 28);
            cmbMonth.TabIndex = 46;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(299, 157);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 56);
            btnClear.TabIndex = 45;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(179, 157);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 56);
            btnSearch.TabIndex = 44;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEqual);
            groupBox1.Controls.Add(rbLess);
            groupBox1.Controls.Add(rbMore);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(321, 75);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(224, 61);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            // 
            // rbEqual
            // 
            rbEqual.AutoSize = true;
            rbEqual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbEqual.Location = new Point(142, 25);
            rbEqual.Margin = new Padding(3, 4, 3, 4);
            rbEqual.Name = "rbEqual";
            rbEqual.Size = new Size(82, 27);
            rbEqual.TabIndex = 2;
            rbEqual.TabStop = true;
            rbEqual.Text = "Equals";
            rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            rbLess.AutoSize = true;
            rbLess.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbLess.Location = new Point(80, 25);
            rbLess.Margin = new Padding(3, 4, 3, 4);
            rbLess.Name = "rbLess";
            rbLess.Size = new Size(63, 27);
            rbLess.TabIndex = 1;
            rbLess.TabStop = true;
            rbLess.Text = "Less";
            rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMore.Location = new Point(7, 25);
            rbMore.Margin = new Padding(3, 4, 3, 4);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(73, 27);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 55);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 42;
            label7.Text = "Month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 15);
            label6.Name = "label6";
            label6.Size = new Size(52, 28);
            label6.TabIndex = 41;
            label6.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(93, 12);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(221, 27);
            txtYear.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 93);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 40;
            label5.Text = "Salary";
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(93, 91);
            txtsalary.Margin = new Padding(3, 4, 3, 4);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(221, 27);
            txtsalary.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbPosition);
            panel3.Controls.Add(cmbDepartment);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtSurname);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(labelN);
            panel3.Controls.Add(txtUserNo);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 231);
            panel3.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(136, 189);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(223, 28);
            cmbPosition.TabIndex = 28;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(136, 133);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(227, 28);
            cmbDepartment.TabIndex = 27;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 185);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 26;
            label4.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 133);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 25;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 93);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 24;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(136, 91);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(221, 27);
            txtSurname.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 52);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 18;
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelN.Location = new Point(17, 55);
            labelN.Name = "labelN";
            labelN.Size = new Size(68, 28);
            labelN.TabIndex = 23;
            labelN.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(136, 9);
            txtUserNo.Margin = new Padding(3, 4, 3, 4);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(221, 27);
            txtUserNo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
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
            panel2.Location = new Point(0, 496);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 104);
            panel2.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(223, 24);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 56);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpDate.Location = new Point(342, 24);
            btnUpDate.Margin = new Padding(3, 4, 3, 4);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new Size(112, 56);
            btnUpDate.TabIndex = 6;
            btnUpDate.Text = "UpDate";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpDate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(461, 24);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 56);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(579, 24);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 56);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 231);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(974, 265);
            dataGridView1.TabIndex = 2;
            // 
            // FormSalaryList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSalaryList";
            Text = "SalaryList";
            Load += FormSalaryList_Load;
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
        private Label label3;
        private Label label2;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label labelN;
        private TextBox txtUserNo;
        private Label label1;
        private Label label7;
        private Label label6;
        private TextBox txtYear;
        private Label label5;
        private TextBox txtsalary;
        private GroupBox groupBox1;
        private RadioButton rbMore;
        private RadioButton rbEqual;
        private RadioButton rbLess;
        private Button btnClear;
        private Button btnSearch;
        private ComboBox cmbPosition;
        private ComboBox cmbDepartment;
        private ComboBox cmbMonth;
    }
}