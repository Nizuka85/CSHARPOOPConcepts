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
            dpFinish = new DateTimePicker();
            dpStat = new DateTimePicker();
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
            txtUserNo.Location = new Point(119, 26);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(194, 23);
            txtUserNo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 18;
            label1.Text = "UserNo";
            // 
            // dpFinish
            // 
            dpFinish.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpFinish.Location = new Point(119, 88);
            dpFinish.Name = "dpFinish";
            dpFinish.Size = new Size(194, 25);
            dpFinish.TabIndex = 1;
            dpFinish.ValueChanged += dpFinish_ValueChanged;
            // 
            // dpStat
            // 
            dpStat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStat.Location = new Point(119, 57);
            dpStat.Name = "dpStat";
            dpStat.Size = new Size(194, 25);
            dpStat.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 90);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 23;
            label7.Text = "Finish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 61);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 22;
            label6.Text = "Start";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Location = new Point(119, 122);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.ReadOnly = true;
            txtDayAmount.Size = new Size(194, 23);
            txtDayAmount.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 123);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 25;
            label2.Text = "Day Amout";
            // 
            // txtExplanation
            // 
            txtExplanation.Location = new Point(50, 180);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(382, 154);
            txtExplanation.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 150);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 27;
            label3.Text = "Explanation";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(242, 338);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(138, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FormPermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 388);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtExplanation);
            Controls.Add(label3);
            Controls.Add(txtDayAmount);
            Controls.Add(label2);
            Controls.Add(dpFinish);
            Controls.Add(dpStat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
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
        private DateTimePicker dpFinish;
        private DateTimePicker dpStat;
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