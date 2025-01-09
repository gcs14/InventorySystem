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
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void inhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Machine ID";
            toggleLabel.Location = new Point(55, 355);
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Company Name";
            toggleLabel.Location = new Point(21, 356);
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            if (int.Parse(addPartMin.Text) > int.Parse(addPartMax.Text))
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                return;
            }
            if (int.Parse(addPartInventory.Text) > int.Parse(addPartMax.Text) || int.Parse(addPartInventory.Text) < int.Parse(addPartMin.Text))
            {
                MessageBox.Show("Error: Inventory stocked must be between Max and Min.");
                return;
            }
            if (inhouseRadio.Checked == true && !int.TryParse(textBox7.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Machine ID.");
                textBox7.Text = "";
                return;
            }
            if (outsourcedRadio.Checked == true && int.TryParse(textBox7.Text, out _))
            {
                MessageBox.Show("Error: Enter a company name not a number.");
                textBox7.Text = "";
                return;
            }


            if (inhouseRadio.Checked)
            {
                Inventory.AddPart(new Inhouse(
                    Inventory.AllParts.Count + 1,
                    addPartName.Text,
                    Convert.ToDecimal(addPartPrice.Text),
                    Convert.ToInt32(addPartInventory.Text),
                    Convert.ToInt32(addPartMin.Text),
                    Convert.ToInt32(addPartMax.Text),
                    Convert.ToInt32(textBox7.Text)
                    ));
            }
            else
            {
                Inventory.AddPart(new Outsourced(
                    Inventory.AllParts.Count + 1,
                    addPartName.Text,
                    Convert.ToDecimal(addPartPrice.Text),
                    Convert.ToInt32(addPartInventory.Text),
                    Convert.ToInt32(addPartMin.Text),
                    Convert.ToInt32(addPartMax.Text),
                    textBox7.Text
                ));
            }
            this.Close();
        }

        private void AddPartInventoryValidation(object sender, EventArgs e)
        {
            // Validate Inventory is a integer
            if (!int.TryParse(addPartInventory.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Inventory.");
                addPartInventory.Text = "";
                addPartInventory.Focus();
            }
        }

        private void AddPartPriceValidation(object sender, EventArgs e)
        {
            // Validate Max is an integer
            if (!decimal.TryParse(addPartPrice.Text, out _))
            {
                MessageBox.Show("Error: Price must be a decimal value.");
                addPartPrice.Text = "";
                addPartPrice.Focus();
            }
        }

        private void AddPartMaxValidation(object sender, EventArgs e)
        {
            // Validate Max is an integer
            if (!int.TryParse(addPartMax.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Max.");
                addPartMax.Text = "";
                addPartMax.Focus();
            }
        }

        private void AddPartMinValidation(object sender, EventArgs e)
        {
            // Validate Min is an integer
            if (!int.TryParse(addPartMin.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Min.");
                addPartMin.Text = "";
                addPartMin.Focus();
            }
        }

        private void AddPartMachineIDValidation(object sender, EventArgs e)
        {
            //// Validate Min is an integer
            //if (!int.TryParse(addPartMin.Text, out _) && inhouseRadio.Checked == true)
            //{
            //    MessageBox.Show("Error: Enter a valid number for Machine ID.");
            //    textBox7.Text = "";
            //    textBox7.Focus();
            //}
        }

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
