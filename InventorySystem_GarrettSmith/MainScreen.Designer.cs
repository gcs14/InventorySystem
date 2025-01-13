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
            this.MainScreenExit = new System.Windows.Forms.Button();
            this.partsTableReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.partSearchComboBox = new System.Windows.Forms.ComboBox();
            this.productSearchComboBox = new System.Windows.Forms.ComboBox();
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
            this.dgvParts.TabIndex = 3;
            this.dgvParts.TabStop = false;
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
            this.dgvProducts.TabIndex = 10;
            this.dgvProducts.TabStop = false;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(7, 77);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(63, 26);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(585, 77);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(98, 26);
            this.productsLabel.TabIndex = 0;
            this.productsLabel.Text = "Products";
            // 
            // partsSearchBar
            // 
            this.partsSearchBar.AcceptsTab = true;
            this.partsSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBar.Location = new System.Drawing.Point(274, 77);
            this.partsSearchBar.Name = "partsSearchBar";
            this.partsSearchBar.Size = new System.Drawing.Size(205, 23);
            this.partsSearchBar.TabIndex = 1;
            // 
            // productsSearchBar
            // 
            this.productsSearchBar.AcceptsTab = true;
            this.productsSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchBar.Location = new System.Drawing.Point(835, 77);
            this.productsSearchBar.Name = "productsSearchBar";
            this.productsSearchBar.Size = new System.Drawing.Size(205, 23);
            this.productsSearchBar.TabIndex = 8;
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.AutoSize = true;
            this.partsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBtn.Location = new System.Drawing.Point(485, 75);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(75, 27);
            this.partsSearchBtn.TabIndex = 2;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            this.partsSearchBtn.Click += new System.EventHandler(this.SearchPart_Click);
            // 
            // productsSearchBtn
            // 
            this.productsSearchBtn.AutoSize = true;
            this.productsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchBtn.Location = new System.Drawing.Point(1046, 75);
            this.productsSearchBtn.Name = "productsSearchBtn";
            this.productsSearchBtn.Size = new System.Drawing.Size(75, 27);
            this.productsSearchBtn.TabIndex = 9;
            this.productsSearchBtn.Text = "Search";
            this.productsSearchBtn.UseVisualStyleBackColor = true;
            this.productsSearchBtn.Click += new System.EventHandler(this.SearchProduct_Click);
            // 
            // partAddBtn
            // 
            this.partAddBtn.AutoSize = true;
            this.partAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAddBtn.Location = new System.Drawing.Point(265, 534);
            this.partAddBtn.Name = "partAddBtn";
            this.partAddBtn.Size = new System.Drawing.Size(75, 27);
            this.partAddBtn.TabIndex = 4;
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
            this.partDeleteBtn.TabIndex = 6;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            this.partDeleteBtn.Click += new System.EventHandler(this.DeletePart_Click);
            // 
            // productAddBtn
            // 
            this.productAddBtn.AutoSize = true;
            this.productAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAddBtn.Location = new System.Drawing.Point(824, 534);
            this.productAddBtn.Name = "productAddBtn";
            this.productAddBtn.Size = new System.Drawing.Size(75, 27);
            this.productAddBtn.TabIndex = 11;
            this.productAddBtn.Text = "Add";
            this.productAddBtn.UseVisualStyleBackColor = true;
            this.productAddBtn.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // productModifyBtn
            // 
            this.productModifyBtn.AutoSize = true;
            this.productModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModifyBtn.Location = new System.Drawing.Point(932, 534);
            this.productModifyBtn.Name = "productModifyBtn";
            this.productModifyBtn.Size = new System.Drawing.Size(75, 27);
            this.productModifyBtn.TabIndex = 12;
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
            this.productDeleteBtn.TabIndex = 13;
            this.productDeleteBtn.Text = "Delete";
            this.productDeleteBtn.UseVisualStyleBackColor = true;
            this.productDeleteBtn.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // MainScreenExit
            // 
            this.MainScreenExit.AutoSize = true;
            this.MainScreenExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenExit.Location = new System.Drawing.Point(1046, 584);
            this.MainScreenExit.Name = "MainScreenExit";
            this.MainScreenExit.Size = new System.Drawing.Size(75, 36);
            this.MainScreenExit.TabIndex = 15;
            this.MainScreenExit.Text = "Exit";
            this.MainScreenExit.UseVisualStyleBackColor = true;
            this.MainScreenExit.Click += new System.EventHandler(this.MainScreenExit_Click);
            // 
            // partsTableReset
            // 
            this.partsTableReset.AutoSize = true;
            this.partsTableReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsTableReset.Location = new System.Drawing.Point(13, 534);
            this.partsTableReset.Name = "partsTableReset";
            this.partsTableReset.Size = new System.Drawing.Size(75, 27);
            this.partsTableReset.TabIndex = 7;
            this.partsTableReset.Text = "Reset";
            this.partsTableReset.UseVisualStyleBackColor = true;
            this.partsTableReset.Click += new System.EventHandler(this.PartsTableResetButton_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(590, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ProductsTableResetButton_Click);
            // 
            // partSearchComboBox
            // 
            this.partSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSearchComboBox.FormattingEnabled = true;
            this.partSearchComboBox.Location = new System.Drawing.Point(206, 76);
            this.partSearchComboBox.Name = "partSearchComboBox";
            this.partSearchComboBox.Size = new System.Drawing.Size(62, 24);
            this.partSearchComboBox.TabIndex = 16;
            // 
            // productSearchComboBox
            // 
            this.productSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchComboBox.FormattingEnabled = true;
            this.productSearchComboBox.Location = new System.Drawing.Point(767, 77);
            this.productSearchComboBox.Name = "productSearchComboBox";
            this.productSearchComboBox.Size = new System.Drawing.Size(62, 24);
            this.productSearchComboBox.TabIndex = 16;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 632);
            this.Controls.Add(this.productSearchComboBox);
            this.Controls.Add(this.partSearchComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.partsTableReset);
            this.Controls.Add(this.MainScreenExit);
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
        private System.Windows.Forms.Button MainScreenExit;
        private System.Windows.Forms.Button partsTableReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox partSearchComboBox;
        private System.Windows.Forms.ComboBox productSearchComboBox;
    }
}

