using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
         
            Console.WriteLine($"choice the you want operation 1 : add  2 : sub 3 :mul 4 : div");
            int choice  = int.Parse(textBox3.Text);
          
            switch (choice)

            {
                case 0:
                    choice = num1 + num2;
                    break;
                    case 1:
                    choice = num1 - num2;
                    break;
                    case 2:
                    choice = num1 * num2;
                    break;
                    case 3:
                    choice = num1 / num2;
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
            MessageBox.Show("Result = " + choice);







        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
