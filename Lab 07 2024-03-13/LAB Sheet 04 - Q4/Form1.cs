using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_Sheet_04___Q4
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result_value = 0;
        bool is_operatio_perfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void operatio_perfomed(object sender, EventArgs e)
        {
                if (result_value != 0)
                {
                    button4.PerformClick();
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(textBox1.Text);
                    label1.Text = result_value + operation;
                    is_operatio_perfomed = true;


                }

                else
                {
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(textBox1.Text);
                    label1.Text = result_value + operation;
                    is_operatio_perfomed = true;
                }
            
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || is_operatio_perfomed) 
            {
                textBox1.Clear(); // clear intial value
            }
            Button btn = (Button)sender;

            if(btn.Text == ".") 
            { 
               if(textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }

            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }

            is_operatio_perfomed = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; //Clear Button
            label1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (result_value + double.Parse(textBox1.Text)).ToString();
                        break;

                    case "-":
                        textBox1.Text = (result_value - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (result_value * double.Parse(textBox1.Text)).ToString();
                        break;

                    case "/":
                        //if (double.Parse(textBox1.Text) == 0)
                        //{
                        //   throw now DividByZeroException();
                        //}
                        textBox1.Text = (result_value / double.Parse(textBox1.Text)).ToString();
                        break;
                }
            }
            catch(FormatException) 
            {
                MessageBox.Show("Enter Valid number", "Error");
            }
            catch (DivideByZeroException)
            {

                MessageBox.Show("Cannot Divide by Zero", "Error");

            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

