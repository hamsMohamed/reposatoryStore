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
    public partial class Add_Supplier : Form
    {
        Supplier supplier;
        //List<Supplier> suppliersList = new List<Supplier>();

        public Add_Supplier()
        {
            InitializeComponent();
        }
        public void SystemSupplierEqualList()
        {
            
        }
        private void txtPhoneDistributer_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier LastIndex = null;
            supplier = new Supplier();
            if (system.suppliers.Count != 0)
            { LastIndex = system.suppliers.Last(); }
                if (txtNameSupplier.Text == "" || txtCitySupplier.Text == "")
            { 
                    MessageBox.Show("Enter Supplier Data");
                return;
            }
                
           // suppliers.SupplierID = int.Parse(txtSupplierID.Text);
            supplier.SupplierName = txtNameSupplier.Text;
            supplier.SupplierPhone = int.Parse(txtPhoneSupplier.Text);
            supplier.City = txtCitySupplier.Text;
            foreach (Supplier item in system.suppliers)
            {
                if (item.SupplierName.Equals(txtNameSupplier.Text))
                {
                    MessageBox.Show("Supplier is Exist");
                    txtNameSupplier.Text = "";
                    txtCitySupplier.Text = "";
                    return;
                }
            }
            if (LastIndex != null)
                supplier.SupplierID = LastIndex.SupplierID + 1;
            system.suppliers.Add(supplier);
            gViewAddSupplier.DataSource = null;
            gViewAddSupplier.DataSource = system.suppliers;
            txtNameSupplier.Text = "";
            txtCitySupplier.Text = "";

        }

        private void gViewAddSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (gViewAddSupplier.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in gViewAddSupplier.SelectedRows)
                {
                      txtSupplierID.Text = row.Cells[0].Value.ToString();
                     txtNameSupplier.Text = row.Cells[1].Value.ToString();
                     txtPhoneSupplier.Text = row.Cells[2].Value.ToString();
                    txtCitySupplier.Text = row.Cells[3].Value.ToString();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gViewAddSupplier.CurrentRow != null)
            {

                int index = gViewAddSupplier.CurrentCell.RowIndex;
                system.suppliers[index].SupplierID = Convert.ToInt32(txtSupplierID.Text);
                system.suppliers[index].SupplierName = txtNameSupplier.Text;
                system.suppliers[index].SupplierPhone = Convert.ToInt32(txtPhoneSupplier.Text);
                system.suppliers[index].City = txtCitySupplier.Text;
                system.suppliers.Append(system.suppliers[index]);
                gViewAddSupplier.DataSource = null;
                gViewAddSupplier.DataSource = system.suppliers;
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = gViewAddSupplier.CurrentCell.RowIndex;
            system.suppliers.Remove(system.suppliers[index]);
            gViewAddSupplier.DataSource = null;
            gViewAddSupplier.DataSource = system.suppliers;
        }

        private void gViewAddSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Supplier_Load(object sender, EventArgs e)
        {
            gViewAddSupplier.DataSource = system.suppliers;

        }
    }
}
