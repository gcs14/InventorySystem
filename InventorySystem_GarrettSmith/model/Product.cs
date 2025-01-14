using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_GarrettSmith.model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
        }
        public Product(int productID, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public Product(BindingList<Part> associatedParts, int productID, string name, int inStock, decimal price, int min, int max)
        {
            AssociatedParts = associatedParts;
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }



        //+ addAssociatedPart(Part) : void
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        //+ removeAssociatedPart(int) : bool
        public bool RemoveAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        //+ lookupAssociatedPart(int) : Part
        public Part lookupAssociatedPart(int partID)
        {
            Part foundPart = null;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    foundPart = part;
                }
            }
            return foundPart;
        }
    }
}
