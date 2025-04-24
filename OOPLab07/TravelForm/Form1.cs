using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            countrycombo.SelectedIndex = 0;
            sezoncombo.SelectedIndex = 0;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void btrozr_Click(object sender, EventArgs e)
        {
            int country = countrycombo.SelectedIndex;
            int sezon = sezoncombo.SelectedIndex;
            int putivka = Convert.ToInt32(numericputivka.Value);
            int den = Convert.ToInt32(numericden.Value);
            int gid = Convert.ToInt32(numericgid.Value);
            int res = 0;
            if (gid > den)
            {
                MessageBox.Show("Помилка введення !", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (country == 0 && sezon == 0)
            {
                res = 100 * putivka * den;
            }
            if (country == 0 && sezon == 1)
            {
                res = 150 * putivka * den;
            }
            if (country == 1 && sezon == 0)
            {
                res = 160 * putivka * den;
            }
            if (country == 1 && sezon == 1)
            {
                res = 200 * putivka * den;
            }
            if (country == 2 && sezon == 0)
            {
                res = 120 * putivka * den;
            }
            if (country == 2 && sezon == 1)
            {
                res = 180 * putivka * den;
            }
            if (gidcheck.Checked == true)
            {
                res = res + 50 * putivka * gid;
            }
            lbres.Text = res.ToString() + " $";
        }
    }
}
