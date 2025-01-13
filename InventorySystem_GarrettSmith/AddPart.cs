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
            if (AddPartExceptions())
            {
                if (inhouseRadio.Checked)
                {
                    Inventory.AddPart(new Inhouse(
                        Inventory.AllParts.Count + 1,
                        addPartName.Text,
                        decimal.Parse(addPartPrice.Text),
                        int.Parse(addPartInventory.Text),
                        int.Parse(addPartMin.Text),
                        int.Parse(addPartMax.Text),
                        int.Parse(addPartFlexText.Text)
                        ));
                }
                else
                {
                    Inventory.AddPart(new Outsourced(
                        Inventory.AllParts.Count + 1,
                        addPartName.Text,
                        decimal.Parse(addPartPrice.Text),
                        int.Parse(addPartInventory.Text),
                        int.Parse(addPartMin.Text),
                        int.Parse(addPartMax.Text),
                        addPartFlexText.Text
                    ));
                }
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
            foreach (Inhouse inhousePart in Inventory.AllParts.Cast<Inhouse>())
            {
                if (inhousePart.MachineID.Equals(addPartFlexText.Text))
                {
                    MessageBox.Show("Error: A part already exists with that machine ID.");
                }
            }
        }

        private bool AddPartExceptions()
        {
            if (addPartName.Text == "")
            {
                MessageBox.Show("Error: Enter a valid part name.");
                addPartName.Text = "";
                addPartName.Focus();
                return false;
            }
            if (addPartInventory.Text == "" || !int.TryParse(addPartInventory.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Inventory.");
                addPartInventory.Text = "";
                addPartInventory.Focus();
                return false;
            }
            if (addPartPrice.Text == "" || !decimal.TryParse(addPartPrice.Text, out _))
            {
                MessageBox.Show("Error: Price must be a decimal value.");
                addPartPrice.Text = "";
                addPartPrice.Focus();
                return false;
            }
            if (addPartMax.Text == "" || !int.TryParse(addPartMax.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Max.");
                addPartMax.Text = "";
                addPartMax.Focus();
                return false;
            }
            if (addPartMin.Text == "" || !int.TryParse(addPartMin.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Min.");
                addPartMin.Text = "";
                addPartMin.Focus();
                return false;
            }
            if (int.Parse(addPartMin.Text) > int.Parse(addPartMax.Text))
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                return false;
            }
            if (int.Parse(addPartInventory.Text) > int.Parse(addPartMax.Text) || int.Parse(addPartInventory.Text) < int.Parse(addPartMin.Text))
            {
                MessageBox.Show("Error: Inventory stocked must be between Max and Min.");
                return false;
            }
            if (addPartFlexText.Text == "")
            {
                MessageBox.Show("Error: Machine ID or Company Name cannot be empty.");
                return false;
            }
            if (inhouseRadio.Checked == true && !int.TryParse(addPartFlexText.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Machine ID.");
                addPartFlexText.Text = "";
                return false;
            }
            if (outsourcedRadio.Checked == true && int.TryParse(addPartFlexText.Text, out _))
            {
                MessageBox.Show("Error: Enter a company name not a number.");
                addPartFlexText.Text = "";
                return false;
            }
            return true;
        }

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
