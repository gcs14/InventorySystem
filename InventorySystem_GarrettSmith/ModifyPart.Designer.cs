namespace InventorySystem_GarrettSmith
{
    partial class ModifyPart
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modifyPartMinLabel = new System.Windows.Forms.Label();
            this.modifyPartMaxLabel = new System.Windows.Forms.Label();
            this.toggleLabel = new System.Windows.Forms.Label();
            this.modifyPartPriceLabel = new System.Windows.Forms.Label();
            this.modifyPartNameLabel = new System.Windows.Forms.Label();
            this.modifyPartInventoryLabel = new System.Windows.Forms.Label();
            this.modifyPartMin = new System.Windows.Forms.TextBox();
            this.modifyPartIDLabel = new System.Windows.Forms.Label();
            this.modifyPartFlexText = new System.Windows.Forms.TextBox();
            this.modifyPartMax = new System.Windows.Forms.TextBox();
            this.modifyPartPrice = new System.Windows.Forms.TextBox();
            this.modifyPartInventory = new System.Windows.Forms.TextBox();
            this.modifyPartName = new System.Windows.Forms.TextBox();
            this.modifyPartID = new System.Windows.Forms.TextBox();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.inhouseRadio = new System.Windows.Forms.RadioButton();
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(415, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ModifyPartCancel_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ModifyPartSave_Click);
            // 
            // modifyPartMinLabel
            // 
            this.modifyPartMinLabel.AutoSize = true;
            this.modifyPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMinLabel.Location = new System.Drawing.Point(290, 304);
            this.modifyPartMinLabel.Name = "modifyPartMinLabel";
            this.modifyPartMinLabel.Size = new System.Drawing.Size(41, 24);
            this.modifyPartMinLabel.TabIndex = 21;
            this.modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartMaxLabel
            // 
            this.modifyPartMaxLabel.AutoSize = true;
            this.modifyPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMaxLabel.Location = new System.Drawing.Point(95, 303);
            this.modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            this.modifyPartMaxLabel.Size = new System.Drawing.Size(46, 24);
            this.modifyPartMaxLabel.TabIndex = 20;
            this.modifyPartMaxLabel.Text = "Max";
            // 
            // toggleLabel
            // 
            this.toggleLabel.AutoSize = true;
            this.toggleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleLabel.Location = new System.Drawing.Point(55, 355);
            this.toggleLabel.Name = "toggleLabel";
            this.toggleLabel.Size = new System.Drawing.Size(105, 24);
            this.toggleLabel.TabIndex = 19;
            this.toggleLabel.Text = "Machine ID";
            // 
            // modifyPartPriceLabel
            // 
            this.modifyPartPriceLabel.AutoSize = true;
            this.modifyPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartPriceLabel.Location = new System.Drawing.Point(95, 254);
            this.modifyPartPriceLabel.Name = "modifyPartPriceLabel";
            this.modifyPartPriceLabel.Size = new System.Drawing.Size(53, 24);
            this.modifyPartPriceLabel.TabIndex = 18;
            this.modifyPartPriceLabel.Text = "Price";
            // 
            // modifyPartNameLabel
            // 
            this.modifyPartNameLabel.AutoSize = true;
            this.modifyPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartNameLabel.Location = new System.Drawing.Point(89, 154);
            this.modifyPartNameLabel.Name = "modifyPartNameLabel";
            this.modifyPartNameLabel.Size = new System.Drawing.Size(61, 24);
            this.modifyPartNameLabel.TabIndex = 22;
            this.modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartInventoryLabel
            // 
            this.modifyPartInventoryLabel.AutoSize = true;
            this.modifyPartInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartInventoryLabel.Location = new System.Drawing.Point(70, 205);
            this.modifyPartInventoryLabel.Name = "modifyPartInventoryLabel";
            this.modifyPartInventoryLabel.Size = new System.Drawing.Size(86, 24);
            this.modifyPartInventoryLabel.TabIndex = 16;
            this.modifyPartInventoryLabel.Text = "Inventory";
            // 
            // modifyPartMin
            // 
            this.modifyPartMin.AcceptsReturn = true;
            this.modifyPartMin.AcceptsTab = true;
            this.modifyPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMin.Location = new System.Drawing.Point(359, 303);
            this.modifyPartMin.Name = "modifyPartMin";
            this.modifyPartMin.Size = new System.Drawing.Size(86, 26);
            this.modifyPartMin.TabIndex = 26;
            // 
            // modifyPartIDLabel
            // 
            this.modifyPartIDLabel.AutoSize = true;
            this.modifyPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartIDLabel.Location = new System.Drawing.Point(115, 108);
            this.modifyPartIDLabel.Name = "modifyPartIDLabel";
            this.modifyPartIDLabel.Size = new System.Drawing.Size(27, 24);
            this.modifyPartIDLabel.TabIndex = 17;
            this.modifyPartIDLabel.Text = "ID";
            // 
            // modifyPartFlexText
            // 
            this.modifyPartFlexText.AcceptsReturn = true;
            this.modifyPartFlexText.AcceptsTab = true;
            this.modifyPartFlexText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartFlexText.Location = new System.Drawing.Point(164, 355);
            this.modifyPartFlexText.Name = "modifyPartFlexText";
            this.modifyPartFlexText.Size = new System.Drawing.Size(198, 26);
            this.modifyPartFlexText.TabIndex = 27;
            this.modifyPartFlexText.Leave += new System.EventHandler(this.ModifyPartMachineIDValidation);
            // 
            // modifyPartMax
            // 
            this.modifyPartMax.AcceptsReturn = true;
            this.modifyPartMax.AcceptsTab = true;
            this.modifyPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMax.Location = new System.Drawing.Point(164, 303);
            this.modifyPartMax.Name = "modifyPartMax";
            this.modifyPartMax.Size = new System.Drawing.Size(86, 26);
            this.modifyPartMax.TabIndex = 25;
            // 
            // modifyPartPrice
            // 
            this.modifyPartPrice.AcceptsReturn = true;
            this.modifyPartPrice.AcceptsTab = true;
            this.modifyPartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartPrice.Location = new System.Drawing.Point(164, 253);
            this.modifyPartPrice.Name = "modifyPartPrice";
            this.modifyPartPrice.Size = new System.Drawing.Size(198, 26);
            this.modifyPartPrice.TabIndex = 24;
            // 
            // modifyPartInventory
            // 
            this.modifyPartInventory.AcceptsReturn = true;
            this.modifyPartInventory.AcceptsTab = true;
            this.modifyPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartInventory.Location = new System.Drawing.Point(164, 205);
            this.modifyPartInventory.Name = "modifyPartInventory";
            this.modifyPartInventory.Size = new System.Drawing.Size(198, 26);
            this.modifyPartInventory.TabIndex = 23;
            this.modifyPartInventory.Leave += new System.EventHandler(this.ModifyPartInventoryValidation);
            // 
            // modifyPartName
            // 
            this.modifyPartName.AcceptsReturn = true;
            this.modifyPartName.AcceptsTab = true;
            this.modifyPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartName.Location = new System.Drawing.Point(164, 154);
            this.modifyPartName.Name = "modifyPartName";
            this.modifyPartName.Size = new System.Drawing.Size(198, 26);
            this.modifyPartName.TabIndex = 15;
            this.modifyPartName.Leave += new System.EventHandler(this.ModifyPartNameValidation);
            // 
            // modifyPartID
            // 
            this.modifyPartID.Enabled = false;
            this.modifyPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartID.Location = new System.Drawing.Point(164, 106);
            this.modifyPartID.Name = "modifyPartID";
            this.modifyPartID.Size = new System.Drawing.Size(198, 26);
            this.modifyPartID.TabIndex = 14;
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedRadio.Location = new System.Drawing.Point(293, 12);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(130, 28);
            this.outsourcedRadio.TabIndex = 13;
            this.outsourcedRadio.TabStop = true;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // inhouseRadio
            // 
            this.inhouseRadio.AutoSize = true;
            this.inhouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inhouseRadio.Location = new System.Drawing.Point(171, 12);
            this.inhouseRadio.Name = "inhouseRadio";
            this.inhouseRadio.Size = new System.Drawing.Size(108, 28);
            this.inhouseRadio.TabIndex = 12;
            this.inhouseRadio.TabStop = true;
            this.inhouseRadio.Text = "In-House";
            this.inhouseRadio.UseVisualStyleBackColor = true;
            this.inhouseRadio.CheckedChanged += new System.EventHandler(this.InhouseRadio_CheckedChanged);
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(188, 39);
            this.modifyPartLabel.TabIndex = 11;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modifyPartMinLabel);
            this.Controls.Add(this.modifyPartMaxLabel);
            this.Controls.Add(this.toggleLabel);
            this.Controls.Add(this.modifyPartPriceLabel);
            this.Controls.Add(this.modifyPartNameLabel);
            this.Controls.Add(this.modifyPartInventoryLabel);
            this.Controls.Add(this.modifyPartMin);
            this.Controls.Add(this.modifyPartIDLabel);
            this.Controls.Add(this.modifyPartFlexText);
            this.Controls.Add(this.modifyPartMax);
            this.Controls.Add(this.modifyPartPrice);
            this.Controls.Add(this.modifyPartInventory);
            this.Controls.Add(this.modifyPartName);
            this.Controls.Add(this.modifyPartID);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.inhouseRadio);
            this.Controls.Add(this.modifyPartLabel);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label modifyPartMinLabel;
        private System.Windows.Forms.Label modifyPartMaxLabel;
        private System.Windows.Forms.Label toggleLabel;
        private System.Windows.Forms.Label modifyPartPriceLabel;
        private System.Windows.Forms.Label modifyPartNameLabel;
        private System.Windows.Forms.Label modifyPartInventoryLabel;
        private System.Windows.Forms.Label modifyPartIDLabel;
        private System.Windows.Forms.TextBox modifyPartID;
        private System.Windows.Forms.Label modifyPartLabel;
        internal System.Windows.Forms.TextBox modifyPartMin;
        internal System.Windows.Forms.TextBox modifyPartFlexText;
        internal System.Windows.Forms.TextBox modifyPartMax;
        internal System.Windows.Forms.TextBox modifyPartPrice;
        internal System.Windows.Forms.TextBox modifyPartInventory;
        internal System.Windows.Forms.TextBox modifyPartName;
        internal System.Windows.Forms.RadioButton outsourcedRadio;
        internal System.Windows.Forms.RadioButton inhouseRadio;
    }
}