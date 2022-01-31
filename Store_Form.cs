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
    public partial class Store_Form : Form
    {
        public Store_Form()
        {
            InitializeComponent();
        }
        //List<Store>stores=new List<Store>();
        Store stre = new Store();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addCategoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Category Cateory =new Add_Category();
            Cateory.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show
            Add_Store add = new Add_Store();
            add.ShowDialog();


            //  guna2ComboBox5.Items.Add(add.storeNames);
            guna2ComboBox5.DataSource = add.storeNames;
            guna2ComboBox5.SelectedIndex = -1;
           


        }

        private void Store_Form_Load(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Gray;
                }
            }
            cmbCategory.DataSource = system.category;

        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product product = new Add_Product();
            product.ShowDialog();
        }

        private void addSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Supplier supplier = new Add_Supplier();
            supplier.ShowDialog();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Distributer distributer = new Add_Distributer();
            distributer.ShowDialog();
        }

        private void gviewDataStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
