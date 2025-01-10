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
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.inhouseRadio = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.addPartName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPartInventory = new System.Windows.Forms.TextBox();
            this.addPartPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addPartMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPartMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addPartFlexText = new System.Windows.Forms.TextBox();
            this.toggleLabel = new System.Windows.Forms.Label();
            this.addPartSaveBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLabel.Location = new System.Drawing.Point(12, 9);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(119, 31);
            this.AddPartLabel.TabIndex = 0;
            this.AddPartLabel.Text = "Add Part";
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
            this.inhouseRadio.CheckedChanged += new System.EventHandler(this.inhouseRadio_CheckedChanged);
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
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourcedRadio_CheckedChanged);
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
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIDLabel.Location = new System.Drawing.Point(115, 108);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(22, 18);
            this.partIDLabel.TabIndex = 3;
            this.partIDLabel.Text = "ID";
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
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
            this.addPartInventory.Leave += new System.EventHandler(this.AddPartInventoryValidation);
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
            this.addPartPrice.Leave += new System.EventHandler(this.AddPartPriceValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
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
            this.addPartMax.Leave += new System.EventHandler(this.AddPartMaxValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max";
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
            this.addPartMin.Leave += new System.EventHandler(this.AddPartMinValidation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Min";
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPartMin);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.addPartFlexText);
            this.Controls.Add(this.addPartMax);
            this.Controls.Add(this.addPartPrice);
            this.Controls.Add(this.addPartInventory);
            this.Controls.Add(this.addPartName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.inhouseRadio);
            this.Controls.Add(this.AddPartLabel);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.RadioButton inhouseRadio;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.TextBox addPartName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addPartInventory;
        private System.Windows.Forms.TextBox addPartPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addPartMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addPartMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addPartFlexText;
        private System.Windows.Forms.Label toggleLabel;
        private System.Windows.Forms.Button addPartSaveBtn;
        private System.Windows.Forms.Button button2;
    }
}