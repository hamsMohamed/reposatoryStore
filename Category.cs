using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Category
    {
        
        public int ID {get; set; } //LIKE primary key
        public string CategoryName { get; set; }
        public string CategoryDescription{ get; set; }
        List<Products> products;

        public Category()
        {   
           // products = new List<Products>();
           ID =1 ;
        }
    }

}
