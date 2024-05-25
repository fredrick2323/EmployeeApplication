using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            int a = Convert.ToInt32(textBox6.Text);
            double b = Convert.ToDouble(textBox5.Text);
            partTimeEmployee.computeSalary(a, b);
            double c = Convert.ToDouble(label12.Text);

            label10.Text = textBox1.Text;
            label11.Text = textBox2.Text;
            label12.Text = partTimeEmployee.getSalary().ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
