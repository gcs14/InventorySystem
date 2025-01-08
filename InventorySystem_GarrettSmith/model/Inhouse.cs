using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_GarrettSmith.model
{
    internal class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse()
        {
        }

        public Inhouse(string name, decimal price, int inStock, int min, int max, int machineID)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
