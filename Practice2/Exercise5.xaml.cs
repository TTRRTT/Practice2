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
using System.Windows.Shapes;

namespace Practice2
{
    /// <summary>
    /// Interaction logic for Exercise5.xaml
    /// </summary>
    public partial class Exercise5 : Window
    {
        public Exercise5()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
            => MainWindow.Instance.Show();

        private void HandleWrongInput()
        {
            tb_input.Background = Brushes.Red;
            tb_input.Foreground = Brushes.White;

            tb_output.Text = string.Empty;
        }

        private void tb_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_input.Background == Brushes.White)
                return;

            tb_input.Background = Brushes.White;
            tb_input.Foreground = Brushes.Black;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_input.Text == string.Empty)
            {
                HandleWrongInput();
                return;
            }

            
        }
    }
}
