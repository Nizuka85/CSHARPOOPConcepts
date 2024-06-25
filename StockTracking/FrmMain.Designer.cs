namespace StockTracking
{
    partial class FrmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::StockTracking.Properties.Resources.exit_64;
            this.btnExit.Location = new System.Drawing.Point(177, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 145);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleted.Image = global::StockTracking.Properties.Resources.account_logout_64;
            this.btnDeleted.Location = new System.Drawing.Point(347, 198);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(138, 145);
            this.btnDeleted.TabIndex = 5;
            this.btnDeleted.Text = "Deleted";
            this.btnDeleted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleted.UseVisualStyleBackColor = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.Silver;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Image = global::StockTracking.Properties.Resources.organization_64;
            this.btnAddStock.Location = new System.Drawing.Point(13, 198);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(138, 145);
            this.btnAddStock.TabIndex = 4;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Cyan;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = global::StockTracking.Properties.Resources.parallel_tasks_64;
            this.btnCategory.Location = new System.Drawing.Point(177, 198);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(138, 145);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Yellow;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::StockTracking.Properties.Resources.money_bag_64;
            this.btnSales.Location = new System.Drawing.Point(347, 26);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(138, 145);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = global::StockTracking.Properties.Resources.workers_64;
            this.btnCustomer.Location = new System.Drawing.Point(13, 26);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(138, 145);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Lime;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = global::StockTracking.Properties.Resources.shopping_bag_2_64;
            this.btnProduct.Location = new System.Drawing.Point(188, 26);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(138, 145);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 549);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnProduct);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Tracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnExit;
    }
}