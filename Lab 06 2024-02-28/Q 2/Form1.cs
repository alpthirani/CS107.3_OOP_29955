using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxOperand1.Text, out double operand1) || !double.TryParse(textBoxOperand2.Text, out double operand2))
            {
                MessageBox.Show("Please enter valid numbers for operands.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Invalid operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            labelResult.Text = "Result: " + result.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
