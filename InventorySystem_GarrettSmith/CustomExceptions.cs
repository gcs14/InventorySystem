using InventorySystem_GarrettSmith.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_GarrettSmith
{
    internal class CustomExceptions
    {
        public bool AddPartExceptions(AddPart addPart)
        {
            if (addPart.addPartName.Text == "" || addPart.addPartName is null)
            {
                MessageBox.Show("ERROR: Enter a valid part name.");
                addPart.addPartName.Text = "";
                addPart.addPartName.Focus();
                return false;
            }
            if (int.TryParse(addPart.addPartName.Text, out _))
            {
                MessageBox.Show("ERROR: Part name cannot be a number.");
                return false;
            }
            if (addPart.addPartInventory.Text == "" || !int.TryParse(addPart.addPartInventory.Text, out int inv) || inv < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Inventory.");
                addPart.addPartInventory.Text = "";
                addPart.addPartInventory.Focus();
                return false;
            }
            if (addPart.addPartPrice.Text == "" || !decimal.TryParse(addPart.addPartPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("ERROR: Price must be a positive decimal value.");
                addPart.addPartPrice.Text = "";
                addPart.addPartPrice.Focus();
                return false;
            }
            if (addPart.addPartMax.Text == "" || !int.TryParse(addPart.addPartMax.Text, out int max) || max < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Max.");
                addPart.addPartMax.Text = "";
                addPart.addPartMax.Focus();
                return false;
            }
            if (addPart.addPartMin.Text == "" || !int.TryParse(addPart.addPartMin.Text, out int min) || min < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Min.");
                addPart.addPartMin.Text = "";
                addPart.addPartMin.Focus();
                return false;
            }
            if (int.Parse(addPart.addPartMin.Text) > int.Parse(addPart.addPartMax.Text))
            {
                MessageBox.Show("ERROR: Max must be greater than Min.");
                return false;
            }
            if (int.Parse(addPart.addPartInventory.Text) > int.Parse(addPart.addPartMax.Text) || int.Parse(addPart.addPartInventory.Text) < int.Parse(addPart.addPartMin.Text))
            {
                MessageBox.Show("ERROR: Inventory stocked must be between Max and Min.");
                return false;
            }
            if (addPart.addPartFlexText.Text == "")
            {
                MessageBox.Show("ERROR: Machine ID or Company Name cannot be empty.");
                return false;
            }
            if (addPart.inhouseRadio.Checked == true && !int.TryParse(addPart.addPartFlexText.Text, out _))
            {
                MessageBox.Show("ERROR: Enter a valid number for Machine ID.");
                addPart.addPartFlexText.Text = "";
                return false;
            }
            if (addPart.outsourcedRadio.Checked == true && int.TryParse(addPart.addPartFlexText.Text, out _))
            {
                MessageBox.Show("ERROR: Enter a company name not a number.");
                addPart.addPartFlexText.Text = "";
                return false;
            }
            return true;
        }

        public bool ModifyPartExceptions(
            ModifyPart modifyPart,
            string currentPartName,
            string currentPartInventory,
            string currentPartPrice,
            string currentPartMin,
            string currentPartMax,
            string currentPartMachineID,
            string currentPartCompanyName)
        {
            if (modifyPart.modifyPartName.Text == "" || modifyPart.modifyPartName is null)
            {
                MessageBox.Show("ERROR: Enter a valid part name.");
                modifyPart.modifyPartName.Text = currentPartName;
                modifyPart.modifyPartName.Focus();
                return false;
            }
            if (int.TryParse(modifyPart.modifyPartName.Text, out _))
            {
                MessageBox.Show("ERROR: Part name cannot be a number.");
                return false;
            }
            if (modifyPart.modifyPartInventory.Text == "" || !int.TryParse(modifyPart.modifyPartInventory.Text, out int inv) || inv < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Inventory.");
                modifyPart.modifyPartInventory.Text = currentPartInventory;
                modifyPart.modifyPartInventory.Focus();
                return false;
            }
            if (modifyPart.modifyPartPrice.Text == "" || !decimal.TryParse(modifyPart.modifyPartPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("ERROR: Price must be a positive decimal value.");
                modifyPart.modifyPartPrice.Text = currentPartPrice;
                modifyPart.modifyPartPrice.Focus();
                return false;
            }
            if (modifyPart.modifyPartMax.Text == "" || !int.TryParse(modifyPart.modifyPartMax.Text, out int max) || max < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Max.");
                modifyPart.modifyPartMax.Text = currentPartMax;
                modifyPart.modifyPartMax.Focus();
                return false;
            }
            if (modifyPart.modifyPartMin.Text == "" || !int.TryParse(modifyPart.modifyPartMin.Text, out int min) || min < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Min.");
                modifyPart.modifyPartMin.Text = currentPartMin;
                modifyPart.modifyPartMin.Focus();
                return false;
            }
            if (int.Parse(modifyPart.modifyPartMin.Text) > int.Parse(modifyPart.modifyPartMax.Text))
            {
                MessageBox.Show("ERROR: Max must be greater than Min.");
                modifyPart.modifyPartMax.Text = currentPartMax;
                modifyPart.modifyPartMin.Text = currentPartMin;
                return false;
            }
            if (int.Parse(modifyPart.modifyPartInventory.Text) > int.Parse(modifyPart.modifyPartMax.Text) || int.Parse(modifyPart.modifyPartInventory.Text) < int.Parse(modifyPart.modifyPartMin.Text))
            {
                MessageBox.Show("ERROR: Inventory stocked must be between Max and Min.");
                modifyPart.modifyPartInventory.Text = currentPartInventory;
                return false;
            }
            if (modifyPart.modifyPartFlexText.Text == "")
            {
                MessageBox.Show("ERROR: Machine ID or Company Name cannot be empty.");
                modifyPart.modifyPartFlexText.Text = "";
                return false;
            }
            if (modifyPart.inhouseRadio.Checked == true && !int.TryParse(modifyPart.modifyPartFlexText.Text, out _))
            {
                MessageBox.Show("ERROR: Enter a valid number for Machine ID.");
                modifyPart.modifyPartFlexText.Text = currentPartMachineID;
                return false;
            }
            if (modifyPart.outsourcedRadio.Checked == true && int.TryParse(modifyPart.modifyPartFlexText.Text, out _))
            {
                MessageBox.Show("ERROR: Enter a company name not a number.");
                modifyPart.modifyPartFlexText.Text = currentPartCompanyName;
                return false;
            }
            return true;
        }

        public bool AddProductExceptions(AddProduct addProduct)
        {
            if (addProduct.addProductName.Text == "" || addProduct.addProductName is null)
            {
                MessageBox.Show("ERROR: Enter a valid product name.");
                addProduct.addProductName.Focus();
                return false;
            }
            if (int.TryParse(addProduct.addProductName.Text, out _))
            {
                MessageBox.Show("ERROR: Product name cannot be a number.");
                return false;
            }
            if (addProduct.addProductInventory.Text == "" || !int.TryParse(addProduct.addProductInventory.Text, out int inv) || inv < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Inventory.");
                addProduct.addProductInventory.Text = "";
                addProduct.addProductInventory.Focus();
                return false;
            }
            if (addProduct.addProductPrice.Text == "" || !decimal.TryParse(addProduct.addProductPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("ERROR: Price must be a positive decimal value.");
                addProduct.addProductPrice.Text = "";
                addProduct.addProductPrice.Focus();
                return false;
            }
            if (addProduct.addProductMax.Text == "" || !int.TryParse(addProduct.addProductMax.Text, out int max) || max < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Max.");
                addProduct.addProductMax.Text = "";
                addProduct.addProductMax.Focus();
                return false;
            }
            if (addProduct.addProductMin.Text == "" || !int.TryParse(addProduct.addProductMin.Text, out int min) || min < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Min.");
                addProduct.addProductMin.Text = "";
                addProduct.addProductMin.Focus();
                return false;
            }
            if (int.Parse(addProduct.addProductMin.Text) > int.Parse(addProduct.addProductMax.Text))
            {
                MessageBox.Show("ERROR: Max must be greater than Min.");
                return false;
            }
            if (int.Parse(addProduct.addProductInventory.Text) > int.Parse(addProduct.addProductMax.Text) || int.Parse(addProduct.addProductInventory.Text) < int.Parse(addProduct.addProductMin.Text))
            {
                MessageBox.Show("ERROR: Inventory stocked must be between Max and Min.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ModifyProductExceptions(ModifyProduct modifyProduct, Product currentProduct)
        {
            if (modifyProduct.modifyProductName.Text == "" || modifyProduct.modifyProductName is null)
            {
                MessageBox.Show("ERROR: Enter a valid product name.");
                modifyProduct.modifyProductName.Text = currentProduct.Name;
                modifyProduct.modifyProductName.Focus();
                return false;
            }
            if (int.TryParse(modifyProduct.modifyProductName.Text, out _))
            {
                MessageBox.Show("ERROR: Product name cannot be a number.");
                return false;
            }
            if (modifyProduct.modifyProductInventory.Text == "" || !int.TryParse(modifyProduct.modifyProductInventory.Text, out int inv) || inv < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Inventory.");
                modifyProduct.modifyProductInventory.Text = currentProduct.InStock.ToString();
                modifyProduct.modifyProductInventory.Focus();
                return false;
            }
            if (modifyProduct.modifyProductPrice.Text == "" || !decimal.TryParse(modifyProduct.modifyProductPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("ERROR: Price must be a positive decimal value.");
                modifyProduct.modifyProductPrice.Text = currentProduct.Price.ToString();
                modifyProduct.modifyProductPrice.Focus();
                return false;
            }
            if (modifyProduct.modifyProductMax.Text == "" || !int.TryParse(modifyProduct.modifyProductMax.Text, out int max) || max < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Max.");
                modifyProduct.modifyProductMax.Text = currentProduct.Max.ToString();
                modifyProduct.modifyProductMax.Focus();
                return false;
            }
            if (modifyProduct.modifyProductMin.Text == "" || !int.TryParse(modifyProduct.modifyProductMin.Text, out int min) || min < 0)
            {
                MessageBox.Show("ERROR: Enter a positive integer for Min.");
                modifyProduct.modifyProductMin.Text = currentProduct.Min.ToString();
                modifyProduct.modifyProductMin.Focus();
                return false;
            }
            if (int.Parse(modifyProduct.modifyProductMin.Text) > int.Parse(modifyProduct.modifyProductMax.Text))
            {
                MessageBox.Show("ERROR: Max must be greater than Min.");
                modifyProduct.modifyProductMax.Text = currentProduct.Max.ToString();
                modifyProduct.modifyProductMin.Text = currentProduct.Min.ToString();
                return false;
            }
            if (int.Parse(modifyProduct.modifyProductInventory.Text) > int.Parse(modifyProduct.modifyProductMax.Text) || int.Parse(modifyProduct.modifyProductInventory.Text) < int.Parse(modifyProduct.modifyProductMin.Text))
            {
                MessageBox.Show("ERROR: Inventory stocked must be between Max and Min.");
                modifyProduct.modifyProductInventory.Text = currentProduct.InStock.ToString();
                return false;
            }
            return true;
        }
    }
}
