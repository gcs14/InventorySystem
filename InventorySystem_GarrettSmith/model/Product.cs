using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_GarrettSmith.model
{
    internal class Product
    {
        public static List<Product> Products = new List<Product>();
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Create a constructor for the Product class


        // Replace this with method
        static Product()
        {
            Products.Add(
                new Product
                {
                    ProductID = 1,
                    Name = "Product 1",
                    Price = 10.85M,
                    InStock = 4,
                    Min = 1,
                    Max = 10
                }
            );

            Products.Add(
                new Product
                {
                    ProductID = 2,
                    Name = "Product 2",
                    Price = 26.35M,
                    InStock = 40,
                    Min = 20,
                    Max = 100
                }
            );
        }
    }
}
