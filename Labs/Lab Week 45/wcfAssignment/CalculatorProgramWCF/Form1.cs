using CalculatorProgramWCF.CalculatorService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProgramWCF
{
    public partial class Form1 : Form
    {
        private CalculatorClient client;
        public Form1()
        {
            InitializeComponent();
            client = new CalculatorClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string addValue1 = textBox1.Text;
            string addValue2 = textBox2.Text;
            double addResult = client.Add(double.Parse(addValue1), double.Parse(addValue2));

            textBox3.Text = addResult.ToString();
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subValue1 = textBox1.Text;
            string subValue2 = textBox2.Text;
            double subResult = client.Subtract(double.Parse(subValue1), double.Parse(subValue2));

            textBox3.Text = subResult.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            string mulValue1 = textBox1.Text;
            string mulValue2 = textBox2.Text;
            double mulResult = client.Multiply(double.Parse(mulValue1), double.Parse(mulValue2));

            textBox3.Text = mulResult.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string divValue1 = textBox1.Text;
            string divValue2 = textBox2.Text;
            double divResult = client.Divide(double.Parse(divValue1), double.Parse(divValue2));

            textBox3.Text = divResult.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
