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
            txtPosition = new TextBox();
            Position = new Label();
            label1 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cmbDepartment = new ComboBox();
            SuspendLayout();
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPosition.Location = new Point(163, 57);
            txtPosition.Margin = new Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(166, 34);
            txtPosition.TabIndex = 1;
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Position.Location = new Point(45, 55);
            Position.Name = "Position";
            Position.Size = new Size(85, 28);
            Position.TabIndex = 0;
            Position.Text = "Position";
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
            btnSave.Click += btnSave_Click;
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
            Controls.Add(Position);
            Controls.Add(txtPosition);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Position";
            Load += FormPosition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPosition;
        private Label Position;
        private Label label1;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cmbDepartment;
    }
}