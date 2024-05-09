namespace Encapsulation
{
    partial class FormEmployeeDetails
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(28, 129);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 12;
            label4.Text = "Employee Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 73);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 11;
            label3.Text = "Employee Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 32);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 10;
            label2.Text = "Employee Name";
            // 
            // CloseButton
            // 
            CloseButton.FlatStyle = FlatStyle.System;
            CloseButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(56, 189);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(108, 43);
            CloseButton.TabIndex = 9;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // FormEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 267);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CloseButton);
            Name = "FormEmployeeDetails";
            Text = "FormEmployeeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label4;
        public Label label3;
        public Label label2;
        private Button CloseButton;
    }
}