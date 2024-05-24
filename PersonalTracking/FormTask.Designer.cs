namespace PersonalTracking
{
    partial class FormTask
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
            labell = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            txtContent = new TextBox();
            label6 = new Label();
            txtTitle = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            cmbTaskState = new ComboBox();
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
            panel1.Location = new Point(435, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 892);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 220);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(747, 672);
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
            panel2.Size = new Size(747, 220);
            panel2.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(65, 126);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(223, 28);
            cmbPosition.TabIndex = 22;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(61, 47);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(227, 28);
            cmbDepartment.TabIndex = 21;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 87);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 20;
            label4.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 12);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 19;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 99);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 18;
            label2.Text = "SurName";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(181, 96);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(221, 27);
            txtSurname.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 57);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 14;
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labell.Location = new Point(11, 60);
            labell.Name = "labell";
            labell.Size = new Size(68, 28);
            labell.TabIndex = 17;
            labell.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(181, 15);
            txtUserNo.Margin = new Padding(3, 4, 3, 4);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(221, 27);
            txtUserNo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 16;
            label1.Text = "UserNo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 171);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 26;
            label8.Text = "Task State";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 261);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 28;
            label5.Text = "Content";
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContent.Location = new Point(24, 297);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(378, 276);
            txtContent.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 217);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 30;
            label6.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(175, 214);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(227, 34);
            txtTitle.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(145, 613);
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
            btnSave.Location = new Point(26, 613);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbTaskState
            // 
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(175, 170);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(227, 28);
            cmbTaskState.TabIndex = 31;
            // 
            // FormTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 892);
            Controls.Add(cmbTaskState);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(txtContent);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(labell);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTask";
            Text = "FormTask";
            Load += FormTask_Load;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label labell;
        private TextBox txtUserNo;
        private Label label1;
        private Label label8;
        private Label label5;
        private TextBox txtContent;
        private Label label6;
        private TextBox txtTitle;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cmbPosition;
        private ComboBox cmbDepartment;
        private ComboBox cmbTaskState;
    }
}