using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;

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
            FillGrid();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("Please select a position from table");
            else
            {
                FormPosition form = new FormPosition();
                form.isupdate = true;
                form.detail = detail;
                this.Hide();
                form.ShowDialog();
                this.Visible = true;
                FillGrid();
            }
            
        }
        List<PositionDTO> positionList = new List<PositionDTO>();
        void FillGrid()
        {
            positionList = PositionBLL.GetPositions();
            dataGridView1.DataSource = positionList;
        }
        PositionDTO detail = new PositionDTO();
        private void FormPositionList_Load(object sender, EventArgs e)
        {
            FillGrid();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[3].HeaderText = "Position Name";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.DepartmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.OldDepartmenteID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }
    }
}
