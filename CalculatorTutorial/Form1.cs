using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string operation;
        private int value1;

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += btn.Text;
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //public string operation = btn.Text;
            operation = btn.Text;
            value1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            int value2 = Convert.ToInt32(textBox1.Text);
            int result;

            if(operation == "+")
            {
                result = value1 + value2;
            }else if(operation == "-")
            {
                result = value1 - value2;
            }
            else if(operation == "*")
            {
                result = value1 * value2;
            }
            else
            {
                if(value2 != 0)
                {
                    result = value1 / value2;
                }
                else
                {
                    string msg = "Dividing by 0 may create a blackhole and is not advised.";
                    string title = "Oops";
                    MessageBoxButtons btns = MessageBoxButtons.OK;

                    MessageBox.Show(msg, title, btns);
                    return;
                }
            }

            textBox1.Text = Convert.ToString(result);

        }
    }
}
