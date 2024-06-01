namespace PersonalTracking
{
    partial class FormPermissionList
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
            panel3 = new Panel();
            cmbState = new ComboBox();
            label9 = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            label8 = new Label();
            txtDayAmount = new TextBox();
            groupBox1 = new GroupBox();
            rbEndDate = new RadioButton();
            rbStartDate = new RadioButton();
            dpStat = new DateTimePicker();
            dpEnd = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pnlForAdmin = new Panel();
            txtName = new TextBox();
            comboBox1 = new ComboBox();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSurname = new TextBox();
            labelName = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnApprove = new Button();
            btnDisApproved = new Button();
            btnNew = new Button();
            btnUpDate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 276);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbState);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDayAmount);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dpStat);
            panel3.Controls.Add(dpEnd);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(381, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(533, 276);
            panel3.TabIndex = 1;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(126, 234);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(227, 28);
            cmbState.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 234);
            label9.Name = "label9";
            label9.Size = new Size(61, 28);
            label9.TabIndex = 31;
            label9.Text = "State";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(359, 212);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 56);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(359, 152);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 56);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 196);
            label8.Name = "label8";
            label8.Size = new Size(131, 28);
            label8.TabIndex = 30;
            label8.Text = "Day Amount";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDayAmount.Location = new Point(158, 193);
            txtDayAmount.Margin = new Padding(3, 4, 3, 4);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.Size = new Size(174, 34);
            txtDayAmount.TabIndex = 2;
            txtDayAmount.KeyPress += txtDayAmount_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEndDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(339, 33);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(131, 111);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // rbEndDate
            // 
            rbEndDate.AutoSize = true;
            rbEndDate.Location = new Point(0, 57);
            rbEndDate.Margin = new Padding(3, 4, 3, 4);
            rbEndDate.Name = "rbEndDate";
            rbEndDate.Size = new Size(104, 27);
            rbEndDate.TabIndex = 1;
            rbEndDate.TabStop = true;
            rbEndDate.Text = "End Date";
            rbEndDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Location = new Point(0, 19);
            rbStartDate.Margin = new Padding(3, 4, 3, 4);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(114, 27);
            rbStartDate.TabIndex = 0;
            rbStartDate.TabStop = true;
            rbStartDate.Text = "Start Date";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // dpStat
            // 
            dpStat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStat.Location = new Point(158, 68);
            dpStat.Margin = new Padding(3, 4, 3, 4);
            dpStat.Name = "dpStat";
            dpStat.Size = new Size(174, 29);
            dpStat.TabIndex = 0;
            dpStat.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            // 
            // dpEnd
            // 
            dpEnd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpEnd.Location = new Point(158, 107);
            dpEnd.Margin = new Padding(3, 4, 3, 4);
            dpEnd.Name = "dpEnd";
            dpEnd.Size = new Size(174, 29);
            dpEnd.TabIndex = 1;
            dpEnd.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 20);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 25;
            label5.Text = "Permission Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 68);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 26;
            label6.Text = "Start";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 107);
            label7.Name = "label7";
            label7.Size = new Size(67, 28);
            label7.TabIndex = 27;
            label7.Text = "Finish";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Controls.Add(comboBox1);
            pnlForAdmin.Controls.Add(cmbDepartment);
            pnlForAdmin.Controls.Add(label4);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(labelName);
            pnlForAdmin.Controls.Add(txtUserNo);
            pnlForAdmin.Controls.Add(label1);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Margin = new Padding(3, 4, 3, 4);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(381, 276);
            pnlForAdmin.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 67);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(140, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 28);
            comboBox1.TabIndex = 28;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(138, 160);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(227, 28);
            cmbDepartment.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 208);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 26;
            label4.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 25;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 24;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(138, 113);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(221, 27);
            txtSurname.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(19, 77);
            labelName.Name = "labelName";
            labelName.Size = new Size(68, 28);
            labelName.TabIndex = 23;
            labelName.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(138, 32);
            txtUserNo.Margin = new Padding(3, 4, 3, 4);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(221, 27);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 22;
            label1.Text = "UserNo";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnDisApproved);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnUpDate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 573);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 128);
            panel2.TabIndex = 1;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(696, 4);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(125, 56);
            btnApprove.TabIndex = 4;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDisApproved
            // 
            btnDisApproved.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisApproved.Location = new Point(696, 64);
            btnDisApproved.Margin = new Padding(3, 4, 3, 4);
            btnDisApproved.Name = "btnDisApproved";
            btnDisApproved.Size = new Size(125, 56);
            btnDisApproved.TabIndex = 5;
            btnDisApproved.Text = "Disapprove";
            btnDisApproved.UseVisualStyleBackColor = true;
            btnDisApproved.Click += btnDisApproved_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(59, 39);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 56);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpDate.Location = new Point(178, 39);
            btnUpDate.Margin = new Padding(3, 4, 3, 4);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new Size(112, 56);
            btnUpDate.TabIndex = 1;
            btnUpDate.Text = "UpDate";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpDate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(297, 39);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 56);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(416, 39);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 56);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 276);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 297);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // FormPermissionList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 701);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPermissionList";
            Text = "Permission List";
            Load += FormPermissionList_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnApprove;
        private Button btnDisApproved;
        private Button btnNew;
        private Button btnUpDate;
        private Button btnDelete;
        private Button btnClose;
        private Panel panel3;
        private Panel pnlForAdmin;
        private Label label4;
        private TextBox cmbPosition;
        private Label label3;
        private TextBox cmdDepartment;
        private Label label2;
        private TextBox txtSurname;
        private TextBox textBox1;
        private Label labelName;
        private TextBox txtUserNo;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbEndDate;
        private RadioButton rbStartDate;
        private DateTimePicker dpEnd;
        private DateTimePicker dpStat;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox txtDayAmount;
        private Button btnClear;
        private Button btnSearch;
        private ComboBox cmbDepartment;
        private TextBox txtName;
        private ComboBox comboBox1;
        private ComboBox cmbState;
        private Label label9;
    }
}