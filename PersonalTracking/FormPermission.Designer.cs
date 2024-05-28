namespace PersonalTracking
{
    partial class FormPermission
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
            txtUserNo = new TextBox();
            label1 = new Label();
            dpEnd = new DateTimePicker();
            dpStart = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            txtDayAmount = new TextBox();
            label2 = new Label();
            txtExplanation = new TextBox();
            label3 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(158, 36);
            txtUserNo.Margin = new Padding(3, 4, 3, 4);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(221, 27);
            txtUserNo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 18;
            label1.Text = "UserNo";
            // 
            // dpEnd
            // 
            dpEnd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpEnd.Location = new Point(158, 118);
            dpEnd.Margin = new Padding(3, 4, 3, 4);
            dpEnd.Name = "dpEnd";
            dpEnd.Size = new Size(335, 29);
            dpEnd.TabIndex = 1;
            dpEnd.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dpEnd.ValueChanged += dpFinish_ValueChanged;
            // 
            // dpStart
            // 
            dpStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStart.Location = new Point(158, 77);
            dpStart.Margin = new Padding(3, 4, 3, 4);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(335, 29);
            dpStart.TabIndex = 0;
            dpStart.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dpStart.ValueChanged += dpStat_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 120);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 23;
            label7.Text = "End Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 81);
            label6.Name = "label6";
            label6.Size = new Size(110, 28);
            label6.TabIndex = 22;
            label6.Text = "Start Date";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Location = new Point(158, 164);
            txtDayAmount.Margin = new Padding(3, 4, 3, 4);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.ReadOnly = true;
            txtDayAmount.Size = new Size(221, 27);
            txtDayAmount.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 164);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 25;
            label2.Text = "Day Amout";
            // 
            // txtExplanation
            // 
            txtExplanation.Location = new Point(57, 240);
            txtExplanation.Margin = new Padding(3, 4, 3, 4);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(436, 204);
            txtExplanation.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 200);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 27;
            label3.Text = "Explanation";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(277, 451);
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
            btnSave.Location = new Point(158, 451);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormPermission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 517);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtExplanation);
            Controls.Add(label3);
            Controls.Add(txtDayAmount);
            Controls.Add(label2);
            Controls.Add(dpEnd);
            Controls.Add(dpStart);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPermission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission";
            Load += FormPermission_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserNo;
        private Label label1;
        private DateTimePicker dpEnd;
        private DateTimePicker dpStart;
        private Label label7;
        private Label label6;
        private TextBox txtDayAmount;
        private Label label2;
        private TextBox txtExplanation;
        private Label label3;
        private Button btnClose;
        private Button btnSave;
    }
}