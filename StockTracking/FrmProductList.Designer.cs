namespace StockTracking
{
    partial class FrmProductList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbStockLess = new System.Windows.Forms.RadioButton();
            this.rbStockMore = new System.Windows.Forms.RadioButton();
            this.rbStockEquals = new System.Windows.Forms.RadioButton();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPriceLess = new System.Windows.Forms.RadioButton();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.rbPriceEquals = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 161);
            this.panel1.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(1009, 113);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(127, 40);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(862, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbStockLess);
            this.groupBox2.Controls.Add(this.rbStockMore);
            this.groupBox2.Controls.Add(this.rbStockEquals);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(872, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // rbStockLess
            // 
            this.rbStockLess.AutoSize = true;
            this.rbStockLess.Location = new System.Drawing.Point(172, 25);
            this.rbStockLess.Name = "rbStockLess";
            this.rbStockLess.Size = new System.Drawing.Size(71, 24);
            this.rbStockLess.TabIndex = 2;
            this.rbStockLess.TabStop = true;
            this.rbStockLess.Text = "Less";
            this.rbStockLess.UseVisualStyleBackColor = true;
            // 
            // rbStockMore
            // 
            this.rbStockMore.AutoSize = true;
            this.rbStockMore.Location = new System.Drawing.Point(89, 25);
            this.rbStockMore.Name = "rbStockMore";
            this.rbStockMore.Size = new System.Drawing.Size(72, 24);
            this.rbStockMore.TabIndex = 1;
            this.rbStockMore.TabStop = true;
            this.rbStockMore.Text = "More";
            this.rbStockMore.UseVisualStyleBackColor = true;
            // 
            // rbStockEquals
            // 
            this.rbStockEquals.AutoSize = true;
            this.rbStockEquals.Location = new System.Drawing.Point(6, 25);
            this.rbStockEquals.Name = "rbStockEquals";
            this.rbStockEquals.Size = new System.Drawing.Size(77, 24);
            this.rbStockEquals.TabIndex = 0;
            this.rbStockEquals.TabStop = true;
            this.rbStockEquals.Text = "Equal";
            this.rbStockEquals.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(622, 66);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(235, 30);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Product Stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPriceLess);
            this.groupBox1.Controls.Add(this.rbMore);
            this.groupBox1.Controls.Add(this.rbPriceEquals);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(872, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "price";
            // 
            // rbPriceLess
            // 
            this.rbPriceLess.AutoSize = true;
            this.rbPriceLess.Location = new System.Drawing.Point(172, 25);
            this.rbPriceLess.Name = "rbPriceLess";
            this.rbPriceLess.Size = new System.Drawing.Size(71, 24);
            this.rbPriceLess.TabIndex = 2;
            this.rbPriceLess.TabStop = true;
            this.rbPriceLess.Text = "Less";
            this.rbPriceLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            this.rbMore.AutoSize = true;
            this.rbMore.Location = new System.Drawing.Point(89, 25);
            this.rbMore.Name = "rbMore";
            this.rbMore.Size = new System.Drawing.Size(72, 24);
            this.rbMore.TabIndex = 1;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "More";
            this.rbMore.UseVisualStyleBackColor = true;
            // 
            // rbPriceEquals
            // 
            this.rbPriceEquals.AutoSize = true;
            this.rbPriceEquals.Location = new System.Drawing.Point(6, 25);
            this.rbPriceEquals.Name = "rbPriceEquals";
            this.rbPriceEquals.Size = new System.Drawing.Size(77, 24);
            this.rbPriceEquals.TabIndex = 0;
            this.rbPriceEquals.TabStop = true;
            this.rbPriceEquals.Text = "Equal";
            this.rbPriceEquals.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(622, 12);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(235, 30);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Price";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(187, 66);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(233, 33);
            this.cmbCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(187, 12);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(233, 30);
            this.txtCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 118);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(767, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 79);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(568, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 79);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(368, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 79);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(168, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 79);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 400);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPriceLess;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.RadioButton rbPriceEquals;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbStockLess;
        private System.Windows.Forms.RadioButton rbStockMore;
        private System.Windows.Forms.RadioButton rbStockEquals;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSearch;
    }
}