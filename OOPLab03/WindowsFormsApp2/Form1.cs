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

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            bool ok;
            ok = int.TryParse(textBoxa.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = int.TryParse(textBoxb.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = int.TryParse(textBoxc.Text, out c);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxa.Text = a.ToString("D");
            textBoxb.Text = b.ToString("D");
            textBoxc.Text = c.ToString("D");
            if (a < b && a < c && b < c)
            {
                textBoxa.BackColor = Color.Red;
                textBoxb.BackColor = Color.Yellow;
                textBoxc.BackColor = Color.Green;
            }
            if (a < b && a < c && b > c)
            {
                textBoxa.BackColor = Color.Red;
                textBoxc.BackColor = Color.Yellow;
                textBoxb.BackColor = Color.Green;
            }
            if (b < a && b < c && a < c)
            {
                textBoxb.BackColor = Color.Red;
                textBoxa.BackColor = Color.Yellow;
                textBoxc.BackColor = Color.Green;
            }
            if (b < a && b < c && a > c)
            {
                textBoxb.BackColor = Color.Red;
                textBoxc.BackColor = Color.Yellow;
                textBoxa.BackColor = Color.Green;
            }
            if (c < a && c < b && a < b)
            {
                textBoxc.BackColor = Color.Red;
                textBoxa.BackColor = Color.Yellow;
                textBoxb.BackColor = Color.Green;
            }
            if (c < a && c < b && a > b)
            {
                textBoxc.BackColor = Color.Red;
                textBoxb.BackColor = Color.Yellow;
                textBoxa.BackColor = Color.Green;
            }
            if (a == b)
            {
                textBoxa.BackColor = Color.Blue;
                textBoxb.BackColor = Color.Blue;
                textBoxc.BackColor = Color.White;
            }
            if (a == c)
            {
                textBoxa.BackColor = Color.Blue;
                textBoxc.BackColor = Color.Blue;
                textBoxb.BackColor = Color.White;
            }
            if (c == b)
            {
                textBoxb.BackColor = Color.Blue;
                textBoxc.BackColor = Color.Blue;
                textBoxa.BackColor = Color.White;
            }
        }
    }
}
