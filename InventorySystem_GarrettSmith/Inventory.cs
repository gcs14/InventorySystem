using InventorySystem_GarrettSmith.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_GarrettSmith
{
    internal class Inventory
    {
        //+ <<prop>> Products: BindingList<Product>
        //+ <<prop>> AllParts: BindingList<Part>

        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void GenerateDemoData()
        {
            Product demoProduct1 = new Product(1, "Product 1", 5, 12.30m, 1, 50);
            Product demoProduct2 = new Product(2, "Product 2", 299, 8.85m, 100, 300);
            Product demoProduct3 = new Product(3, "Product 3", 1, 5.12m, 1, 5);
            Product demoProduct4 = new Product(4, "Product 4", 30, 3.50m, 25, 50);

            Products.Add(demoProduct1);
            Products.Add(demoProduct2);
            Products.Add(demoProduct3);
            Products.Add(demoProduct4);
        }

        //+ addProduct(Product) : void
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //+ removeProduct(int) : bool
        public bool RemoveProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        //+ lookupProduct(int) : Product
        public Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        //+ updateProduct(int, Product) : void
        public void UpdateProduct(int ProductID, Product product)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == ProductID)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.InStock = product.InStock;
                    p.Min = product.Min;
                    p.Max = product.Max;
                    //p.AssociatedParts = product.AssociatedParts;
                }
            }
        }

            //+ addPart(Part) : void
            //+ deletePart(Part) : bool
            //+ lookupPart(int) : Part
            //+ updatePart(int, Part) : void
        }
}
