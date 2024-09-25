using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practice2
{
    /// <summary>
    /// Interaction logic for Practice1.xaml
    /// </summary>
    public partial class Exercise1 : Window
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow.Instance.Show();
        }

        private static BigInteger GetFactorial(int value)
        {
            BigInteger result = 1;
            for (int i = 1; i <= value; i++)
                result *= i;
            return result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb_input.Text, out int value) && value >= 1 && value <= 5000)
                tb_output.Text = (2 * GetFactorial(value)).ToString();
            else
            {
                tb_input.Background = Brushes.Red;
                tb_input.Foreground = Brushes.White;
                tb_output.Text = string.Empty;
            }
        }

        private void tb_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb_input.Background = Brushes.White;
            tb_input.Foreground = Brushes.Black;
        }
    }
}
