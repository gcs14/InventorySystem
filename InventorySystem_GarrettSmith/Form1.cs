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

            dgvProducts.DataSource = model.Product.Products;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
