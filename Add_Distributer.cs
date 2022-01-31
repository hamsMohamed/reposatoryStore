using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Distributer : Form
    {
        public Add_Distributer()
        {
            InitializeComponent();
        }
        Distributers Distributers;
       // List<Distributers> distributersList = new List<Distributers>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Distributers LastIndex = null;
            Distributers = new Distributers();
            if (system.distributers.Count != 0)
            { LastIndex = system.distributers.Last(); }
            if (txtNameDistributer.Text == "" || txtCityDistributer.Text == "")
            {
                MessageBox.Show("Enter Supplier Data");
                return;
            }
            // suppliers.SupplierID = int.Parse(txtSupplierID.Text);
            Distributers.DistributerName = txtNameDistributer.Text;
            Distributers.DistributerPhone = int.Parse(txtPhoneDistributer.Text);
            Distributers.DistributerAddress = txtCityDistributer.Text;
            foreach (var item in system.distributers)
            {
                if (item.DistributerName.Equals(txtNameDistributer.Text))
                {
                    MessageBox.Show("Supplier is Exist");
                    txtNameDistributer.Text = "";
                    txtCityDistributer.Text = "";
                    return;
                }
            }
            if (LastIndex != null)
                Distributers.DistributerID = LastIndex.DistributerID + 1;
            system.distributers.Add(Distributers);
            gViewAddDistribuers.DataSource = null;
            gViewAddDistribuers.DataSource = system.distributers;
            txtNameDistributer.Text = "";
            txtCityDistributer.Text = "";
        }
       
        private void gViewAddDistribuers_SelectionChanged(object sender, EventArgs e)
        {
            if (gViewAddDistribuers.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in gViewAddDistribuers.SelectedRows)
                {
                    txtDistributerID.Text = row.Cells[0].Value.ToString();
                    txtNameDistributer.Text = row.Cells[1].Value.ToString();
                    txtPhoneDistributer.Text = row.Cells[2].Value.ToString();
                    txtCityDistributer.Text = row.Cells[3].Value.ToString();
                }
            }
        }
        
        private void gViewAddDistribuers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDistributerID.Text = gViewAddDistribuers.SelectedRows[0].Cells[0].Value.ToString();
                txtNameDistributer.Text = gViewAddDistribuers.SelectedRows[0].Cells[1].Value.ToString();
                txtPhoneDistributer.Text = gViewAddDistribuers.SelectedRows[0].Cells[2].Value.ToString();
                txtCityDistributer.Text = gViewAddDistribuers.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gViewAddDistribuers.SelectedRows.Count > 0)
            {
                int index = gViewAddDistribuers.CurrentCell.RowIndex;
                system.distributers[index].DistributerID = int.Parse(txtDistributerID.Text);
                system.distributers[index].DistributerName = txtNameDistributer.Text;
                system.distributers[index].DistributerPhone = int.Parse(txtPhoneDistributer.Text);
                system.distributers[index].DistributerAddress = txtCityDistributer.Text;
                gViewAddDistribuers.DataSource = null;
                gViewAddDistribuers.DataSource = system.distributers;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = gViewAddDistribuers.CurrentCell.RowIndex;
            system.distributers.Remove(system.distributers[index]);
            gViewAddDistribuers.DataSource = null;
            gViewAddDistribuers.DataSource = system.distributers;
        }

        private void gViewAddDistribuers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Distributer_Load(object sender, EventArgs e)
        {
            gViewAddDistribuers.DataSource = system.distributers;

        }
    }
}
