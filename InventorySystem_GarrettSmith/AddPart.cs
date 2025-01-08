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
            //addPartMachComBox.Text = "Mach ID";
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Company Name";
            toggleLabel.Location = new Point(21, 356);
            //addPartMachComBox.Text = "Comp Nm";
        }

        //private bool MinMaxThrowException(string min, string max)
        //{
        //    try 
        //    {
        //        int minInt = Int32.Parse(min);
        //        int maxInt = Int32.Parse(max);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Try again. Enter a the maximum ");
        //        return true;
        //    }


        //    if (minInt == 0 || min is null)
        //    {
        //        MessageBox.Show("Try again. The minimum and  values cannot be 0.");
        //        return false;
        //    }
        //    if (minInt > maxInt)
        //    {
        //        MessageBox.Show("Try again. The minimum cannot be greater than the maximum.");
        //        return false;
        //    }
        //    return true;
        //}

        private void AddPartSave_Click(object sender, EventArgs e)
        {
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

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartInventoryValidation(object sender, EventArgs e)
        {
            // Validate Inventory is a integer
            if (!int.TryParse(addPartInventory.Text, out _))
            {
                MessageBox.Show("Enter a valid number for Inventory.");
                addPartInventory.Text = "";
                addPartInventory.Focus();
            }
            InventoryInRange();
        }

        private void EntryValidation(object sender, EventArgs e)
        {
            // Validate Inventory is an integer
            if (!int.TryParse(addPartInventory.Text, out _))
            {
                MessageBox.Show("Enter a valid number for Inventory.");
                addPartInventory.Text = "";
                addPartInventory.Focus();
            }

            // Validate Max is an integer
            if (!int.TryParse(addPartMax.Text, out _))
            {
                MessageBox.Show("Enter a valid number for Max.");
                addPartMax.Text = "";
                addPartMax.Focus();
            }

            // Validate Min is an integer
            if (!int.TryParse(addPartMin.Text, out _))
            {
                MessageBox.Show("Enter a valid number for Min.");
                addPartMin.Text = "";
                addPartMin.Focus();
            }
        }

        private void AddPartMaxValidation(object sender, EventArgs e)
        {
            // Validate Max is an integer
            if (!int.TryParse(addPartMax.Text, out _))
            {
                MessageBox.Show("Enter a valid number for Max.");
                addPartMax.Text = "";
                addPartMax.Focus();
            }
            // Validate Max is greater than Min
            if(addPartMax.TabIndex > addPartMin.TabIndex)
            {
                MaxMinEvaluation();
            }
        }

        private void AddPartMinValidation(object sender, EventArgs e)
        {
            // Validate Min is an integer
            if (!int.TryParse(addPartMin.Text, out _))
            {
                MessageBox.Show("Enter a valid number for Min.");
                addPartMin.Text = "";
                addPartMin.Focus();
            }

            // Validate Min is less than Max
            if (addPartMin.TabIndex > addPartMax.TabIndex)
            {
                MaxMinEvaluation();
            }
        }

        private void MaxMinEvaluation()
        {
            if (addPartMax.Text != "" && addPartMin.Text != "")
            {
                if (int.Parse(addPartMax.Text) < int.Parse(addPartMin.Text))
                {
                    MessageBox.Show("Max must be greater than Min.");
                    addPartMax.Text = "";
                    addPartMin.Text = "";
                }
            }
            InventoryInRange();
        }

        private void InventoryInRange()
        {
            if (addPartInventory.Text != "" && addPartMax.Text != "" && addPartMin.Text != "")
            {
                if (int.Parse(addPartInventory.Text) < int.Parse(addPartMin.Text) || int.Parse(addPartInventory.Text) > int.Parse(addPartMax.Text))
                {
                    MessageBox.Show("Inventory must be between Min and Max.");
                    addPartInventory.Focus();
                }
            }

        }


    }
}
