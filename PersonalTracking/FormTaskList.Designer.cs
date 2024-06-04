namespace PersonalTracking
{
    partial class FormTaskList
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
            cmbTaskState = new ComboBox();
            btnClear = new Button();
            btnSearch = new Button();
            label8 = new Label();
            groupBox1 = new GroupBox();
            rbDeliveryDate = new RadioButton();
            rbStartDate = new RadioButton();
            dpFinish = new DateTimePicker();
            dpStat = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pnlForAdmin = new Panel();
            cmbPosition = new ComboBox();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            labelll = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnApprove = new Button();
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
            panel1.Size = new Size(862, 240);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbTaskState);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dpFinish);
            panel3.Controls.Add(dpStat);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(371, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 240);
            panel3.TabIndex = 1;
            // 
            // cmbTaskState
            // 
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(144, 140);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(217, 28);
            cmbTaskState.TabIndex = 32;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(358, 180);
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
            btnSearch.Location = new Point(238, 180);
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
            label8.Location = new Point(27, 140);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 24;
            label8.Text = "Task State";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDeliveryDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(337, 40);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(131, 111);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // rbDeliveryDate
            // 
            rbDeliveryDate.AutoSize = true;
            rbDeliveryDate.Location = new Point(0, 56);
            rbDeliveryDate.Margin = new Padding(3, 4, 3, 4);
            rbDeliveryDate.Name = "rbDeliveryDate";
            rbDeliveryDate.Size = new Size(141, 27);
            rbDeliveryDate.TabIndex = 1;
            rbDeliveryDate.TabStop = true;
            rbDeliveryDate.Text = "Delivery Date";
            rbDeliveryDate.UseVisualStyleBackColor = true;
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
            // dpFinish
            // 
            dpFinish.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpFinish.Location = new Point(144, 96);
            dpFinish.Margin = new Padding(3, 4, 3, 4);
            dpFinish.Name = "dpFinish";
            dpFinish.Size = new Size(186, 29);
            dpFinish.TabIndex = 1;
            // 
            // dpStat
            // 
            dpStat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStat.Location = new Point(144, 57);
            dpStat.Margin = new Padding(3, 4, 3, 4);
            dpStat.Name = "dpStat";
            dpStat.Size = new Size(186, 29);
            dpStat.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 96);
            label7.Name = "label7";
            label7.Size = new Size(67, 28);
            label7.TabIndex = 19;
            label7.Text = "Finish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 57);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 18;
            label6.Text = "Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 9);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 17;
            label5.Text = "Task Date";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(cmbPosition);
            pnlForAdmin.Controls.Add(cmbDepartment);
            pnlForAdmin.Controls.Add(label4);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Controls.Add(labelll);
            pnlForAdmin.Controls.Add(txtUserNo);
            pnlForAdmin.Controls.Add(label1);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Margin = new Padding(3, 4, 3, 4);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(371, 240);
            pnlForAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(134, 188);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(223, 28);
            cmbPosition.TabIndex = 23;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(136, 136);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(221, 28);
            cmbDepartment.TabIndex = 22;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 188);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 16;
            label4.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 136);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 15;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 96);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 12;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(136, 93);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(221, 27);
            txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 55);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 1;
            // 
            // labelll
            // 
            labelll.AutoSize = true;
            labelll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelll.Location = new Point(11, 57);
            labelll.Name = "labelll";
            labelll.Size = new Size(68, 28);
            labelll.TabIndex = 11;
            labelll.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(136, 12);
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
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 10;
            label1.Text = "UserNo";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnUpDate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 467);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(862, 133);
            panel2.TabIndex = 1;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(94, 39);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(122, 56);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(222, 39);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 56);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpDate.Location = new Point(342, 39);
            btnUpDate.Margin = new Padding(3, 4, 3, 4);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new Size(112, 56);
            btnUpDate.TabIndex = 2;
            btnUpDate.Text = "UpDate";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpDate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(461, 39);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 56);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(579, 39);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 56);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 240);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(862, 227);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // FormTaskList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTaskList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task List";
            Load += FormTaskList_Load;
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
        private Panel pnlForAdmin;
        private Button btnApprove;
        private Button btnNew;
        private Button btnUpDate;
        private Button btnDelete;
        private Button btnClose;
        private Panel panel3;
        private Label label2;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label labelll;
        private TextBox txtUserNo;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker dpFinish;
        private DateTimePicker dpStat;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton rbStartDate;
        private Label label8;
        private RadioButton rbDeliveryDate;
        private Button btnClear;
        private Button btnSearch;
        private ComboBox cmbDepartment;
        private ComboBox cmbPosition;
        private ComboBox cmbTaskState;
    }
}