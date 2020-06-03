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
        public Plant Pla { get; set; }
        public Supply Sup { get; set; }
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemNo.Text is String && txtItemNo.Text != "" && txtDescription.Text is String && txtDescription.Text != "" && txtPrice.Text != null&&cbxManuSize.Text!=null)
            {
                //do the bit for the other ones
                if (rbtPlant.Checked)
                {
                    Pla = returnPlant();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                if (rbtSupply.Checked)
                {
                    Sup = returnSupply();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


                //Pro = returnProduct();
                //this.DialogResult = DialogResult.OK;
                //this.Close();
            }
        }
        private Plant returnPlant()
        {
            return new Plant(cbxManuSize.Text, txtItemNo.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
        }
        private Supply returnSupply()
        {
            return new Supply(cbxManuSize.Text, txtItemNo.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
        }
        //private Product returnProduct()
        //{
        //    return new Product(txtItemNo.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtPlant_CheckedChanged(object sender, EventArgs e)
        {
            labManuSize.Text = "Size:";
            cbxManuSize.Items.Clear();
            cbxManuSize.Items.Add("500 ml");
            cbxManuSize.Items.Add("1 liter");
            cbxManuSize.Items.Add("2 liter");
            cbxManuSize.Items.Add("5 gallon");
        }

        private void rbtSupply_CheckedChanged(object sender, EventArgs e)
        {
            labManuSize.Text = "Manufacturer:";
            cbxManuSize.Items.Clear();
            cbxManuSize.Items.Add("Scott");
            cbxManuSize.Items.Add("Bad");
            cbxManuSize.Items.Add("Good");
            cbxManuSize.Items.Add("Super");
        }
    }
}
