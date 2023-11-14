using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class HugeNumberForm : Form
    {
        public HugeNumberForm()
        {
            InitializeComponent();
        }

       
        private void addBtn_Click(object sender, EventArgs e)
        {
            resultText.Text = new HugeInteger(hugeNb1.Text).Add(new HugeInteger(hugeNb2.Text)).ToString();
        }
        private void multiplyBtn_Click(object sender, EventArgs e)
        { 
            resultText.Text = new HugeInteger(hugeNb1.Text).Multiply(new HugeInteger(hugeNb2.Text)).ToString();
        }

        private void substractBtn_Click(object sender, EventArgs e)
        {
            resultText.Text = new HugeInteger(hugeNb1.Text).Subtract(new HugeInteger(hugeNb2.Text)).ToString();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            HugeInteger num1 = new HugeInteger(hugeNb1.Text);
            HugeInteger num2 = new HugeInteger(hugeNb2.Text);
            HugeInteger answer = num1.Divide(num2);
            if (answer == null)
            {
                resultText.Text = "ERROR: CANNOT DIVIDE BY 0";
            }
            else 
            {
                resultText.Text = answer.ToString();
            }
        }

        private void remainderBtn_Click(object sender, EventArgs e)
        {
            resultText.Text = new HugeInteger(hugeNb1.Text).Remainder(new HugeInteger(hugeNb2.Text)).ToString();
        }

        private void isEqualBtn_Click(object sender, EventArgs e)
        {
            HugeInteger num1 = new HugeInteger(hugeNb1.Text);
            HugeInteger num2 = new HugeInteger(hugeNb2.Text);
            if (num1.IsEqualTo(num2))
                resultText.Text = "True";
            else
                resultText.Text = "False";
        }

        private void isNotEqualBtn_Click(object sender, EventArgs e)
        {
            HugeInteger num1 = new HugeInteger(hugeNb1.Text);
            HugeInteger num2 = new HugeInteger(hugeNb2.Text);
            if (num1.IsNotEqualTo(num2))
                resultText.Text = "True";
            else
                resultText.Text = "False";
        }

        private void isGreaterThanBtn_Click(object sender, EventArgs e)
        {
            HugeInteger num1 = new HugeInteger(hugeNb1.Text);
            HugeInteger num2 = new HugeInteger(hugeNb2.Text);
            if (num1.IsGreaterThan(num2))
                resultText.Text = "True";
            else
                resultText.Text = "False";
        }

        private void isLessThanBtn_Click(object sender, EventArgs e)
        {
            HugeInteger num1 = new HugeInteger(hugeNb1.Text);
            HugeInteger num2 = new HugeInteger(hugeNb2.Text);
            if (num1.IsLessThan(num2))
                resultText.Text = "True";
            else
                resultText.Text = "False";
        }

        private void isGreaterThanOrEqualBtn_Click(object sender, EventArgs e)
        {
            HugeInteger num1 = new HugeInteger(hugeNb1.Text);
            HugeInteger num2 = new HugeInteger(hugeNb2.Text);
            if (num1.IsGreaterThanOrEqualTo(num2))
                resultText.Text = "True";
            else
                resultText.Text = "False";
        }

        private void isLessThanOrEqualBtn_Click(object sender, EventArgs e)
        {
            HugeInteger num1 = new HugeInteger(hugeNb1.Text);
            HugeInteger num2 = new HugeInteger(hugeNb2.Text);
            if (num1.IsLessThanOrEqualTo(num2))
                resultText.Text = "True";
            else
                resultText.Text = "False";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            hugeNb1.Text = "";
            hugeNb2.Text = "";
            resultText.Text = "";
        }


    }
}
