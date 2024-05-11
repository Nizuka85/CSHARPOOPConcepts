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
            btnClear = new Button();
            btnSearch = new Button();
            label8 = new Label();
            txtDayAmount = new TextBox();
            groupBox1 = new GroupBox();
            rbDeliveryDate = new RadioButton();
            rbStartDate = new RadioButton();
            dpStat = new DateTimePicker();
            dpFinish = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pnlForAdmin = new Panel();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 207);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDayAmount);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dpStat);
            panel3.Controls.Add(dpFinish);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(333, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 207);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(314, 159);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 42);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(314, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 42);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 147);
            label8.Name = "label8";
            label8.Size = new Size(106, 21);
            label8.TabIndex = 30;
            label8.Text = "Day Amount";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDayAmount.Location = new Point(138, 144);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.Size = new Size(153, 29);
            txtDayAmount.TabIndex = 2;
            txtDayAmount.KeyPress += txtDayAmount_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDeliveryDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(297, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(115, 83);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // rbDeliveryDate
            // 
            rbDeliveryDate.AutoSize = true;
            rbDeliveryDate.Location = new Point(0, 43);
            rbDeliveryDate.Name = "rbDeliveryDate";
            rbDeliveryDate.Size = new Size(111, 21);
            rbDeliveryDate.TabIndex = 1;
            rbDeliveryDate.TabStop = true;
            rbDeliveryDate.Text = "Delivery Date";
            rbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Location = new Point(0, 14);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(88, 21);
            rbStartDate.TabIndex = 0;
            rbStartDate.TabStop = true;
            rbStartDate.Text = "Start Date";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // dpStat
            // 
            dpStat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStat.Location = new Point(138, 51);
            dpStat.Name = "dpStat";
            dpStat.Size = new Size(153, 25);
            dpStat.TabIndex = 0;
            // 
            // dpFinish
            // 
            dpFinish.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpFinish.Location = new Point(138, 80);
            dpFinish.Name = "dpFinish";
            dpFinish.Size = new Size(153, 25);
            dpFinish.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 15);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 25;
            label5.Text = "Permission Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 51);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 26;
            label6.Text = "Start";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 80);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 27;
            label7.Text = "Finish";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(label4);
            pnlForAdmin.Controls.Add(cmbPosition);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Controls.Add(cmdDepartment);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(textBox1);
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Controls.Add(txtUserNo);
            pnlForAdmin.Controls.Add(label1);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(333, 207);
            pnlForAdmin.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 156);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 26;
            label4.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.Location = new Point(121, 153);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(194, 29);
            cmbPosition.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 117);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 25;
            label3.Text = "Department";
            // 
            // cmdDepartment
            // 
            cmdDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdDepartment.Location = new Point(121, 114);
            cmdDepartment.Name = "cmdDepartment";
            cmdDepartment.Size = new Size(194, 29);
            cmdDepartment.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 24;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(121, 85);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(194, 23);
            txtSurname.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(17, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(56, 21);
            txtName.TabIndex = 23;
            txtName.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(121, 24);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(194, 23);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
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
            panel2.Location = new Point(0, 430);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 96);
            panel2.TabIndex = 1;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(609, 3);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(109, 42);
            btnApprove.TabIndex = 4;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnDisApproved
            // 
            btnDisApproved.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisApproved.Location = new Point(609, 48);
            btnDisApproved.Name = "btnDisApproved";
            btnDisApproved.Size = new Size(109, 42);
            btnDisApproved.TabIndex = 5;
            btnDisApproved.Text = "Disapprove";
            btnDisApproved.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(52, 29);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(98, 42);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpDate.Location = new Point(156, 29);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new Size(98, 42);
            btnUpDate.TabIndex = 1;
            btnUpDate.Text = "UpDate";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpDate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(260, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(364, 29);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 42);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 223);
            dataGridView1.TabIndex = 2;
            // 
            // FormPermissionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormPermissionList";
            Text = "Permission List";
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
        private Label txtName;
        private TextBox txtUserNo;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbDeliveryDate;
        private RadioButton rbStartDate;
        private DateTimePicker dpFinish;
        private DateTimePicker dpStat;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox txtDayAmount;
        private Button btnClear;
        private Button btnSearch;
    }
}