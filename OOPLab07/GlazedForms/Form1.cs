using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazedForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combomater.SelectedIndex = 0;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void btrozr_Click(object sender, EventArgs e)
        {

            bool p;
            double width;
            p = double.TryParse(textboxwidth.Text, out width);
            if (Convert.ToDouble(textboxwidth.Text) < 0)
            {
                p = false;
            }
            if (!p)
            {
                MessageBox.Show("Помилка введення значення ширини!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double height;
            p = double.TryParse(textboxheight.Text, out height);
            if (Convert.ToDouble(textboxheight.Text) < 0)
            {
                p = false;
            }
            if (!p)
            {
                MessageBox.Show("Помилка введення значення висоти!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int material = combomater.SelectedIndex;
            int paket = 1;
            if (radiobtodno.Checked == true)
            {
                paket = 1;
            }
            if (radiobtdvo.Checked == true)
            {
                paket = 2;
            }
            double res = height * width;
            if (material == 0 && paket == 1)
            {
                res = res * 0.25;
            }
            if (material == 0 && paket == 2)
            {
                res = res * 0.3;
            }
            if (material == 1 && paket == 1)
            {
                res = res * 0.05;
            }
            if (material == 1 && paket == 2)
            {
                res = res * 0.1;
            }
            if (material == 2 && paket == 1)
            {
                res = res * 0.15;
            }
            if (material == 2 && paket == 2)
            {
                res = res * 0.2;
            }
            if (checkBoxpidv.Checked == true)
            {
                res = res + 35;
            }
            labelvart.Text = res.ToString("F2") + " грн";
        }
    }
}
