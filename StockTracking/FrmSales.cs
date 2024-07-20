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
using StockTracking.DAL.DTO;

namespace StockTracking
{
    public partial class FrmSales : Form
    {
        public SalesDTO dto = new SalesDTO();
        public FrmSales()
        {
            InitializeComponent();
        }
        bool combofull=false;
        SalesBLL bll= new SalesBLL();
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                List<ProductDetailDTO> list = dto.Products;
                list=list.Where(x=>x.CategoryID==Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                dataGridView1.DataSource=list;
                if (list.Count == 0)
                {
                    txtPrice.Clear();
                    txtProductName.Clear();
                    txtStock.Clear();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        
        private void FrmSales_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            
            dataGridView1.DataSource = dto.Products;
            dataGridView1.Columns[0].HeaderText = "Product Name";
            dataGridView1.Columns[1].HeaderText = "Category Name";
            dataGridView1.Columns[2].HeaderText = "Stock Amount";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            //List<CustomerDetailDTO> dtoCustomer = new List<CustomerDetailDTO>();
            //dtoCustomer.Add(
            //        new CustomerDetailDTO()
            //        {
            //            ID = 0
            //            ,
            //            CustomerName = ""
            //        });
            //dtoCustomer.AddRange(dto.Customers);
            dataGridView2.DataSource = dto.Customers;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Customer Name";
            if(dto.Categories.Count > 0) 
                combofull=true;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerDetailDTO> list = dto.Customers;
                list = list.Where(x => x.CustomerName.Contains(txtCustomerName.Text)).ToList();
                dataGridView2.DataSource = list;
                if (list.Count == 0)
                    txtCustomerName.Clear();
            }
            catch(Exception ex)
            {
                //continue
            }
            
        }
        SalesDetailDTO detail= new SalesDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detail.StockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            txtProductName.Text = detail.ProductName;
            txtPrice.Text= detail.Price.ToString();
            txtStock.Text= detail.StockAmount.ToString();

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.CustomerName=dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.CustomerID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            //txtCustomerName.Text = detail.CustomerName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
                MessageBox.Show("please select a product from product table");
            else if (detail.CustomerID == 0)
                MessageBox.Show("please select a customer from customer table");
            else if (detail.StockAmount < Convert.ToInt32(txtAmount.Text))
                MessageBox.Show("You have enough product for sale");
            else
            {
                detail.SalesAmount= Convert.ToInt32(txtAmount.Text);
                detail.SaleDate= DateTime.Today;
                if (bll.Insert(detail))
                {
                    MessageBox.Show("Sale was added");
                    bll = new SalesBLL();
                    dto = bll.Select();
                    dataGridView1.DataSource = dto.Products;
                    dto.Customers = dto.Customers;
                    combofull = false;
                    cmbCategory.DataSource=dto.Categories;
                    if(dto.Products.Count > 0) 
                        combofull =true;
                    txtAmount.Clear();
                }

            }
        }
    }
}
