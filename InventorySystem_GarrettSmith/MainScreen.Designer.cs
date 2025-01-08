namespace InventorySystem_GarrettSmith
{
    partial class MainScreen
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
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partsSearchBar = new System.Windows.Forms.TextBox();
            this.productsSearchBar = new System.Windows.Forms.TextBox();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.productsSearchBtn = new System.Windows.Forms.Button();
            this.partAddBtn = new System.Windows.Forms.Button();
            this.partModifyBtn = new System.Windows.Forms.Button();
            this.partDeleteBtn = new System.Windows.Forms.Button();
            this.productAddBtn = new System.Windows.Forms.Button();
            this.productModifyBtn = new System.Windows.Forms.Button();
            this.productDeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.AutoSize = true;
            this.mainScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenLabel.Location = new System.Drawing.Point(6, 9);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(389, 31);
            this.mainScreenLabel.TabIndex = 0;
            this.mainScreenLabel.Text = "Inventory Management System";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(12, 117);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(548, 394);
            this.dgvParts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(590, 117);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(529, 394);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(7, 77);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(63, 26);
            this.partsLabel.TabIndex = 2;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(585, 77);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(98, 26);
            this.productsLabel.TabIndex = 2;
            this.productsLabel.Text = "Products";
            // 
            // partsSearchBar
            // 
            this.partsSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBar.Location = new System.Drawing.Point(355, 75);
            this.partsSearchBar.Name = "partsSearchBar";
            this.partsSearchBar.Size = new System.Drawing.Size(205, 23);
            this.partsSearchBar.TabIndex = 3;
            // 
            // productsSearchBar
            // 
            this.productsSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchBar.Location = new System.Drawing.Point(914, 77);
            this.productsSearchBar.Name = "productsSearchBar";
            this.productsSearchBar.Size = new System.Drawing.Size(205, 23);
            this.productsSearchBar.TabIndex = 3;
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.AutoSize = true;
            this.partsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBtn.Location = new System.Drawing.Point(265, 75);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(75, 27);
            this.partsSearchBtn.TabIndex = 4;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // productsSearchBtn
            // 
            this.productsSearchBtn.AutoSize = true;
            this.productsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchBtn.Location = new System.Drawing.Point(821, 77);
            this.productsSearchBtn.Name = "productsSearchBtn";
            this.productsSearchBtn.Size = new System.Drawing.Size(75, 27);
            this.productsSearchBtn.TabIndex = 4;
            this.productsSearchBtn.Text = "Search";
            this.productsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // partAddBtn
            // 
            this.partAddBtn.AutoSize = true;
            this.partAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAddBtn.Location = new System.Drawing.Point(265, 534);
            this.partAddBtn.Name = "partAddBtn";
            this.partAddBtn.Size = new System.Drawing.Size(75, 27);
            this.partAddBtn.TabIndex = 5;
            this.partAddBtn.Text = "Add";
            this.partAddBtn.UseVisualStyleBackColor = true;
            this.partAddBtn.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // partModifyBtn
            // 
            this.partModifyBtn.AutoSize = true;
            this.partModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partModifyBtn.Location = new System.Drawing.Point(374, 534);
            this.partModifyBtn.Name = "partModifyBtn";
            this.partModifyBtn.Size = new System.Drawing.Size(75, 27);
            this.partModifyBtn.TabIndex = 5;
            this.partModifyBtn.Text = "Modify";
            this.partModifyBtn.UseVisualStyleBackColor = true;
            this.partModifyBtn.Click += new System.EventHandler(this.ModifyPart_Click);
            // 
            // partDeleteBtn
            // 
            this.partDeleteBtn.AutoSize = true;
            this.partDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDeleteBtn.Location = new System.Drawing.Point(485, 534);
            this.partDeleteBtn.Name = "partDeleteBtn";
            this.partDeleteBtn.Size = new System.Drawing.Size(75, 27);
            this.partDeleteBtn.TabIndex = 5;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // productAddBtn
            // 
            this.productAddBtn.AutoSize = true;
            this.productAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAddBtn.Location = new System.Drawing.Point(824, 534);
            this.productAddBtn.Name = "productAddBtn";
            this.productAddBtn.Size = new System.Drawing.Size(75, 27);
            this.productAddBtn.TabIndex = 5;
            this.productAddBtn.Text = "Add";
            this.productAddBtn.UseVisualStyleBackColor = true;
            this.productAddBtn.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // productModifyBtn
            // 
            this.productModifyBtn.AutoSize = true;
            this.productModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModifyBtn.Location = new System.Drawing.Point(932, 534);
            this.productModifyBtn.Name = "productModifyBtn";
            this.productModifyBtn.Size = new System.Drawing.Size(75, 27);
            this.productModifyBtn.TabIndex = 5;
            this.productModifyBtn.Text = "Modify";
            this.productModifyBtn.UseVisualStyleBackColor = true;
            // 
            // productDeleteBtn
            // 
            this.productDeleteBtn.AutoSize = true;
            this.productDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeleteBtn.Location = new System.Drawing.Point(1046, 534);
            this.productDeleteBtn.Name = "productDeleteBtn";
            this.productDeleteBtn.Size = new System.Drawing.Size(75, 27);
            this.productDeleteBtn.TabIndex = 5;
            this.productDeleteBtn.Text = "Delete";
            this.productDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 632);
            this.Controls.Add(this.productDeleteBtn);
            this.Controls.Add(this.partDeleteBtn);
            this.Controls.Add(this.productModifyBtn);
            this.Controls.Add(this.partModifyBtn);
            this.Controls.Add(this.productAddBtn);
            this.Controls.Add(this.partAddBtn);
            this.Controls.Add(this.productsSearchBtn);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.productsSearchBar);
            this.Controls.Add(this.partsSearchBar);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.mainScreenLabel);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.TextBox partsSearchBar;
        private System.Windows.Forms.TextBox productsSearchBar;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.Button productsSearchBtn;
        private System.Windows.Forms.Button partAddBtn;
        private System.Windows.Forms.Button partModifyBtn;
        private System.Windows.Forms.Button partDeleteBtn;
        private System.Windows.Forms.Button productAddBtn;
        private System.Windows.Forms.Button productModifyBtn;
        private System.Windows.Forms.Button productDeleteBtn;
    }
}

