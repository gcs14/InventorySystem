using InventorySystem_GarrettSmith.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventorySystem_GarrettSmith
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            MainScreen_Load();
        }

        private void MainScreen_Load()
        {
            Inventory.GenerateDemoData();

            SetProductsTable();
            dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
            dgvProducts.Columns["Name"].HeaderText = "Name";
            dgvProducts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvProducts.Columns["Price"].HeaderText = "Price";

            SetPartsTable();
            dgvParts.Columns["PartID"].HeaderText = "Part ID";
            dgvParts.Columns["Name"].HeaderText = "Name";
            dgvParts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvParts.Columns["Price"].HeaderText = "Price";

            partSearchComboBox.Items.Add("ID");
            partSearchComboBox.Items.Add("Name");
            partSearchComboBox.SelectedIndex = 0;

            productSearchComboBox.Items.Add("ID");
            productSearchComboBox.Items.Add("Name");
            productSearchComboBox.SelectedIndex = 0;
        }

        private void SetProductsTable()
        {
            var bsProducts = new BindingSource();
            bsProducts.DataSource = Inventory.Products;
            dgvProducts.DataSource = bsProducts;
        }

        private void ProductsTableResetButton_Click(object sender, EventArgs e)
        {
            SetProductsTable();
        }

        private void SetPartsTable()
        {
            var bsParts = new BindingSource();
            bsParts.DataSource = Inventory.AllParts;
            dgvParts.DataSource = bsParts;
        }

        private void PartsTableResetButton_Click(object sender, EventArgs e)
        {
            SetPartsTable();
            partsSearchBar.Text = "";
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            var selected = dgvParts.CurrentRow.DataBoundItem;
            if (selected is Inhouse)
            {
                new ModifyPart((Inhouse)selected).ShowDialog();
            }
            else
            {
                new ModifyPart((Outsourced)selected).ShowDialog();
            }
            SetPartsTable();
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure want to delete this part?", "WARNING", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Part selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;
                Inventory.DeletePart(selectedPart);
                MessageBox.Show("Part successfully deleted.");
            }
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

        private void SearchPart_Click(object sender, EventArgs e)
        {
            string keyword = partsSearchBar.Text;
            List<Part> partResults = new List<Part>();
            if (partSearchComboBox.SelectedIndex == 1)
            {
                partResults = SearchPart(keyword);
                if (partResults.Count > 0)
                {
                    dgvParts.DataSource = partResults;
                }
                else
                {
                    MessageBox.Show("Part(s) not found.");
                }
            }
            else
            {
                Inventory inventory = new Inventory();
                if (int.TryParse(keyword, out int x))
                {
                    int count = 0;
                    foreach (Part p in Inventory.AllParts)
                    {
                        if (x == p.PartID)
                        {
                            partResults.Add(inventory.LookupPart(int.Parse(keyword)));
                            dgvParts.DataSource = partResults;
                            count++;
                        }
                    }
                    if (count < 1)
                    {
                        MessageBox.Show("Part(s) not found.");
                        dgvParts.DataSource = Inventory.AllParts;
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid Part ID number.");
                    partsSearchBar.Text = "";
                }
            }
        }

        private List<Product> SearchProduct(string keyword)
        {
            List<Product> productResults = new List<Product>();
            foreach (Product product in Inventory.Products)
            {
                if (product.Name.ToLower().Contains(keyword.ToLower()))
                {
                    productResults.Add(product);
                }
            }
            return productResults;
        }

        private void SearchProduct_Click(object sender, EventArgs e)
        {
            string keyword = productsSearchBar.Text;
            List<Product> productResults = new List<Product>();
            if (productSearchComboBox.SelectedIndex == 1)
            {
                productResults = SearchProduct(keyword);
                if (productResults.Count > 0)
                {
                    dgvProducts.DataSource = productResults;
                }
                else
                {
                    MessageBox.Show("Product(s) not found.");
                }
            }
            else
            {
                Inventory productInventory = new Inventory();
                if (int.TryParse(keyword, out int x))
                {
                    int count = 0;
                    foreach (Product p in Inventory.Products)
                    {
                        if (x == p.ProductID)
                        {
                            productResults.Add(productInventory.LookupProduct(int.Parse(keyword)));
                            dgvProducts.DataSource = productResults;
                            count++;
                        }
                    }
                    if (count < 1)
                    {
                        MessageBox.Show("Product(s) not found.");
                        dgvProducts.DataSource = Inventory.Products;
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid Product ID number.");
                    partsSearchBar.Text = "";
                }
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new AddProductScreen().ShowDialog();
        }

        private void ModifyProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new ModifyProduct(selectedProduct).ShowDialog();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            DialogResult confirm = MessageBox.Show("Are you sure want to delete this product?", "WARNING", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
                inventory.RemoveProduct(selectedProduct.ProductID);
                MessageBox.Show("Product successfully deleted.");
            }
        }

        private void MainScreenExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
