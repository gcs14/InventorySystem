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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystem_GarrettSmith
{
    public partial class ModifyPartScreen : Form
    {
        public ModifyPartScreen(Inhouse part)
        {
            InitializeComponent();

            modifyPartID.Text = part.PartID.ToString();
            modifyPartName.Text = part.Name;
            modifyPartInventory.Text = part.InStock.ToString();
            modifyPartPrice.Text = part.Price.ToString();
            modifyPartMax.Text = part.Max.ToString();
            modifyPartMin.Text = part.Min.ToString();
            modifyFlexText.Text = part.MachineID.ToString();
            inhouseRadio.Checked = true;
            //toggleLabel.Text = "Machine ID";
            //toggleLabel.Location = new Point(55, 355);
        }

        public ModifyPartScreen(Outsourced part)
        {
            InitializeComponent();
            modifyPartID.Text = part.PartID.ToString();
            modifyPartName.Text = part.Name;
            modifyPartInventory.Text = part.InStock.ToString();
            modifyPartPrice.Text = part.Price.ToString();
            modifyPartMax.Text = part.Max.ToString();
            modifyPartMin.Text = part.Min.ToString();
            modifyFlexText.Text = part.CompanyName;
            outsourcedRadio.Checked = true;
            //toggleLabel.Text = "Company Name";
            //toggleLabel.Location = new Point(21, 356);
        }

        private void inhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Machine ID";
            toggleLabel.Location = new Point(55, 355);
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            toggleLabel.Text = "Company Name";
            toggleLabel.Location = new Point(21, 356);
        }
    }
}
