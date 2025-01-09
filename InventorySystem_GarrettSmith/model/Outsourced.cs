using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_GarrettSmith.model
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced()
        {
        }

        public Outsourced(string name, decimal price, int inStock, int min, int max, string companyName)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
