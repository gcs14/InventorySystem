using InventorySystem_GarrettSmith.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystem_GarrettSmith
{
    public partial class AddProductScreen : Form
    {
        Inventory inventory = new Inventory();
        Product product = new Product();

        public AddProductScreen()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            SetCandidatePartsTable();
            dgvAddCandidateParts.Columns["PartID"].HeaderText = "Part ID";
            dgvAddCandidateParts.Columns["Name"].HeaderText = "Name";
            dgvAddCandidateParts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvAddCandidateParts.Columns["Price"].HeaderText = "Price";

            dgvAddCandidateParts.Columns["PartID"].HeaderText = "Part ID";
            dgvAddCandidateParts.Columns["Name"].HeaderText = "Name";
            dgvAddCandidateParts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvAddCandidateParts.Columns["Price"].HeaderText = "Price";
        }

        private void SetCandidatePartsTable()
        {
            var bsCandidateParts = new BindingSource();
            bsCandidateParts.DataSource = Inventory.AllParts;
            dgvAddCandidateParts.DataSource = bsCandidateParts;
        }

        private void SetAssocPartsTable(Product p)
        {
            var bsAssocParts = new BindingSource();
            bsAssocParts.DataSource = p.AssociatedParts.OrderBy(part => part.PartID);
            dgvAddAssocParts.DataSource = bsAssocParts;
        }

        private void AddCandidatePart_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)dgvAddCandidateParts.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Contains(selectedPart))
            {
                MessageBox.Show("The part selected is already assoicated with this product.");
            }
            else
            {
                product.AddAssociatedPart(selectedPart);
                SetAssocPartsTable(product);
            }
        }

        private void DeleteAssocPart_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)dgvAddAssocParts.CurrentRow.DataBoundItem;
            product.RemoveAssociatedPart(selectedPart.PartID);
            SetAssocPartsTable(product);
        }

        private void AddProductSave_Click(object sender, EventArgs e)
        {
            if (AddProductExceptions())
            {
                inventory.AddProduct(new Product(
                    Inventory.Products.Count + 1,
                    addProductName.Text,
                    int.Parse(addProductInventory.Text),
                    decimal.Parse(addProductPrice.Text),
                    int.Parse(addProductMin.Text),
                    int.Parse(addProductMax.Text)
                ));
                this.Close();
            }
        }

        private void AddProductNameValidation(object sender, EventArgs e)
        {
            foreach (Product p in Inventory.Products)
            {
                if (p.Name.Equals(addProductName))
                {
                    MessageBox.Show("Error: A product already exists with that name.");
                }
            }
        }

        private bool AddProductExceptions()
        {
            if (addProductName.Text == "")
            {
                MessageBox.Show("Error: Enter a valid product name.");
                addProductName.Focus();
                return false;
            }
            if (addProductInventory.Text == "" || !int.TryParse(addProductInventory.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Inventory.");
                addProductInventory.Text = "";
                addProductInventory.Focus();
                return false;
            }
            if (addProductMax.Text == "" || !int.TryParse(addProductMax.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Max.");
                addProductMax.Text = "";
                addProductMax.Focus();
                return false;
            }
            if (addProductMin.Text == "" || !int.TryParse(addProductMin.Text, out _))
            {
                MessageBox.Show("Error: Enter a valid number for Min.");
                addProductMin.Text = "";
                addProductMin.Focus();
                return false;
            }
            if (int.Parse(addProductMin.Text) > int.Parse(addProductMax.Text))
            {
                MessageBox.Show("Error: Max must be greater than Min.");
                return false;
            }
            if (int.Parse(addProductInventory.Text) > int.Parse(addProductMax.Text) || int.Parse(addProductInventory.Text) < int.Parse(addProductMin.Text))
            {
                MessageBox.Show("Error: Inventory stocked must be between Max and Min.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
