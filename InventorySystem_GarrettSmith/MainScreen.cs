﻿using InventorySystem_GarrettSmith.model;
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

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }

        private List<Part> SearchPart(string keyword)
        {
            List<Part> results = new List<Part>();
            foreach (Part part in Inventory.AllParts)
            {
                if (part.Name.ToLower().Contains(keyword.ToLower()))
                {
                    results.Add(part);
                }
            }
            return results;
        }

        private void SearchPart_Click(object sender, EventArgs e)
        {
            string keyword = partsSearchBar.Text;
            List<Part> results = SearchPart(keyword);
            if (results.Count > 0)
            {
                dgvParts.DataSource = results;
            }
            else
            {
                MessageBox.Show("Part(s) not found.");
            }
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            var selected = dgvParts.CurrentRow.DataBoundItem;
            //MessageBox.Show(selected.ToString());
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
            List<Product> productResults = SearchProduct(keyword);
            if (productResults.Count > 0)
            {
                dgvProducts.DataSource = productResults;
            }
            else
            {
                MessageBox.Show("Product(s) not found.");
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new AddProductScreen().ShowDialog();
        }

        private void MainScreenExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
