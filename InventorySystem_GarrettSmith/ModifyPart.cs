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
        Inhouse inhousePart;
        Outsourced outsourcedPart;
        string currentPartName;
        string currentPartInventory;
        string currentPartPrice;
        string currentPartMin;
        string currentPartMax;
        string currentPartMachineID;
        string currentPartCompanyName;

        string currentText;

        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(Inhouse part)
        {
            InitializeComponent();

            modifyPartID.Text = part.PartID.ToString();
            modifyPartName.Text = currentPartName = part.Name;
            modifyPartInventory.Text = currentPartInventory = part.InStock.ToString();
            modifyPartPrice.Text = currentPartPrice = part.Price.ToString();
            modifyPartMax.Text = currentPartMax = part.Max.ToString();
            modifyPartMin.Text = currentPartMin = part.Min.ToString();
            modifyPartFlexText.Text = currentPartMachineID = part.MachineID.ToString();

            currentText = part.MachineID.ToString();
            inhouseRadio.Checked = true;
            inhousePart = part;
        }

        public ModifyPart(Outsourced part)
        {
            InitializeComponent();

            modifyPartID.Text = part.PartID.ToString();
            modifyPartName.Text = currentPartName = part.Name;
            modifyPartInventory.Text = currentPartInventory = part.InStock.ToString();
            modifyPartPrice.Text = currentPartPrice = part.Price.ToString();
            modifyPartMax.Text = currentPartMax = part.Max.ToString();
            modifyPartMin.Text = currentPartMin = part.Min.ToString();
            modifyPartFlexText.Text = currentPartCompanyName = part.CompanyName;

            currentText = part.CompanyName;
            outsourcedRadio.Checked = true;
            outsourcedPart = part;
        }

        private void InhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Machine ID";
            toggleLabel.Location = new Point(55, 355);

            if (currentText != null)
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
            CustomExceptions customExceptions = new CustomExceptions();
            if (customExceptions.ModifyPartExceptions(
                this,
                currentPartName,
                currentPartInventory,
                currentPartPrice,
                currentPartMin,
                currentPartMax,
                currentPartMachineID,
                currentPartCompanyName))
            {
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
        }

        private void ModifyPartNameValidation(object sender, EventArgs e)
        {
            foreach (Part part in Inventory.AllParts)
            {
                if (part.Name.Equals(modifyPartName.Text) && modifyPartName.Text != currentPartName)
                {
                    MessageBox.Show("ERROR: A part already exists with that name.");
                }
            }
        }

        private void ModifyPartMachineIDValidation(object sender, EventArgs e)
        {
            if (inhouseRadio.Checked)
            {
                if (int.TryParse(modifyPartFlexText.Text, out _) && Inventory.MachineIDs.ContainsValue(int.Parse(modifyPartFlexText.Text)))
                {
                    MessageBox.Show("ERROR: A part already exists with that machine ID.");
                }
            }
        }
        private void ModifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}