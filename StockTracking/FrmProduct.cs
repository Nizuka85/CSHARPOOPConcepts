using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTracking.BLL;
using StockTracking.DAL;
using StockTracking.DAL.DTO;

namespace StockTracking
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        public ProductDTO dto=new ProductDTO();
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        ProductBLL bll= new ProductBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
                MessageBox.Show("Category Name is Empty");
            else if (cmbCategory.SelectedIndex == -1)
                MessageBox.Show("please select a category");
            else if (txtPrice.Text.Trim() == "")
                MessageBox.Show("Prise is empty");
            else
            {
                ProductDetailDTO product=new ProductDetailDTO();
                product.ProductName=txtCategoryName.Text;
                product.CategoryID= Convert.ToInt32(cmbCategory.SelectedIndex);
                product.Price= Convert.ToInt32(txtPrice.Text);
                if (bll.Insert(product))
                {
                    MessageBox.Show("Product was added");
                    txtPrice.Clear();
                    txtCategoryName.Clear();
                    cmbCategory.SelectedIndex= -1;
                }
            }
        }
    }
}
