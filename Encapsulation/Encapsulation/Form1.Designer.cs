namespace Encapsulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            label2 = new Label();
            txtEmployeeAge = new TextBox();
            label3 = new Label();
            txtEmployeePosition = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(112, 36);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(158, 250);
            button1.Name = "button1";
            button1.Size = new Size(108, 43);
            button1.TabIndex = 1;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(228, 39);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(135, 23);
            txtEmployeeID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(228, 88);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(135, 23);
            txtEmployeeName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(79, 86);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 3;
            label2.Text = "Employee Name";
            // 
            // txtEmployeeAge
            // 
            txtEmployeeAge.Location = new Point(228, 133);
            txtEmployeeAge.Name = "txtEmployeeAge";
            txtEmployeeAge.Size = new Size(135, 23);
            txtEmployeeAge.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(95, 131);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 5;
            label3.Text = "Employee Age";
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Location = new Point(228, 185);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(135, 23);
            txtEmployeePosition.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(62, 187);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 7;
            label4.Text = "Employee Position";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 333);
            Controls.Add(txtEmployeePosition);
            Controls.Add(label4);
            Controls.Add(txtEmployeeAge);
            Controls.Add(label3);
            Controls.Add(txtEmployeeName);
            Controls.Add(label2);
            Controls.Add(txtEmployeeID);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private Label label2;
        private TextBox txtEmployeeAge;
        private Label label3;
        private TextBox txtEmployeePosition;
        private Label label4;
    }
}
