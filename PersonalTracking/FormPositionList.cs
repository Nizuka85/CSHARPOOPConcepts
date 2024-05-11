using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FormPositionList : Form
    {
        public FormPositionList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormPosition form = new FormPosition();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            FormPosition form = new FormPosition();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
