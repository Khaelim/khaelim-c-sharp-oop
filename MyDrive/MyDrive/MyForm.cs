using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDrive
{
    public partial class frmEstimate : Form
    {
        //global variables for prices
        decimal rate, brick, concrete, tarmac, gravel;
        public frmEstimate()
        {
            InitializeComponent();
        }
        //when the start button is clicked
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isValidStartData1()) //checking if the data inputed on the forms first view is valid, if not the code below will not execute
            {
                return;
            }
            //if data is valid assingn it to global variables
            rate = Convert.ToDecimal(txtExchangeRate.Text);
            brick = Convert.ToDecimal(txtBrickPrice.Text);
            concrete = Convert.ToDecimal(txtConcretePrice.Text);
            tarmac = Convert.ToDecimal(txtTarmacPrice.Text);
            gravel = Convert.ToDecimal(txtGravelPrice.Text);
            //removing fields required for the first view and adding fields for the secoind view
            stageTwo();
            txtGBP.Text = "" + 1;
            txtEuro.Text = "" + (1 * rate);
        }
        //when the calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!isValidStartData2()) //checking if the data inputed on the forms second view is valid, if not the code below will not execute
            {
                return;
            }
            //if it is valid assign the length and width to variables
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width = Convert.ToDecimal(txtWidth.Text);
            decimal price=0;
            //calculating the price based on the material type and foundation depth then adding information to the label
            if (rbtBrick.Checked)
            {
                price = calculatePrice(length, width, brick);
                lblOutput.Text = (rbtExtraDeep.Checked) ? "Brick selected with Extra Deep foundation" : $"Brick selected with Standard foundation";
            }
            if (rbtConcrete.Checked)
            {
                price = calculatePrice(length, width, concrete);
                lblOutput.Text = (rbtExtraDeep.Checked) ? "Concrete selected with Extra Deep foundation" : $"Concrete selected with Standard foundation";
            }
            if (rbtTarmac.Checked)
            {
                price = calculatePrice(length, width, tarmac);
                lblOutput.Text = (rbtExtraDeep.Checked) ? "Tarmac selected with Extra Deep foundation" : $"Tarmac selected with Standard foundation";
            }
            if (rbtGravel.Checked)
            {
                price = calculatePrice(length, width, gravel);
                lblOutput.Text = (rbtExtraDeep.Checked) ? "Gravel selected with Extra Deep foundation" : $"Gravel selected with Standard foundation";
            }
            lblOutput.BackColor = System.Drawing.Color.White;//setting label background colour to white
            //displaying the prices in appropriate currency
            txtGBP.Text = String.Format("£{0:0.00}", price);
            txtEuro.Text = String.Format("€{0:0.00}", (price*rate));
        }
        //when the clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing the text boxes and setting the output label to green
            txtEuro.Text = "" + rate;
            txtGBP.Text = "" + 1;
            txtLength.Text = "";
            txtWidth.Text = "";
            lblOutput.Text = "                                                                   ";
            lblOutput.BackColor= System.Drawing.Color.Green;
        }
        //when the exit menu item is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display the messagebox
            DialogResult exit = MessageBox.Show("Are you sure you want to exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if the user clicks yes the program exits
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //change to second view
        private void stageTwo()
        {
            //making the price boxes and labels invisable
            txtExchangeRate.Visible = false;
            txtBrickPrice.Visible = false;
            txtConcretePrice.Visible = false;
            txtTarmacPrice.Visible = false;
            txtGravelPrice.Visible = false;
            lblExchangeRate.Visible = false;
            lblExchangeRateTrailer.Visible = false;
            lblMeterPrice.Visible = false;
            //change top label to green
            label1.ForeColor = System.Drawing.Color.Green;
            //making new groupbox visable#
            grpFoundations.Visible = true;
            //labels
            lblLength.Visible = true;
            lblWidth.Visible = true;
            lblMeters1.Visible = true;
            lblMeters2.Visible = true;
            lblEuro.Visible = true;
            lblGBP.Visible = true;
            lblOutput.Visible = true;
            //textboxes
            txtEuro.Visible = true;
            txtGBP.Visible = true;
            txtLength.Visible = true;
            txtWidth.Visible = true;
            //make start button invisible
            cmdStart.Visible = false;
            //new buttons visible
            cmdCalculate.Visible = true;
            cmdClear.Visible = true;
        }
        //to check if a text box contains text 
        private bool isPresent(TextBox textBox, String name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Exchange rate or Prices not entered", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Focus();
                return false;
            }
            return true;
        }
        //to check if a textbox containss a Decimal
        private bool isDecimal(TextBox textBox, String name)
        {
            Decimal temp;
            if (Decimal.TryParse(textBox.Text, out temp))
            {
                return true;
            }
            MessageBox.Show(name + " must be a Decimal.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBox.Focus();
            return false;
        }

        //using the above menthods to validate data for the first view
        private bool isValidStartData1()
        {
            if (!isPresent(txtExchangeRate, "Exchange rate") || !isPresent(txtBrickPrice, "Brick price") || !isPresent(txtConcretePrice, "Concrete price") || !isPresent(txtGravelPrice, "Gravel price") || !isPresent(txtTarmacPrice, "Tarmac price")) return false;
            if (!isDecimal(txtExchangeRate, "Exchange rate") || !isDecimal(txtBrickPrice, "Brick price") || !isDecimal(txtConcretePrice, "Concrete price") || !isDecimal(txtGravelPrice, "Gravel price") || !isDecimal(txtTarmacPrice, "Tarmac price")) return false;
            return true;
        }
        //to validate data for the first second view
        private bool isValidStartData2()
        {
            if ((txtLength.Text == "") || (txtWidth.Text == ""))
            {
                MessageBox.Show("Length or Width not not entered.\nPlease enter dimensions", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!isDecimal(txtLength, "Length") || !isDecimal(txtWidth, "Width")) return false;

            return true;
        }
        //method to calculate the price
        private decimal calculatePrice(decimal length, decimal width, decimal price)
        {
            decimal newPrice=(length*width)*price;

            if (rbtExtraDeep.Checked)
            {
                newPrice += newPrice / 4;
            }
            return newPrice;
        }
    }
}
