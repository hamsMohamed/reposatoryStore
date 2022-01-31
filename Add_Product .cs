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
    public partial class Add_Product : Form
    {

        // Add_Category add_Category = new Add_Category();
        //public  List<Category> CategoriesList = new List<Category>();
        //public List<Products> productsList = new List<Products>();
        Products Product;
        public Add_Product()
        {
            
            InitializeComponent();
            cboxCategory.DataSource = system.category;
            cboxCategory.DisplayMember = "CategoryName";

        }
        

        private void Add_Product_Load(object sender, EventArgs e)
        {

                
            gviewShowProduct.DataSource = system.products;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product = new Products();
            Product.ProductName = txtNameProduct.Text;
            Product.ProductDescription = txtPDescription.Text;
            Product.ProductPrice = Convert.ToDouble(txtPPrice.Text);
            Product.ProductCategory = cboxCategory.Text;
            system.products.Add(Product);
            gviewShowProduct.DataSource = null;
            gviewShowProduct.DataSource = system.products;

        }
        private void gviewShowProduct_SelectionChanged(object sender, EventArgs e)
        {
            
            if (gviewShowProduct.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in gviewShowProduct.SelectedRows)
                {
                    txtNameProduct.Text = row.Cells[0].Value.ToString();
                    txtPDescription.Text = row.Cells[1].Value.ToString();                   
                    txtPPrice.Text = row.Cells[2].Value.ToString();
                    cboxCategory.Text = row.Cells[3].Value.ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gviewShowProduct.SelectedRows.Count > 0)
            {
                int index = gviewShowProduct.CurrentCell.RowIndex;
                system.products[index].ProductName = txtNameProduct.Text;
                system.products[index].ProductDescription = txtPDescription.Text;
                system.products[index].ProductPrice = Convert.ToDouble(txtPPrice.Text);
                system.products[index].ProductCategory = cboxCategory.Text;
                gviewShowProduct.DataSource = null;
                gviewShowProduct.DataSource = system.products;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = gviewShowProduct.CurrentCell.RowIndex;
            system.products.Remove(system.products[index]);
            gviewShowProduct.DataSource = null;
            gviewShowProduct.DataSource = system.products;
        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.ProductCategory = cboxCategory.Text;    
        }
    }
}
