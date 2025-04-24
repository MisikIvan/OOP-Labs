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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z;
            double a, b, c, d, r, s;
            bool p;
            p = double.TryParse(TBx.Text, out x);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            p = double.TryParse(TBy.Text, out y);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення y", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            p = double.TryParse(TBz.Text, out z);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            a = Math.Pow(y, x + 1);
            b = Math.Pow(Math.Abs(y - 2) + 3, 1.0 / 3);
            c = x + y / 2;
            d = 2 * Math.Abs(x + y);
            r = Math.Pow(x + 1, -1.0 / Math.Sin(z));
            s = (a / b) + (c / d) * r;
            TBs.Text = s.ToString("F2");
        }
    }
}
