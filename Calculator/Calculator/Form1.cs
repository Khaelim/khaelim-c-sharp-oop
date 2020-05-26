using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            equals();
            if (txtResult.TextLength>0)
            {
                txtResult.Text += "/";
            }
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            equals();
            if (txtResult.TextLength > 0)
            {
                txtResult.Text += "*";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            equals();
            if (txtResult.TextLength > 0)
            {
                txtResult.Text += "-";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            equals();
            if (txtResult.TextLength > 0)
            {
                txtResult.Text += "+";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            equals();
            txtResult.Text = ""+Calculator.sqrt(Convert.ToDouble(txtResult.Text));
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            equals();


        }

        private void equals()
        {
            int operatorIndex;
            //string[] operands;
            operatorIndex = txtResult.Text.IndexOf("/");

            if (operatorIndex > 0)
            {
                string[] operands = txtResult.Text.Split('/');
                txtResult.Text = "" + Calculator.divide(Convert.ToDouble(operands[0]), Convert.ToDouble(operands[1]));
            }

            operatorIndex = txtResult.Text.IndexOf("*");

            if (operatorIndex > 0)
            {
                string[] operands = txtResult.Text.Split('*');
                txtResult.Text = "" + Calculator.multiply(Convert.ToDouble(operands[0]), Convert.ToDouble(operands[1]));
            }

            operatorIndex = txtResult.Text.IndexOf("+");

            if (operatorIndex > 0)
            {
                string[] operands = txtResult.Text.Split('+');
                txtResult.Text = "" + Calculator.add(Convert.ToDouble(operands[0]), Convert.ToDouble(operands[1]));
            }

            operatorIndex = txtResult.Text.IndexOf("-");

            if (operatorIndex > 0)
            {
                string[] operands = txtResult.Text.Split('-');
                txtResult.Text = "" + Calculator.subtract(Convert.ToDouble(operands[0]), Convert.ToDouble(operands[1]));
            }

            

        }

        
    }
}
