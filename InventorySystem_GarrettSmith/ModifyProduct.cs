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
    public partial class ModifyProduct : Form
    {
        Product currentProduct = new Product();
        Product updatedProduct;
        List<Part> potentialParts = new List<Part>();
        int currentProductID;

        public ModifyProduct()
        {
            InitializeComponent();
        }
        public ModifyProduct(Product selectedProduct)
        {
            InitializeComponent();

            modifyProductID.Text = selectedProduct.ProductID.ToString();
            modifyProductName.Text = selectedProduct.Name;
            modifyProductInventory.Text = selectedProduct.InStock.ToString();
            modifyProductPrice.Text = selectedProduct.Price.ToString();
            modifyProductMax.Text = selectedProduct.Max.ToString();
            modifyProductMin.Text = selectedProduct.Min.ToString();
            this.currentProductID = selectedProduct.ProductID;

            this.currentProduct = Inventory.LookupProduct(currentProductID);
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            SetCandidatePartsTable();
            SetAssocPartsTable(Inventory.LookupProduct(currentProductID));
        }

        private void SetCandidatePartsTable()
        {
            dgvModifyCandidateParts.DataSource = Inventory.AllParts;

            dgvModifyCandidateParts.Columns["PartID"].HeaderText = "Part ID";
            dgvModifyCandidateParts.Columns["Name"].HeaderText = "Name";
            dgvModifyCandidateParts.Columns["InStock"].HeaderText = "Inventory";
            dgvModifyCandidateParts.Columns["Price"].HeaderText = "Price";
        }

        private void SetAssocPartsTable(Product p)
        {
            dgvModifyAssocParts.DataSource = p.AssociatedParts;

            dgvModifyAssocParts.Columns["PartID"].HeaderText = "Part ID";
            dgvModifyAssocParts.Columns["Name"].HeaderText = "Name";
            dgvModifyAssocParts.Columns["InStock"].HeaderText = "Inventory";
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
                potentialParts.Add(selectedPart);
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
            CustomExceptions customExceptions = new CustomExceptions();
            if (customExceptions.ModifyProductExceptions(this, currentProduct))
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

                Inventory.UpdateProduct(int.Parse(modifyProductID.Text), updatedProduct);
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

        private void ModifyProductCancel_Click(object sender, EventArgs e)
        {
            foreach (Part p in potentialParts)
            {
                currentProduct.RemoveAssociatedPart(p.PartID);
            }
            this.Close();
        }
    }
}