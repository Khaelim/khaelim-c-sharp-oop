using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp_Ass_Prep_
{
    public partial class Form1 : Form
    {
        decimal discount, gloss, water, oil;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!isValidData())
            {
                return;
            }
            discount = Convert.ToDecimal(txtDiscount.Text);
            gloss = Convert.ToDecimal(txtGloss.Text);
            water = Convert.ToDecimal(txtWater.Text);
            oil = Convert.ToDecimal(txtOil.Text);
            //remove all but the paint options add rBt's
            lblPrices.Visible = false;
            lblDiscount.Visible = false;
            txtDiscount.Visible = false;
            txtGloss.Visible = false;
            txtOil.Visible = false;
            txtWater.Visible = false;
            //make total lbl, txt and new gbx visable 
            gbxPaintType.Visible = true;
            lblTotal.Visible = true;
            txtTotal.Visible = true;
            //remove this button and make others visable
            btnContinue.Visible = false;
            btnCalculate.Visible = true;
            btnExit.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbtGloss.Checked)
            {
                txtTotal.Text = ""+ calculatePrice(gloss);
                lblSummary.Text = (rbtPremium.Checked) ? $"Premium Gloss selected with {discount}% discount" : $"Gloss selected with {discount}% discount";
            }
            if (rbtOil.Checked)
            {
                txtTotal.Text = "" + calculatePrice(oil);
                lblSummary.Text = (rbtPremium.Checked) ? $"Premium Oil selected with {discount}% discount" : $"Oil selected with {discount}% discount";
            }
            if (rbtWater.Checked)
            {
                txtTotal.Text = "" + calculatePrice(water);
                lblSummary.Text = (rbtPremium.Checked) ? $"Premium Water selected with {discount}% discount" : $"Water selected with {discount}% discount";
            }
            lblSummary.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit this application?", "Exit", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rbtPremium_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void rbtRegular_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void rbtOil_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void rbtWater_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void rbtGloss_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        //Clear total and summary
        private void clear()
        {
            txtTotal.Text = "";
            lblSummary.Visible = false;
        }

        //Validations 
        private bool isPresent(TextBox textBox, String name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        //is Decimal

        private bool isDecimal(TextBox textBox, String name)
        {
            Decimal temp;
            if (Decimal.TryParse(textBox.Text, out temp))
            {
                return true;
            }
            MessageBox.Show(name + " must be a Decimal.", "Entry Error");
            textBox.Focus();
            return false;
        }

        

        //is within range
        private bool isWithinRange(TextBox textBox, String name)
        {
            decimal value = Convert.ToDecimal(textBox.Text);
            if ((value < 0 || value > 100)&&name.Equals("Discount"))
            {
                MessageBox.Show(name + " must be between 0 and 100", "Entry Error");
                textBox.Focus();
                return false;
            }
            if (value<0)
            {
                MessageBox.Show(name + " must be greater than 0", "Entry Error");
                textBox.Focus();
                return false;

            }
            return true;
        }
        //checking some stuff
        private bool isValidData()
        {
            if (!isPresent(txtDiscount, "Discount") || !isPresent(txtGloss, "Gloss paint price") || !isPresent(txtOil, "Oil Based paint price") || !isPresent(txtWater, "Water based paint price")) return false;
            if (!isDecimal(txtDiscount, "Discount") || !isDecimal(txtGloss, "Gloss paint price") || !isDecimal(txtOil, "Oil Based paint price") || !isDecimal(txtWater, "Water based paint price")) return false;
            if (!isWithinRange(txtDiscount, "Discount") || !isWithinRange(txtGloss, "Gloss paint price") || !isWithinRange(txtOil, "Oil Based paint price") || !isWithinRange(txtWater, "Water based paint price")) return false;
            return true;
        }

        private decimal calculatePrice(decimal price)
        {
            if (rbtPremium.Checked)
            {
                price += price / 2;
            }
            price = price - price * (discount / 100);
            return price;
        }
    }
}
