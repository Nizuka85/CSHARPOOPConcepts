namespace PersonalTracking
{
    partial class FormDepartmentList
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
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNew = new Button();
            btnUpDate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(487, 499);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnNew);
            flowLayoutPanel1.Controls.Add(btnUpDate);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnClose);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 398);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(487, 83);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(3, 4);
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
            btnUpDate.Location = new Point(121, 4);
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
            btnDelete.Location = new Point(239, 4);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 56);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(357, 4);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 56);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormDepartmentList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 481);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDepartmentList";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department List";
            Load += FormDepartmentList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNew;
        private Button btnUpDate;
        private Button btnDelete;
        private Button btnClose;
    }
}