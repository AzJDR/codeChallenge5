using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace codeChallenge5
{
    public partial class MathVersion1 : Form
    {
        public MathVersion1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInput1.Text, out double num1))
            {
                MessageBox.Show("Please enter valid integer values for the numbers.");
                txtInput1.SelectionStart = 0;
                txtInput1.SelectionLength = txtInput1.TextLength;
                txtInput1.Focus();
                return;
            }

            if (!double.TryParse(txtInput2.Text, out double num2))
            {
                MessageBox.Show("Please enter valid integer values for the numbers.");
                txtInput2.SelectionStart = 0;
                txtInput2.SelectionLength = txtInput2.TextLength;
                txtInput2.Focus();
                return;
            }

            string result = "";
            if (rbt_Addition.Checked)
            {
                result = $"sum of {num1} and {num2} is {add(num1, num2)}";
            }
            else if (rbt_Subtraction.Checked)
            {

                result = $"Difference of {num1} and {num2} is {sub(num1, num2)}";
            }
            else if (rbt_Multiplication.Checked)
            {

                result = $"Product of {num1} and {num2} is {mul(num1, num2)}";
            }
            else if (rbt_Division.Checked)
            {

                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.");
                    return;
                }
                result = $"Quotient of {num1} and {num2} is {div(num1, num2)}";
            }
            else if (rbt_Modulus.Checked)
            {
                
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot perform modulus operation with zero divisor.");
                    return;
                }
                result = $"Remainder of {num1} and {num2} is {mod(num1, num2)}";
            }
            else
            {
                MessageBox.Show("Please select an operation.");
                return;
            }            
            MessageBox.Show($"{result}");
        }
        public static double add(double n1, double n2)
        {
            return (n1 + n2);
        }
        public static double sub(double n1, double n2)
        {
            return (n1 - n2);
        }
        public static double mul(double n1, double n2)
        {
            return (n1 * n2);
        }
        public static double div(double n1, double n2)
        {
            return (n1 / n2);
        }
        public static double mod(double n1, double n2)
        {
            return (n1 % n2);
        }

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";

            rbt_Addition.Checked = false;
            rbt_Subtraction.Checked = false;
            rbt_Multiplication.Checked = false;
            rbt_Division.Checked = false;
            rbt_Modulus.Checked = false;
            txtInput1.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Show();
            this.Hide();
        }
    }
}
