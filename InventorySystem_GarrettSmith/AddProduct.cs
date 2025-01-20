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
    public partial class AddProduct : Form
    {
        CustomExceptions customExceptions = new CustomExceptions();
        Product product = new Product();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            SetCandidatePartsTable();
            addProductSearchComboBox.Items.Add("ID");
            addProductSearchComboBox.Items.Add("Name");
            addProductSearchComboBox.SelectedIndex = 0;
        }

        private void SetCandidatePartsTable()
        {
            dgvAddCandidateParts.DataSource = Inventory.AllParts;

            dgvAddCandidateParts.Columns["PartID"].HeaderText = "Part ID";
            dgvAddCandidateParts.Columns["Name"].HeaderText = "Name";
            dgvAddCandidateParts.Columns["InStock"].HeaderText = "Inventory";
            dgvAddCandidateParts.Columns["Price"].HeaderText = "Price";
        }

        private void SetAssocPartsTable(Product p)
        {
            dgvAddAssocParts.DataSource = p.AssociatedParts;

            dgvAddAssocParts.Columns["PartID"].HeaderText = "Part ID";
            dgvAddAssocParts.Columns["Name"].HeaderText = "Name";
            dgvAddAssocParts.Columns["InStock"].HeaderText = "Inventory";
            dgvAddAssocParts.Columns["Price"].HeaderText = "Price";
        }

        private List<Part> SearchPart(string keyword)
        {
            List<Part> partResults = new List<Part>();
            foreach (Part part in Inventory.AllParts)
            {
                if (part.Name.ToLower().Contains(keyword.ToLower()))
                {
                    partResults.Add(part);
                }
            }
            return partResults;
        }

        private void SearchCandidatePart_Click(object sender, EventArgs e)
        {
            string keyword = addProductsSearchBar.Text;
            List<Part> partResults = new List<Part>();
            if (keyword == "")
            {
                MessageBox.Show("ERROR: Write value in the search bar to search for a part.");
            }
            else
            {
                if (addProductSearchComboBox.SelectedIndex == 1)
                {
                    partResults = SearchPart(keyword);
                    if (partResults.Count > 0)
                    {
                        dgvAddCandidateParts.DataSource = partResults;
                    }
                    else
                    {
                        MessageBox.Show("Part(s) not found.");
                    }
                }
                else
                {
                    if (int.TryParse(keyword, out int x))
                    {
                        int count = 0;
                        foreach (Part p in Inventory.AllParts)
                        {
                            if (x == p.PartID)
                            {
                                partResults.Add(Inventory.LookupPart(int.Parse(keyword)));
                                dgvAddCandidateParts.DataSource = partResults;
                                count++;
                            }
                        }
                        if (count < 1)
                        {
                            MessageBox.Show("Part(s) not found.");
                            dgvAddCandidateParts.DataSource = Inventory.AllParts;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Enter a valid Part ID number.");
                        addProductsSearchBar.Text = "";
                    }
                }
            }
        }

        private void CandidatePartsResetBtn_Click(object sender, EventArgs e)
        {
            SetCandidatePartsTable();
            addProductsSearchBar.Text = "";
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
            if (product.AssociatedParts.Count > 0)
            {
                Part selectedPart = (Part)dgvAddAssocParts.CurrentRow.DataBoundItem;
                product.RemoveAssociatedPart(selectedPart.PartID);
                SetAssocPartsTable(product);
            }
            else
            {
                MessageBox.Show("ERROR: There are no parts associated with this product.");
            }
        }

        private void AddProductSave_Click(object sender, EventArgs e)
        {
            if (customExceptions.AddProductExceptions(this))
            {
                product.ProductID = Inventory.productsCount + 1;
                product.Name = addProductName.Text;
                product.InStock = int.Parse(addProductInventory.Text);
                product.Price = decimal.Parse(addProductPrice.Text);
                product.Min = int.Parse(addProductMin.Text);
                product.Max = int.Parse(addProductMax.Text);

                Inventory.AddProduct(product);
                Inventory.productsCount++;
                this.Close();
            }
        }

        private void AddProductNameValidation(object sender, EventArgs e)
        {
            foreach (Product p in Inventory.Products)
            {
                if (p.Name.Equals(addProductName))
                {
                    MessageBox.Show("ERROR: A product already exists with that name.");
                }
            }
        }

        private void AddProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
