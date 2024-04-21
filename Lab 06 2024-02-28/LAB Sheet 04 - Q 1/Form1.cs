using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_Sheet_04___Q_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number1) && int.TryParse(textBox2.Text, out int number2))
            {
                int result = number1 + number2;
               label3.Text = "Result: " + result.ToString();
            }
            else
            {
                label3.Text = "Please enter valid numbers.";
            }

        }
    }
}
