namespace PersonalTracking
{
    partial class FormPosition
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
            textBox1 = new TextBox();
            txtPosition = new Label();
            label1 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cmbDepartment = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(163, 57);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 34);
            textBox1.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.AutoSize = true;
            txtPosition.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPosition.Location = new Point(45, 55);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(85, 28);
            txtPosition.TabIndex = 0;
            txtPosition.Text = "Position";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 143);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 0;
            label1.Text = "Department";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(278, 239);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(81, 39);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(159, 239);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 39);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(163, 143);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(166, 28);
            cmbDepartment.TabIndex = 6;
            // 
            // FormPosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 347);
            Controls.Add(cmbDepartment);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtPosition);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Position";
            Load += FormPosition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label txtPosition;
        private Label label1;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cmbDepartment;
    }
}