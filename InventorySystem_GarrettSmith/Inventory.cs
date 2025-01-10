using InventorySystem_GarrettSmith.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
            Product demoProduct1 = new Product(1, "HP Omen 35L", 10, 1399.99m, 5, 20);
            Product demoProduct2 = new Product(2, "Alienware R16", 5, 2199.99m, 2, 10);
            Product demoProduct3 = new Product(3, "MSI Aegis Z2", 3, 1399.99m, 1, 25);
            Product demoProduct4 = new Product(4, "MSI Codex R2", 7, 999.99m, 5, 30);

            Products.Add(demoProduct1);
            Products.Add(demoProduct2);
            Products.Add(demoProduct3);
            Products.Add(demoProduct4);

            Part demoPart1 = new Outsourced(1, "GeForce RTX 4070", 549.99m, 8, 5, 15, "Nvidia");
            Part demoPart2 = new Outsourced(2, "GeForce RTX 4060 Ti", 449.99m, 13, 5, 15, "Nvidia");
            Part demoPart3 = new Outsourced(3, "Ryzen 7 8700G", 279.00m, 10, 5, 20, "AMD");
            Part demoPart4 = new Outsourced(4, "Intel Core i5 13400F", 151.21m, 20, 10, 50, "Intel");
            Part demoPart5 = new Outsourced(5, "Intel Core i7-14700KF", 399.99m, 7, 10, 25, "Intel");
            Part demoPart6 = new Outsourced(6, "Vengeance 8GB", 27.99m, 40, 25, 200, "Corsair");
            Part demoPart7 = new Outsourced(7, "Vengeance 16GB", 54.99m, 60, 25, 200, "Corsair");
            Part demoPart8 = new Inhouse(8, "MAG X670E", 99.99m, 30, 25, 200, 1);
            Part demoPart9 = new Inhouse(9, "MAG B550M Bazooka", 79.99m, 20, 15, 100, 2);
            Part demoPart10 = new Inhouse(10, "MAG B550 Tomahawk", 129.99m, 15, 10, 50, 3);

            AllParts.Add(demoPart1);
            AllParts.Add(demoPart2);
            AllParts.Add(demoPart3);
            AllParts.Add(demoPart4);
            AllParts.Add(demoPart5);
            AllParts.Add(demoPart6);
            AllParts.Add(demoPart7);
            AllParts.Add(demoPart8);
            AllParts.Add(demoPart9);
            AllParts.Add(demoPart10);

            // demoProduct1 AssociatedParts
            demoProduct1.AddAssociatedPart(demoPart2);
            demoProduct1.AddAssociatedPart(demoPart3);
            demoProduct1.AddAssociatedPart(demoPart6);
            demoProduct1.AddAssociatedPart(demoPart10);

            // demoProduct2 AssociatedParts
            demoProduct1.AddAssociatedPart(demoPart5);
            demoProduct1.AddAssociatedPart(demoPart7);
            demoProduct1.AddAssociatedPart(demoPart8);

            // demoProduct3 AssociatedParts
            demoProduct1.AddAssociatedPart(demoPart1);
            demoProduct1.AddAssociatedPart(demoPart3);
            demoProduct1.AddAssociatedPart(demoPart7);
            demoProduct1.AddAssociatedPart(demoPart8);

            // demoProduct4 AssociatedParts
            demoProduct1.AddAssociatedPart(demoPart2);
            demoProduct1.AddAssociatedPart(demoPart4);
            demoProduct1.AddAssociatedPart(demoPart7);
            demoProduct1.AddAssociatedPart(demoPart8);
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
                }
            }
        }

        //+ addPart(Part) : void
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        //+ deletePart(Part) : bool
        public static bool DeletePart(Part part)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == part.PartID)
                {
                    AllParts.Remove(p);
                    return true;
                }
            }
            return false;
        }
        //+ lookupPart(int) : Part
        public Part LookupPart(int partNumber)
        {
            Part result = null;
            foreach (Part part in Inventory.AllParts)
            {
                if (part.PartID == partNumber)
                {
                    result = part;
                }
            }
            return result;
        }

        //+ updatePart(int, Part) : void
        public static void UpdatePart(int PartID, Inhouse part)
        {
            int index = PartID - 1;
            if (part.PartID == PartID)
            {
                AllParts[index] = part;
            }
        }

        public static void UpdatePart(int PartID, Outsourced part)
        {
            int index = PartID - 1;
            if (part.PartID == AllParts[index].PartID)
            {
                AllParts[index] = part;
            }
        }
    }
}
