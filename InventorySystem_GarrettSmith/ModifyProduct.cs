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
    public partial class ModifyProduct : Form
    {
        Inventory inventory = new Inventory();
        Product currentProduct = new Product();
        Product updatedProduct;
        int currentProductID;
        string currentProductName;
        string currentProductInventory;
        string currentProductPrice;
        string currentProductMin;
        string currentProductMax;

        public ModifyProduct()
        {
            InitializeComponent();
        }
        public ModifyProduct(Product selectedProduct)
        {
            InitializeComponent();

            modifyProductID.Text = selectedProduct.ProductID.ToString();
            modifyProductName.Text = currentProductName = selectedProduct.Name;
            modifyProductInventory.Text = currentProductInventory = selectedProduct.InStock.ToString();
            modifyProductPrice.Text = currentProductPrice = selectedProduct.Price.ToString();
            modifyProductMax.Text = currentProductMax = selectedProduct.Max.ToString();
            modifyProductMin.Text = currentProductMin = selectedProduct.Min.ToString();
            this.currentProductID = selectedProduct.ProductID;

            this.currentProduct = inventory.LookupProduct(currentProductID);
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            SetCandidatePartsTable();
            SetAssocPartsTable(inventory.LookupProduct(currentProductID));
        }

        private void SetCandidatePartsTable()
        {
            var bsCandidateParts = new BindingSource();
            bsCandidateParts.DataSource = Inventory.AllParts;
            dgvModifyCandidateParts.DataSource = bsCandidateParts;

            dgvModifyCandidateParts.Columns["PartID"].HeaderText = "Part ID";
            dgvModifyCandidateParts.Columns["Name"].HeaderText = "Name";
            dgvModifyCandidateParts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvModifyCandidateParts.Columns["Price"].HeaderText = "Price";
        }

        private void SetAssocPartsTable(Product p)
        {
            var bsAssocParts = new BindingSource();
            bsAssocParts.DataSource = p.AssociatedParts;
            dgvModifyAssocParts.DataSource = bsAssocParts;

            dgvModifyAssocParts.Columns["PartID"].HeaderText = "Part ID";
            dgvModifyAssocParts.Columns["Name"].HeaderText = "Name";
            dgvModifyAssocParts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvModifyAssocParts.Columns["Price"].HeaderText = "Price";
        }

        

        private void ModifyCandidatePart_Click(object sender, EventArgs e)
        {
            
            Part selectedPart = (Part)dgvModifyCandidateParts.CurrentRow.DataBoundItem;
            if (currentProduct.AssociatedParts.Contains(selectedPart))
            {
                MessageBox.Show("The part selected is already assoicated with this product.");
            }
            else
            {
                currentProduct.AddAssociatedPart(selectedPart);
                SetAssocPartsTable(currentProduct);
            }
        }

        private void ModifyDeleteAssocPart_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)dgvModifyAssocParts.CurrentRow.DataBoundItem;
            currentProduct.RemoveAssociatedPart(selectedPart.PartID);
            SetAssocPartsTable(currentProduct);
        }

        private void ModifyProductSave_Click(object sender, EventArgs e)
        {
            if (ModifyProductExceptions())
            {
                updatedProduct = new Product(
                    currentProduct.AssociatedParts,
                    int.Parse(modifyProductID.Text),
                    modifyProductName.Text,
                    int.Parse(modifyProductInventory.Text),
                    decimal.Parse(modifyProductPrice.Text),
                    int.Parse(modifyProductMin.Text),
                    int.Parse(modifyProductMax.Text)
                    );

                inventory.UpdateProduct(int.Parse(modifyProductID.Text), updatedProduct);
                this.Close();
            }
        }

        private void ModifyProductNameValidation(object sender, EventArgs e)
        {
            foreach (Part part in Inventory.AllParts)
            {
                if (part.Name.Equals(modifyProductName.Text))
                {
                    MessageBox.Show("Error: A product already exists with that name.");
                }
            }
        }

        private bool ModifyProductExceptions()
        {
            if (modifyProductName.Text == "")
            {
                MessageBox.Show("Error: Enter a valid part name.");
                modifyProductName.Text = currentProductName;
                modifyProductName.Focus();
                return false;
            }
            if (modifyProductInventory.Text == "" || !int.TryParse(modifyProductInventory.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Inventory.");
                modifyProductInventory.Text = currentProductInventory;
                modifyProductInventory.Focus();
                return false;
            }
            if (modifyProductPrice.Text == "" || !decimal.TryParse(modifyProductPrice.Text, out _))
            {
                MessageBox.Show("Error: Price must be a decimal value.");
                modifyProductPrice.Text = currentProductPrice;
                modifyProductPrice.Focus();
                return false;
            }
            if (modifyProductMax.Text == "" || !int.TryParse(modifyProductMax.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Max.");
                modifyProductMax.Text = currentProductMax;
                modifyProductMax.Focus();
                return false;
            }
            if (modifyProductMin.Text == "" || !int.TryParse(modifyProductMin.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Min.");
                modifyProductMin.Text = currentProductMin;
                modifyProductMin.Focus();
                return false;
            }
            if (int.Parse(modifyProductMin.Text) > int.Parse(modifyProductMax.Text))
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                return false;
            }

            if (int.Parse(modifyProductMin.Text) > int.Parse(modifyProductMax.Text))
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                modifyProductMax.Text = currentProductMax;
                modifyProductMin.Text = currentProductMin;
                return false;
            }
            if (int.Parse(modifyProductInventory.Text) > int.Parse(modifyProductMax.Text) || int.Parse(modifyProductInventory.Text) < int.Parse(modifyProductMin.Text))
            {
                MessageBox.Show("Error: Inventory stocked must be between Max and Min.");
                modifyProductInventory.Text = currentProductInventory;
                return false;
            }
            return true;
        }

        private void ModifyProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
