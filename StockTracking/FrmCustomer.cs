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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CustomerBLL bll= new CustomerBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "")
                MessageBox.Show("Customer Name Is Emty");
            else
            {
                CustomerDetailDTO customer= new CustomerDetailDTO();
                customer.CustomerName = txtCustomerName.Text;
                if(bll.Insert(customer) )
                {
                    MessageBox.Show("Customer was added");
                    txtCustomerName.Clear();
                }
            }
        }
    }
}
