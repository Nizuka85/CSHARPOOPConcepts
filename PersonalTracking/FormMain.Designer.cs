namespace PersonalTracking
{
    partial class FormMain
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
            button1 = new Button();
            button2 = new Button();
            btnSalary = new Button();
            btnPermission = new Button();
            btnDepartment = new Button();
            btnPosition = new Button();
            btnLogOut = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.workers_64;
            button1.Location = new Point(39, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(149, 148);
            button1.TabIndex = 0;
            button1.Text = "Employee";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.chart_64;
            button2.Location = new Point(214, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(149, 148);
            button2.TabIndex = 1;
            button2.Text = "Tasks";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.LightGreen;
            btnSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalary.Image = Properties.Resources.money_bag_64;
            btnSalary.Location = new Point(389, 16);
            btnSalary.Margin = new Padding(3, 4, 3, 4);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(149, 148);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary";
            btnSalary.TextAlign = ContentAlignment.BottomCenter;
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnPermission
            // 
            btnPermission.BackColor = Color.MediumSeaGreen;
            btnPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPermission.Image = Properties.Resources.shopping_bag_2_64;
            btnPermission.Location = new Point(39, 189);
            btnPermission.Margin = new Padding(3, 4, 3, 4);
            btnPermission.Name = "btnPermission";
            btnPermission.Size = new Size(149, 148);
            btnPermission.TabIndex = 3;
            btnPermission.Text = "Permission";
            btnPermission.TextAlign = ContentAlignment.BottomCenter;
            btnPermission.UseVisualStyleBackColor = false;
            btnPermission.Click += btnPermission_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.PeachPuff;
            btnDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepartment.Image = Properties.Resources.parallel_tasks_64;
            btnDepartment.Location = new Point(214, 189);
            btnDepartment.Margin = new Padding(3, 4, 3, 4);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(149, 148);
            btnDepartment.TabIndex = 4;
            btnDepartment.Text = "Department";
            btnDepartment.TextAlign = ContentAlignment.BottomCenter;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnPosition
            // 
            btnPosition.BackColor = Color.MediumPurple;
            btnPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPosition.Image = Properties.Resources.medal_3_64;
            btnPosition.Location = new Point(389, 189);
            btnPosition.Margin = new Padding(3, 4, 3, 4);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(149, 148);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Position";
            btnPosition.TextAlign = ContentAlignment.BottomCenter;
            btnPosition.UseVisualStyleBackColor = false;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Yellow;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Image = Properties.Resources.account_logout_64;
            btnLogOut.Location = new Point(127, 396);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(149, 148);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "LogOut";
            btnLogOut.TextAlign = ContentAlignment.BottomCenter;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Image = Properties.Resources.exit_64;
            btnExit.Location = new Point(303, 396);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 148);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 600);
            Controls.Add(btnExit);
            Controls.Add(btnLogOut);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(btnPermission);
            Controls.Add(btnSalary);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Employee Tracking";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnSalary;
        private Button btnPermission;
        private Button btnDepartment;
        private Button btnPosition;
        private Button btnLogOut;
        private Button btnExit;
    }
}