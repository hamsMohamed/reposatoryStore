using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class system
    {
        public static List<Store> store = new List<Store>();
        public static List<Category> category = new List<Category>();
        public static List<Products> products = new List<Products>();
        public static List<Supplier> suppliers = new List<Supplier>();
        public static List<Distributers>distributers  = new List<Distributers>();
        public static int counter {
            get
            {
                return counter;
            }
            set
            {
                counter = 0;
            }
        }

    }
}
