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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace codeChallenge5
{
    public partial class MathVersion2 : Form
    {
        public MathVersion2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            groupBox3.Controls.Clear(); // Clear previous results

            if (cb_Addition.Checked)
            {
                string result = $"Sum of {num1} and {num2} is {add(num1, num2)}";
                AddResultLabel(result);
            }

            if (cb_Multiplication.Checked)
            {
                string result = $"Product of {num1} and {num2} is {mul(num1, num2)}";
                AddResultLabel(result);
            }

            if (cb_Modulus.Checked)
            {
                if (num2 == 0)
                {
                    AddResultLabel("Cannot perform modulus operation with zero divisor.");
                }
                else
                {
                    string result = $"Modulus of {num1} and {num2} is {mod(num1, num2)}";
                    AddResultLabel(result);
                }
            }

            if (cb_Subtraction.Checked)
            {
                string result = $"Difference of {num1} and {num2} is {sub(num1, num2)}";
                AddResultLabel(result);
            }

            if (cb_Division.Checked)
            {
                if (num2 == 0)
                {
                    AddResultLabel("Cannot divide by zero.");
                }
                else
                {
                    string result = $"Quotient of {num1} and {num2} is {div(num1, num2)}";
                    AddResultLabel(result);
                }
            }

            if (cb_Exponential.Checked)
            {
                string result = $"Exponential of {num1} and {num2} is {exp(num1, num2)}";
                AddResultLabel(result);
            }

            if (!cb_Addition.Checked && !cb_Subtraction.Checked && !cb_Multiplication.Checked && !cb_Division.Checked && !cb_Modulus.Checked && !cb_Exponential.Checked)
            {
                MessageBox.Show("Please select an operation.");
                return;
            }
        }

        private void AddResultLabel(string result)
        {
            Label label = new Label();
            label.Text = result;
            label.Font = new Font("Andale Mono", 11, FontStyle.Regular);
            label.AutoSize = true;

            int labelIndex = groupBox3.Controls.Count + 1;
            label.Location = new Point(15, 30 * labelIndex);

            groupBox3.Controls.Add(label);
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
        public static double exp(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";

            cb_Addition.Checked = false;
            cb_Subtraction.Checked = false;
            cb_Multiplication.Checked = false;
            cb_Division.Checked = false;
            cb_Modulus.Checked = false;
            cb_Exponential.Checked = false;

            groupBox3.Controls.Clear();

            txtInput1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Show();
            this.Hide();
        }


    }
}
