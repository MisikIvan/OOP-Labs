using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double D, x1, x2, a, b, c;
            bool p;
            p = double.TryParse(textBoxa.Text, out a);
            if (a == 0)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!p)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            p = double.TryParse(textBoxb.Text, out b);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            p = double.TryParse(textBoxc.Text, out c);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            D = Math.Pow(b, 2) - 4 * a * c;
            textBoxD.Text = D.ToString("F2");
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                textBox1.Text = x1.ToString("F2");
                textBox2.Text = x2.ToString("F2");
                textBox2.Visible = true;
                textBox1.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label5.Text = ("x1=");
                label6.Text = ("x2=");
            }
            if (D == 0)
            {
                x1 = -(b / (2 * a));
                textBox1.Text = x1.ToString("F2");
                textBox2.Visible = false;
                textBox1.Visible = true;
                label6.Visible = false;
                label4.Visible = true;
                label5.Text = ("x1 =");
            }
            if (D < 0)
            {
                label5.Text = ("Коренів немає");
                textBox1.Visible = false;
                textBox2.Visible = false;
                label6.Visible = false;
            }
        }
    }
    }
