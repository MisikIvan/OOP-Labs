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

namespace WpfApp2
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

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            double D, x1, x2, a, b, c;
            bool p;
            p = double.TryParse(TBa.Text, out a);
            if (a == 0)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (!p)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            p = double.TryParse(TBb.Text, out b);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            p = double.TryParse(TBc.Text, out c);
            if (!p)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            D = Math.Pow(b, 2) - 4 * a * c;
            TBD.Text = D.ToString("F2");
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                TBx1.Text = x1.ToString("F2");
                TBx2.Text = x2.ToString("F2");
                TBx2.Visibility = Visibility.Visible;
                TBx1.Visibility = Visibility.Visible;
                Lx1.Visibility = Visibility.Visible;
                Lx2.Visibility = Visibility.Visible;
                Lx1.Content = "x1 =";
                Lx2.Content = "x2 =";
            }
            if (D == 0)
            {
                x1 = -(b / (2 * a));
                TBx1.Text = x1.ToString("F2");
                TBx1.Visibility = Visibility.Visible;
                TBx2.Visibility = Visibility.Hidden;
                Lx2.Visibility = Visibility.Hidden;
                Lx1.Visibility = Visibility.Visible;
                Lx1.Content = "x1 =";
            }
            if (D < 0)
            {
                Lx1.Content = ("Коренів немає");
                TBx2.Visibility = Visibility.Hidden;
                TBx1.Visibility = Visibility.Hidden;
                Lx2.Visibility = Visibility.Hidden;
                Lx1.Visibility = Visibility.Visible;
            }
        }
    }
}
