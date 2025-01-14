namespace InventorySystem_GarrettSmith
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addAssocPartsLabel = new System.Windows.Forms.Label();
            this.modifyCandidatePartsLabel = new System.Windows.Forms.Label();
            this.modifyProductCancelBtn = new System.Windows.Forms.Button();
            this.modifyProductSaveBtn = new System.Windows.Forms.Button();
            this.modifyAssocPart_deleteBtn = new System.Windows.Forms.Button();
            this.ModifyCandidatePart_addBtn = new System.Windows.Forms.Button();
            this.dgvModifyAssocParts = new System.Windows.Forms.DataGridView();
            this.dgvModifyCandidateParts = new System.Windows.Forms.DataGridView();
            this.modifyProductMinLabel = new System.Windows.Forms.Label();
            this.modifyProductMaxLabel = new System.Windows.Forms.Label();
            this.modifyProductPriceLabel = new System.Windows.Forms.Label();
            this.modifyProductNameLabel = new System.Windows.Forms.Label();
            this.modifyProductInventoryLabel = new System.Windows.Forms.Label();
            this.modifyProductMin = new System.Windows.Forms.TextBox();
            this.modifyProductIDLabel = new System.Windows.Forms.Label();
            this.modifyProductMax = new System.Windows.Forms.TextBox();
            this.modifyProductPrice = new System.Windows.Forms.TextBox();
            this.modifyProductInventory = new System.Windows.Forms.TextBox();
            this.modifyProductName = new System.Windows.Forms.TextBox();
            this.modifyProductID = new System.Windows.Forms.TextBox();
            this.modifyProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyAssocParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyCandidateParts)).BeginInit();
            this.SuspendLayout();
            // 
            // addAssocPartsLabel
            // 
            this.addAssocPartsLabel.AutoSize = true;
            this.addAssocPartsLabel.Location = new System.Drawing.Point(499, 339);
            this.addAssocPartsLabel.Name = "addAssocPartsLabel";
            this.addAssocPartsLabel.Size = new System.Drawing.Size(189, 15);
            this.addAssocPartsLabel.TabIndex = 52;
            this.addAssocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // modifyCandidatePartsLabel
            // 
            this.modifyCandidatePartsLabel.AutoSize = true;
            this.modifyCandidatePartsLabel.Location = new System.Drawing.Point(499, 81);
            this.modifyCandidatePartsLabel.Name = "modifyCandidatePartsLabel";
            this.modifyCandidatePartsLabel.Size = new System.Drawing.Size(110, 15);
            this.modifyCandidatePartsLabel.TabIndex = 51;
            this.modifyCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // modifyProductCancelBtn
            // 
            this.modifyProductCancelBtn.AutoSize = true;
            this.modifyProductCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductCancelBtn.Location = new System.Drawing.Point(972, 594);
            this.modifyProductCancelBtn.Name = "modifyProductCancelBtn";
            this.modifyProductCancelBtn.Size = new System.Drawing.Size(75, 30);
            this.modifyProductCancelBtn.TabIndex = 50;
            this.modifyProductCancelBtn.Text = "Cancel";
            this.modifyProductCancelBtn.UseVisualStyleBackColor = true;
            this.modifyProductCancelBtn.Click += new System.EventHandler(this.ModifyProductCancel_Click);
            // 
            // modifyProductSaveBtn
            // 
            this.modifyProductSaveBtn.AutoSize = true;
            this.modifyProductSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductSaveBtn.Location = new System.Drawing.Point(865, 594);
            this.modifyProductSaveBtn.Name = "modifyProductSaveBtn";
            this.modifyProductSaveBtn.Size = new System.Drawing.Size(75, 30);
            this.modifyProductSaveBtn.TabIndex = 49;
            this.modifyProductSaveBtn.Text = "Save";
            this.modifyProductSaveBtn.UseVisualStyleBackColor = true;
            this.modifyProductSaveBtn.Click += new System.EventHandler(this.ModifyProductSave_Click);
            // 
            // modifyAssocPart_deleteBtn
            // 
            this.modifyAssocPart_deleteBtn.AutoSize = true;
            this.modifyAssocPart_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyAssocPart_deleteBtn.Location = new System.Drawing.Point(972, 527);
            this.modifyAssocPart_deleteBtn.Name = "modifyAssocPart_deleteBtn";
            this.modifyAssocPart_deleteBtn.Size = new System.Drawing.Size(75, 30);
            this.modifyAssocPart_deleteBtn.TabIndex = 48;
            this.modifyAssocPart_deleteBtn.Text = "Delete";
            this.modifyAssocPart_deleteBtn.UseVisualStyleBackColor = true;
            this.modifyAssocPart_deleteBtn.Click += new System.EventHandler(this.ModifyDeleteAssocPart_Click);
            // 
            // ModifyCandidatePart_addBtn
            // 
            this.ModifyCandidatePart_addBtn.AutoSize = true;
            this.ModifyCandidatePart_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyCandidatePart_addBtn.Location = new System.Drawing.Point(972, 269);
            this.ModifyCandidatePart_addBtn.Name = "ModifyCandidatePart_addBtn";
            this.ModifyCandidatePart_addBtn.Size = new System.Drawing.Size(75, 30);
            this.ModifyCandidatePart_addBtn.TabIndex = 47;
            this.ModifyCandidatePart_addBtn.Text = "Add";
            this.ModifyCandidatePart_addBtn.UseVisualStyleBackColor = true;
            this.ModifyCandidatePart_addBtn.Click += new System.EventHandler(this.ModifyCandidatePart_Click);
            // 
            // dgvModifyAssocParts
            // 
            this.dgvModifyAssocParts.AllowUserToAddRows = false;
            this.dgvModifyAssocParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModifyAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyAssocParts.Location = new System.Drawing.Point(499, 358);
            this.dgvModifyAssocParts.MultiSelect = false;
            this.dgvModifyAssocParts.Name = "dgvModifyAssocParts";
            this.dgvModifyAssocParts.ReadOnly = true;
            this.dgvModifyAssocParts.RowHeadersVisible = false;
            this.dgvModifyAssocParts.RowHeadersWidth = 51;
            this.dgvModifyAssocParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModifyAssocParts.Size = new System.Drawing.Size(548, 163);
            this.dgvModifyAssocParts.TabIndex = 45;
            this.dgvModifyAssocParts.TabStop = false;
            // 
            // dgvModifyCandidateParts
            // 
            this.dgvModifyCandidateParts.AllowUserToAddRows = false;
            this.dgvModifyCandidateParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModifyCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyCandidateParts.Location = new System.Drawing.Point(499, 100);
            this.dgvModifyCandidateParts.MultiSelect = false;
            this.dgvModifyCandidateParts.Name = "dgvModifyCandidateParts";
            this.dgvModifyCandidateParts.ReadOnly = true;
            this.dgvModifyCandidateParts.RowHeadersVisible = false;
            this.dgvModifyCandidateParts.RowHeadersWidth = 51;
            this.dgvModifyCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModifyCandidateParts.Size = new System.Drawing.Size(548, 163);
            this.dgvModifyCandidateParts.TabIndex = 46;
            this.dgvModifyCandidateParts.TabStop = false;
            // 
            // modifyProductMinLabel
            // 
            this.modifyProductMinLabel.AutoSize = true;
            this.modifyProductMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMinLabel.Location = new System.Drawing.Point(284, 390);
            this.modifyProductMinLabel.Name = "modifyProductMinLabel";
            this.modifyProductMinLabel.Size = new System.Drawing.Size(41, 24);
            this.modifyProductMinLabel.TabIndex = 36;
            this.modifyProductMinLabel.Text = "Min";
            // 
            // modifyProductMaxLabel
            // 
            this.modifyProductMaxLabel.AutoSize = true;
            this.modifyProductMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMaxLabel.Location = new System.Drawing.Point(89, 389);
            this.modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            this.modifyProductMaxLabel.Size = new System.Drawing.Size(46, 24);
            this.modifyProductMaxLabel.TabIndex = 40;
            this.modifyProductMaxLabel.Text = "Max";
            // 
            // modifyProductPriceLabel
            // 
            this.modifyProductPriceLabel.AutoSize = true;
            this.modifyProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductPriceLabel.Location = new System.Drawing.Point(89, 340);
            this.modifyProductPriceLabel.Name = "modifyProductPriceLabel";
            this.modifyProductPriceLabel.Size = new System.Drawing.Size(53, 24);
            this.modifyProductPriceLabel.TabIndex = 39;
            this.modifyProductPriceLabel.Text = "Price";
            // 
            // modifyProductNameLabel
            // 
            this.modifyProductNameLabel.AutoSize = true;
            this.modifyProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductNameLabel.Location = new System.Drawing.Point(83, 240);
            this.modifyProductNameLabel.Name = "modifyProductNameLabel";
            this.modifyProductNameLabel.Size = new System.Drawing.Size(61, 24);
            this.modifyProductNameLabel.TabIndex = 38;
            this.modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductInventoryLabel
            // 
            this.modifyProductInventoryLabel.AutoSize = true;
            this.modifyProductInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductInventoryLabel.Location = new System.Drawing.Point(64, 291);
            this.modifyProductInventoryLabel.Name = "modifyProductInventoryLabel";
            this.modifyProductInventoryLabel.Size = new System.Drawing.Size(86, 24);
            this.modifyProductInventoryLabel.TabIndex = 37;
            this.modifyProductInventoryLabel.Text = "Inventory";
            // 
            // modifyProductMin
            // 
            this.modifyProductMin.AcceptsReturn = true;
            this.modifyProductMin.AcceptsTab = true;
            this.modifyProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMin.Location = new System.Drawing.Point(353, 389);
            this.modifyProductMin.Name = "modifyProductMin";
            this.modifyProductMin.Size = new System.Drawing.Size(86, 26);
            this.modifyProductMin.TabIndex = 44;
            // 
            // modifyProductIDLabel
            // 
            this.modifyProductIDLabel.AutoSize = true;
            this.modifyProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductIDLabel.Location = new System.Drawing.Point(109, 194);
            this.modifyProductIDLabel.Name = "modifyProductIDLabel";
            this.modifyProductIDLabel.Size = new System.Drawing.Size(27, 24);
            this.modifyProductIDLabel.TabIndex = 35;
            this.modifyProductIDLabel.Text = "ID";
            // 
            // modifyProductMax
            // 
            this.modifyProductMax.AcceptsReturn = true;
            this.modifyProductMax.AcceptsTab = true;
            this.modifyProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMax.Location = new System.Drawing.Point(158, 389);
            this.modifyProductMax.Name = "modifyProductMax";
            this.modifyProductMax.Size = new System.Drawing.Size(86, 26);
            this.modifyProductMax.TabIndex = 43;
            // 
            // modifyProductPrice
            // 
            this.modifyProductPrice.AcceptsReturn = true;
            this.modifyProductPrice.AcceptsTab = true;
            this.modifyProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductPrice.Location = new System.Drawing.Point(158, 339);
            this.modifyProductPrice.Name = "modifyProductPrice";
            this.modifyProductPrice.Size = new System.Drawing.Size(198, 26);
            this.modifyProductPrice.TabIndex = 42;
            // 
            // modifyProductInventory
            // 
            this.modifyProductInventory.AcceptsReturn = true;
            this.modifyProductInventory.AcceptsTab = true;
            this.modifyProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductInventory.Location = new System.Drawing.Point(158, 291);
            this.modifyProductInventory.Name = "modifyProductInventory";
            this.modifyProductInventory.Size = new System.Drawing.Size(198, 26);
            this.modifyProductInventory.TabIndex = 41;
            // 
            // modifyProductName
            // 
            this.modifyProductName.AcceptsReturn = true;
            this.modifyProductName.AcceptsTab = true;
            this.modifyProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductName.Location = new System.Drawing.Point(158, 240);
            this.modifyProductName.Name = "modifyProductName";
            this.modifyProductName.Size = new System.Drawing.Size(198, 26);
            this.modifyProductName.TabIndex = 34;
            this.modifyProductName.Leave += new System.EventHandler(this.ModifyProductNameValidation);
            // 
            // modifyProductID
            // 
            this.modifyProductID.Enabled = false;
            this.modifyProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductID.Location = new System.Drawing.Point(158, 192);
            this.modifyProductID.Name = "modifyProductID";
            this.modifyProductID.Size = new System.Drawing.Size(198, 26);
            this.modifyProductID.TabIndex = 33;
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(12, 26);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(243, 39);
            this.modifyProductLabel.TabIndex = 32;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 632);
            this.Controls.Add(this.addAssocPartsLabel);
            this.Controls.Add(this.modifyCandidatePartsLabel);
            this.Controls.Add(this.modifyProductCancelBtn);
            this.Controls.Add(this.modifyProductSaveBtn);
            this.Controls.Add(this.modifyAssocPart_deleteBtn);
            this.Controls.Add(this.ModifyCandidatePart_addBtn);
            this.Controls.Add(this.dgvModifyAssocParts);
            this.Controls.Add(this.dgvModifyCandidateParts);
            this.Controls.Add(this.modifyProductMinLabel);
            this.Controls.Add(this.modifyProductMaxLabel);
            this.Controls.Add(this.modifyProductPriceLabel);
            this.Controls.Add(this.modifyProductNameLabel);
            this.Controls.Add(this.modifyProductInventoryLabel);
            this.Controls.Add(this.modifyProductMin);
            this.Controls.Add(this.modifyProductIDLabel);
            this.Controls.Add(this.modifyProductMax);
            this.Controls.Add(this.modifyProductPrice);
            this.Controls.Add(this.modifyProductInventory);
            this.Controls.Add(this.modifyProductName);
            this.Controls.Add(this.modifyProductID);
            this.Controls.Add(this.modifyProductLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyAssocParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyCandidateParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAssocPartsLabel;
        private System.Windows.Forms.Label modifyCandidatePartsLabel;
        private System.Windows.Forms.Button modifyProductCancelBtn;
        private System.Windows.Forms.Button modifyProductSaveBtn;
        private System.Windows.Forms.Button modifyAssocPart_deleteBtn;
        private System.Windows.Forms.Button ModifyCandidatePart_addBtn;
        private System.Windows.Forms.DataGridView dgvModifyAssocParts;
        private System.Windows.Forms.DataGridView dgvModifyCandidateParts;
        private System.Windows.Forms.Label modifyProductMinLabel;
        private System.Windows.Forms.Label modifyProductMaxLabel;
        private System.Windows.Forms.Label modifyProductPriceLabel;
        private System.Windows.Forms.Label modifyProductNameLabel;
        private System.Windows.Forms.Label modifyProductInventoryLabel;
        private System.Windows.Forms.TextBox modifyProductMin;
        private System.Windows.Forms.Label modifyProductIDLabel;
        private System.Windows.Forms.TextBox modifyProductMax;
        private System.Windows.Forms.TextBox modifyProductPrice;
        private System.Windows.Forms.TextBox modifyProductInventory;
        private System.Windows.Forms.TextBox modifyProductName;
        private System.Windows.Forms.TextBox modifyProductID;
        private System.Windows.Forms.Label modifyProductLabel;
    }
}