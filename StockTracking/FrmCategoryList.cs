using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracking
{
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
