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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double a, b, c, d, r, s;
            bool p;
            p = double.TryParse(textBoxx.Text, out x);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            p = double.TryParse(textBoxy.Text, out y);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            p = double.TryParse(textBoxz.Text, out z);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            a = Math.Pow(y, x + 1);
            b = Math.Pow(Math.Abs(y - 2) + 3, 1.0 / 3);
            c = x + y / 2;
            d = 2 * Math.Abs(x + y);
            r = Math.Pow(x + 1, -1.0 / Math.Sin(z));
            s = (a / b) + (c / d) * r;
            textBoxs.Text = s.ToString("F2");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
