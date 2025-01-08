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

            var bsProducts = new BindingSource();
            bsProducts.DataSource = Inventory.Products;
            dgvProducts.DataSource = bsProducts;

            dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
            dgvProducts.Columns["Name"].HeaderText = "Name";
            dgvProducts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvProducts.Columns["Price"].HeaderText = "Price";

            var bsParts = new BindingSource();
            bsParts.DataSource = Inventory.AllParts;
            dgvParts.DataSource = bsParts;

            dgvParts.Columns["PartID"].HeaderText = "Part ID";
            dgvParts.Columns["Name"].HeaderText = "Name";
            dgvParts.Columns["InStock"].HeaderText = "Inventory Level";
            dgvParts.Columns["Price"].HeaderText = "Price";
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            new AddPartScreen().ShowDialog();
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            new ModifyPartScreen().ShowDialog();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new AddProductScreen().ShowDialog();
        }
    }
}
