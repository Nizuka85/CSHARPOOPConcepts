namespace PersonalTracking
{
    partial class FormEmployeeList
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
            btnClear = new Button();
            btnSearch = new Button();
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnNew = new Button();
            btnUpDate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbPosition);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmdDepartment);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 130);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(616, 69);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(616, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 42);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(335, 54);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 9;
            label4.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.Location = new Point(439, 51);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(146, 29);
            cmbPosition.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(335, 15);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 7;
            label3.Text = "Department";
            // 
            // cmdDepartment
            // 
            cmdDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdDepartment.Location = new Point(439, 12);
            cmdDepartment.Name = "cmdDepartment";
            cmdDepartment.Size = new Size(146, 29);
            cmdDepartment.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 80);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(119, 78);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(194, 23);
            txtSurname.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(15, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(56, 21);
            txtName.TabIndex = 3;
            txtName.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(119, 12);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(194, 23);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 2;
            label1.Text = "UserNo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(736, 231);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnUpDate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 74);
            panel2.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(85, 16);
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
            btnUpDate.Location = new Point(189, 16);
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
            btnDelete.Location = new Point(293, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(397, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 42);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormEmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 361);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormEmployeeList";
            Text = "Employee List";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnNew;
        private Button btnUpDate;
        private Button btnDelete;
        private Button btnClose;
        private TextBox txtUserNo;
        private Label label1;
        private Label label2;
        private TextBox txtSurname;
        private TextBox textBox1;
        private Label txtName;
        private Label label4;
        private TextBox cmbPosition;
        private Label label3;
        private TextBox cmdDepartment;
        private Button btnSearch;
        private Button btnClear;
    }
}