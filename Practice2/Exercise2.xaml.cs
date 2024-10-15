using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practice2
{
    /// <summary>
    /// Interaction logic for Exercise2.xaml
    /// </summary>
    public partial class Exercise2 : Window
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
            => MainWindow.Instance.Show();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_input.Text != string.Empty)
            {
                var words = tb_input.Text.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries);
                tb_output.Text = string.Join(" ", words.Reverse());
            }
            else
            {
                tb_input.Background = Brushes.Red;
                tb_input.Foreground = Brushes.White;
            }
        }

        private void tb_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_input.Background == Brushes.White)
                return;

            tb_input.Background = Brushes.White;
            tb_input.Foreground = Brushes.Black;
        }
    }
}
