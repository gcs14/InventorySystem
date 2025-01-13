namespace InventorySystem_GarrettSmith
{
    partial class AddPart
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.inhouseRadio = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartName = new System.Windows.Forms.TextBox();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartInventory = new System.Windows.Forms.TextBox();
            this.addPartPrice = new System.Windows.Forms.TextBox();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartPriceLabel = new System.Windows.Forms.Label();
            this.addPartMax = new System.Windows.Forms.TextBox();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartMin = new System.Windows.Forms.TextBox();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartFlexText = new System.Windows.Forms.TextBox();
            this.toggleLabel = new System.Windows.Forms.Label();
            this.addPartSaveBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(119, 31);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // inhouseRadio
            // 
            this.inhouseRadio.AutoSize = true;
            this.inhouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inhouseRadio.Location = new System.Drawing.Point(171, 12);
            this.inhouseRadio.Name = "inhouseRadio";
            this.inhouseRadio.Size = new System.Drawing.Size(86, 22);
            this.inhouseRadio.TabIndex = 1;
            this.inhouseRadio.TabStop = true;
            this.inhouseRadio.Text = "In-House";
            this.inhouseRadio.UseVisualStyleBackColor = true;
            this.inhouseRadio.CheckedChanged += new System.EventHandler(this.InhouseRadio_CheckedChanged);
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedRadio.Location = new System.Drawing.Point(293, 12);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(104, 22);
            this.outsourcedRadio.TabIndex = 2;
            this.outsourcedRadio.TabStop = true;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(164, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 23);
            this.textBox1.TabIndex = 2;
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartIDLabel.Location = new System.Drawing.Point(115, 108);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(22, 18);
            this.addPartIDLabel.TabIndex = 3;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartName
            // 
            this.addPartName.AcceptsReturn = true;
            this.addPartName.AcceptsTab = true;
            this.addPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartName.Location = new System.Drawing.Point(164, 154);
            this.addPartName.Name = "addPartName";
            this.addPartName.Size = new System.Drawing.Size(198, 23);
            this.addPartName.TabIndex = 3;
            this.addPartName.Leave += new System.EventHandler(this.AddPartNameValidation);
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartNameLabel.Location = new System.Drawing.Point(89, 154);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(48, 18);
            this.addPartNameLabel.TabIndex = 3;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartInventory
            // 
            this.addPartInventory.AcceptsReturn = true;
            this.addPartInventory.AcceptsTab = true;
            this.addPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInventory.Location = new System.Drawing.Point(164, 205);
            this.addPartInventory.Name = "addPartInventory";
            this.addPartInventory.Size = new System.Drawing.Size(198, 23);
            this.addPartInventory.TabIndex = 4;
            // 
            // addPartPrice
            // 
            this.addPartPrice.AcceptsReturn = true;
            this.addPartPrice.AcceptsTab = true;
            this.addPartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPrice.Location = new System.Drawing.Point(164, 253);
            this.addPartPrice.Name = "addPartPrice";
            this.addPartPrice.Size = new System.Drawing.Size(198, 23);
            this.addPartPrice.TabIndex = 5;
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInventoryLabel.Location = new System.Drawing.Point(70, 205);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(67, 18);
            this.addPartInventoryLabel.TabIndex = 3;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartPriceLabel
            // 
            this.addPartPriceLabel.AutoSize = true;
            this.addPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPriceLabel.Location = new System.Drawing.Point(95, 254);
            this.addPartPriceLabel.Name = "addPartPriceLabel";
            this.addPartPriceLabel.Size = new System.Drawing.Size(42, 18);
            this.addPartPriceLabel.TabIndex = 3;
            this.addPartPriceLabel.Text = "Price";
            // 
            // addPartMax
            // 
            this.addPartMax.AcceptsReturn = true;
            this.addPartMax.AcceptsTab = true;
            this.addPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMax.Location = new System.Drawing.Point(164, 303);
            this.addPartMax.Name = "addPartMax";
            this.addPartMax.Size = new System.Drawing.Size(86, 23);
            this.addPartMax.TabIndex = 6;
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMaxLabel.Location = new System.Drawing.Point(95, 303);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(36, 18);
            this.addPartMaxLabel.TabIndex = 3;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartMin
            // 
            this.addPartMin.AcceptsReturn = true;
            this.addPartMin.AcceptsTab = true;
            this.addPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMin.Location = new System.Drawing.Point(359, 303);
            this.addPartMin.Name = "addPartMin";
            this.addPartMin.Size = new System.Drawing.Size(86, 23);
            this.addPartMin.TabIndex = 7;
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMinLabel.Location = new System.Drawing.Point(290, 304);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(32, 18);
            this.addPartMinLabel.TabIndex = 3;
            this.addPartMinLabel.Text = "Min";
            // 
            // addPartFlexText
            // 
            this.addPartFlexText.AcceptsReturn = true;
            this.addPartFlexText.AcceptsTab = true;
            this.addPartFlexText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartFlexText.Location = new System.Drawing.Point(164, 355);
            this.addPartFlexText.Name = "addPartFlexText";
            this.addPartFlexText.Size = new System.Drawing.Size(198, 23);
            this.addPartFlexText.TabIndex = 8;
            this.addPartFlexText.Leave += new System.EventHandler(this.AddPartMachineIDValidation);
            // 
            // toggleLabel
            // 
            this.toggleLabel.AutoSize = true;
            this.toggleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleLabel.Location = new System.Drawing.Point(55, 355);
            this.toggleLabel.Name = "toggleLabel";
            this.toggleLabel.Size = new System.Drawing.Size(82, 18);
            this.toggleLabel.TabIndex = 3;
            this.toggleLabel.Text = "Machine ID";
            // 
            // addPartSaveBtn
            // 
            this.addPartSaveBtn.AutoSize = true;
            this.addPartSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartSaveBtn.Location = new System.Drawing.Point(317, 407);
            this.addPartSaveBtn.Name = "addPartSaveBtn";
            this.addPartSaveBtn.Size = new System.Drawing.Size(75, 27);
            this.addPartSaveBtn.TabIndex = 9;
            this.addPartSaveBtn.Text = "Save";
            this.addPartSaveBtn.UseVisualStyleBackColor = true;
            this.addPartSaveBtn.Click += new System.EventHandler(this.AddPartSave_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(415, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddPartCancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPartSaveBtn);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.toggleLabel);
            this.Controls.Add(this.addPartPriceLabel);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartMin);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.addPartFlexText);
            this.Controls.Add(this.addPartMax);
            this.Controls.Add(this.addPartPrice);
            this.Controls.Add(this.addPartInventory);
            this.Controls.Add(this.addPartName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.inhouseRadio);
            this.Controls.Add(this.addPartLabel);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton inhouseRadio;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.TextBox addPartName;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.TextBox addPartInventory;
        private System.Windows.Forms.TextBox addPartPrice;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.Label addPartPriceLabel;
        private System.Windows.Forms.TextBox addPartMax;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.TextBox addPartMin;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.TextBox addPartFlexText;
        private System.Windows.Forms.Label toggleLabel;
        private System.Windows.Forms.Button addPartSaveBtn;
        private System.Windows.Forms.Button button2;
    }
}