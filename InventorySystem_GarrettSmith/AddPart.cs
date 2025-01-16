using InventorySystem_GarrettSmith.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InventorySystem_GarrettSmith
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void InhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Machine ID";
            toggleLabel.Location = new Point(55, 355);
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Company Name";
            toggleLabel.Location = new Point(21, 356);
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            CustomExceptions customExceptions = new CustomExceptions();
            if (customExceptions.AddPartExceptions(this))
            {
                int id = Inventory.partsCount + 1;
                if (inhouseRadio.Checked)
                {
                    Inventory.AddPart(new Inhouse(
                        id,
                        addPartName.Text,
                        decimal.Parse(addPartPrice.Text),
                        int.Parse(addPartInventory.Text),
                        int.Parse(addPartMin.Text),
                        int.Parse(addPartMax.Text),
                        int.Parse(addPartFlexText.Text)
                        ));
                    Inventory.MachineIDs.Add(id, int.Parse(addPartFlexText.Text));
                }
                else
                {
                    Inventory.AddPart(new Outsourced(
                        id,
                        addPartName.Text,
                        decimal.Parse(addPartPrice.Text),
                        int.Parse(addPartInventory.Text),
                        int.Parse(addPartMin.Text),
                        int.Parse(addPartMax.Text),
                        addPartFlexText.Text
                    ));
                }
                Inventory.partsCount++;
                this.Close();
            }
        }

        private void AddPartNameValidation(object sender, EventArgs e)
        {
            foreach (Part part in Inventory.AllParts)
            {
                if (part.Name.Equals(addPartName.Text))
                {
                    MessageBox.Show("Error: A part already exists with that name.");
                }
            }
        }

        private void AddPartMachineIDValidation(object sender, EventArgs e)
        {
            if (inhouseRadio.Checked)
            {
                if (int.TryParse(addPartFlexText.Text, out _) && Inventory.MachineIDs.ContainsValue(int.Parse(addPartFlexText.Text)))
                {
                    MessageBox.Show("Error: A part already exists with that machine ID.");
                }
            }
        }

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
