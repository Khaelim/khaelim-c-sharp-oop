using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintence
{
    public partial class AddItemForm : Form
    {
        public Product Pro { get; set; }
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemNo.Text is String && txtItemNo.Text != "" && txtDescription.Text is String && txtDescription.Text != "" && txtPrice.Text != null)
            {
                //do the bit for the other ones




                Pro = returnProduct();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private Product returnProduct()
        {
            return new Product(txtItemNo.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
