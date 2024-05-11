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
            cmdDepartment = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(143, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 29);
            textBox1.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.AutoSize = true;
            txtPosition.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPosition.Location = new Point(39, 41);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(68, 21);
            txtPosition.TabIndex = 0;
            txtPosition.Text = "Position";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 107);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "Department";
            // 
            // cmdDepartment
            // 
            cmdDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdDepartment.Location = new Point(143, 104);
            cmdDepartment.Name = "cmdDepartment";
            cmdDepartment.Size = new Size(146, 29);
            cmdDepartment.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(243, 179);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(139, 179);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FormPosition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 260);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(cmdDepartment);
            Controls.Add(txtPosition);
            Controls.Add(textBox1);
            Name = "FormPosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Position";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label txtPosition;
        private Label label1;
        private TextBox cmdDepartment;
        private Button btnClose;
        private Button btnSave;
    }
}