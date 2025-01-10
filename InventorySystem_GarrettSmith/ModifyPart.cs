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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystem_GarrettSmith
{
    public partial class ModifyPart : Form
    {
        //string partID;
        Inhouse inhousePart;
        Outsourced outsourcedPart;
        string currentPartName;
        string currentPartInventory;
        string currentPartPrice;
        string currentPartMin;
        string currentPartMax;
        string currentPartMachineID;
        string currentPartCompanyName;
        string currentPartType;

        string currentText;

        public ModifyPart(Inhouse part)
        {
            InitializeComponent();
            inhousePart = part;
            modifyPartID.Text = part.PartID.ToString();
            inhouseRadio.Checked = true;
            currentPartType = part.GetType().ToString();
            currentText = part.MachineID.ToString();

            modifyPartName.Text = currentPartName = part.Name;
            modifyPartInventory.Text = currentPartInventory = part.InStock.ToString();
            modifyPartPrice.Text = currentPartPrice = part.Price.ToString();
            modifyPartMax.Text = currentPartMax = part.Max.ToString();
            modifyPartMin.Text = currentPartMin = part.Min.ToString();
            modifyPartFlexText.Text = currentPartMachineID = part.MachineID.ToString();
        }

        public ModifyPart(Outsourced part)
        {
            InitializeComponent();
            outsourcedPart = part;
            modifyPartID.Text = part.PartID.ToString();
            currentText = part.CompanyName;
            outsourcedRadio.Checked = true;
            currentPartType = part.GetType().ToString();
            

            modifyPartName.Text = currentPartName = part.Name;
            modifyPartInventory.Text = currentPartInventory = part.InStock.ToString();
            modifyPartPrice.Text = currentPartPrice = part.Price.ToString();
            modifyPartMax.Text = currentPartMax = part.Max.ToString();
            modifyPartMin.Text = currentPartMin = part.Min.ToString();
            modifyPartFlexText.Text = currentPartCompanyName = part.CompanyName;
        }

        private void InhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Machine ID";
            toggleLabel.Location = new Point(55, 355);
            
            if(currentText != null)
            {
                if (!int.TryParse(modifyPartFlexText.Text, out _))
                {
                    modifyPartFlexText.Text = "";
                }
                else 
                {
                    modifyPartFlexText.Text = currentText;
                }
            }
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Company Name";
            toggleLabel.Location = new Point(21, 356);
            
            if (currentText != null)
            {
                if (int.TryParse(modifyPartFlexText.Text, out _))
                {
                    modifyPartFlexText.Text = "";
                }
                else
                {
                    modifyPartFlexText.Text = currentText;
                }
            }
        }

        private void ModifyPartSave_Click(object sender, EventArgs e)
        {
            if (int.Parse(modifyPartMin.Text) > int.Parse(modifyPartMax.Text))
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                return;
            }
           
            if (int.Parse(modifyPartMin.Text) > int.Parse(modifyPartMax.Text))
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                modifyPartMax.Text = currentPartMax;
                modifyPartMin.Text = currentPartMin;
                return;
            }
            if (int.Parse(modifyPartInventory.Text) > int.Parse(modifyPartMax.Text) || int.Parse(modifyPartInventory.Text) < int.Parse(modifyPartMin.Text))
            {
                MessageBox.Show("Error: Inventory stocked must be between Max and Min.");
                modifyPartInventory.Text = currentPartInventory;
                return;
            }
            if (modifyPartFlexText.Text == "")
            {
                MessageBox.Show("Error: Machine ID or Company Name cannot be empty.");
                return;
            }
            if (inhouseRadio.Checked == true && !int.TryParse(modifyPartFlexText.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Machine ID.");
                modifyPartFlexText.Text = currentPartMachineID;
                return;
            }
            if (outsourcedRadio.Checked == true && int.TryParse(modifyPartFlexText.Text, out _))
            {
                MessageBox.Show("Error: Enter a company name not a number.");
                modifyPartFlexText.Text = currentPartCompanyName;
                return;
            }

            if (inhouseRadio.Checked)
            {
                inhousePart = new Inhouse(
                    int.Parse(modifyPartID.Text),
                    modifyPartName.Text,
                    decimal.Parse(modifyPartPrice.Text),
                    int.Parse(modifyPartInventory.Text),
                    int.Parse(modifyPartMin.Text),
                    int.Parse(modifyPartMax.Text),
                    int.Parse(modifyPartFlexText.Text)
                    );

                Inventory.UpdatePart(int.Parse(modifyPartID.Text), inhousePart);
            }
            else if (outsourcedRadio.Checked)
            {
                outsourcedPart = new Outsourced(
                    int.Parse(modifyPartID.Text),
                    modifyPartName.Text,
                    decimal.Parse(modifyPartPrice.Text),
                    int.Parse(modifyPartInventory.Text),
                    int.Parse(modifyPartMin.Text),
                    int.Parse(modifyPartMax.Text),
                    modifyPartFlexText.Text
                    );

                Inventory.UpdatePart(int.Parse(modifyPartID.Text), outsourcedPart);
            }
            this.Close();
        }

        private void ModifyPartInventoryValidation(object sender, EventArgs e)
        {
            // Validate Inventory is a integer
            if (!int.TryParse(modifyPartInventory.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Inventory.");
                modifyPartInventory.Text = currentPartInventory;
                modifyPartInventory.Focus();
            }
        }

        private void ModifyPartPriceValidation(object sender, EventArgs e)
        {
            // Validate Max is an integer
            if (!decimal.TryParse(modifyPartPrice.Text, out _))
            {
                MessageBox.Show("Error: Price must be a decimal value.");
                modifyPartPrice.Text = currentPartPrice;
                modifyPartPrice.Focus();
            }
        }

        private void ModifyPartMaxValidation(object sender, EventArgs e)
        {
            // Validate Max is an integer
            if (!int.TryParse(modifyPartMax.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Max.");
                modifyPartMax.Text = currentPartMax;
                modifyPartMax.Focus();
            }
        }

        private void ModifyPartMinValidation(object sender, EventArgs e)
        {
            // Validate Min is an integer
            if (!int.TryParse(modifyPartMin.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Min.");
                modifyPartMin.Text = currentPartMin;
                modifyPartMin.Focus();
            }
        }

        private void ModifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
