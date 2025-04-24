using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double y, a, b, h;
            bool ok;
            ok = double.TryParse(textBoxa.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxb.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxh.Text, out h);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxa.Text = a.ToString("F3");
            textBoxb.Text = b.ToString("F3");
            textBoxh.Text = h.ToString("F3");
            for (double x = a; x <= b; x += h)
            {
                string xs, ys;
                y = (Math.Pow(Math.Cos(x), 2)) / (Math.Pow(x, 2) + 1);
                xs = "x =" + " " + x.ToString("F3");
                ys = "y =" + " " + y.ToString("F3");
                string s = xs + " " + ys;
                listBox1.Items.Add(s);

            }
        }
    }
}
