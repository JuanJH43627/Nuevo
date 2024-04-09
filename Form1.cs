using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIMORFISMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox3.Text);
            double a = double.Parse(textBox4.Text);

            Carroceria carroc = new Carroceria(textBox2.Text, b, a);

            textBox1.Text = carroc.MostrarArea();

            double r = double.Parse(textBox9.Text);
            Llantas llantas = new Llantas(textBox5.Text, r);
            Llantas llantas2 = new Llantas(textBox6.Text, r);
            Llantas llantas3 = new Llantas(textBox7.Text, r);
            Llantas llantas4 = new Llantas(textBox8.Text, r);
            Llantas llantas5 = new Llantas(textBox9.Text, r);

            textBox1.Text += llantas.MostrarColor();
            textBox1.Text += llantas2.MostrarColor();
            textBox1.Text += llantas3.MostrarColor();
            textBox1.Text += llantas4.MostrarColor();
            textBox1.Text += llantas5.MostrarArea();



        }
    }
}
