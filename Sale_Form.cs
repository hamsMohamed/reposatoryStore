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
    public partial class Sale_Form : Form
    {
        public Sale_Form()
        {
            InitializeComponent();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double old_price = Convert.ToDouble(txtPrice.Text); 
            double input= Convert.ToDouble(txtDiscount.Text);
            if (input > 0)
            {
               double result = old_price * input / 100;
            }
           
                
        }

        private void Form_Receipt_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
