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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            bool ok;
            ok = int.TryParse(textBoxa.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = int.TryParse(textBoxb.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = int.TryParse(textBoxc.Text, out c);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            textBoxa.Text = a.ToString("D");
            textBoxb.Text = b.ToString("D");
            textBoxc.Text = c.ToString("D");
            if (a < b && a < c && b < c)
            {
                textBoxa.Background = Brushes.Red;
                textBoxb.Background = Brushes.Yellow;
                textBoxc.Background = Brushes.Green;
            }
            if (a < b && a < c && b > c)
            {
                textBoxa.Background = Brushes.Red;
                textBoxc.Background = Brushes.Yellow;
                textBoxb.Background = Brushes.Green;
            }
            if (b < a && b < c && a < c)
            {
                textBoxb.Background = Brushes.Red;
                textBoxa.Background = Brushes.Yellow;
                textBoxc.Background = Brushes.Green;
            }
            if (b < a && b < c && a > c)
            {
                textBoxb.Background = Brushes.Red;
                textBoxc.Background = Brushes.Yellow;
                textBoxa.Background = Brushes.Green;
            }
            if (c < a && c < b && a < b)
            {
                textBoxc.Background = Brushes.Red;
                textBoxa.Background = Brushes.Yellow;
                textBoxb.Background = Brushes.Green;
            }
            if (c < a && c < b && a > b)
            {
                textBoxc.Background = Brushes.Red;
                textBoxb.Background = Brushes.Yellow;
                textBoxa.Background = Brushes.Green;
            }
            if (a == b)
            {
                textBoxa.Background = Brushes.Blue;
                textBoxb.Background = Brushes.Blue;
                textBoxc.Background = Brushes.White;
            }
            if (a == c)
            {
                textBoxa.Background = Brushes.Blue;
                textBoxc.Background = Brushes.Blue;
                textBoxb.Background = Brushes.White;
            }
            if (c == b)
            {
                textBoxb.Background = Brushes.Blue;
                textBoxc.Background = Brushes.Blue;
                textBoxa.Background = Brushes.White;
            }
        }
    }
}
