using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            double y, a, b, h;
            bool ok;
            ok = double.TryParse(TextBoxa.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення числа", "Помилка введення значення a!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(TextBoxb.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення числа", "Помилка введення значення b!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(TextBoxh.Text, out h);
            if (!ok)
            {
                MessageBox.Show("Помилка введення числа", "Помилка введення значення h!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TextBoxa.Text = a.ToString("F3");
            TextBoxb.Text = b.ToString("F3");
            TextBoxh.Text = h.ToString("F3");
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
