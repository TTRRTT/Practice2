using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practice2
{
    /// <summary>
    /// Interaction logic for Exercise4.xaml
    /// </summary>
    public partial class Exercise4 : Window
    {
        public Exercise4()
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

        private bool SortSequence(string[] input, out int[] result)
        {
            result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out int x))
                    return false;

                result[i] = x;
            }

            Array.Sort(result);
            return true;
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

            var stringNums = tb_input.Text.Replace(",", " ")
                .Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries);

            if (SortSequence(stringNums, out int[] result))
                tb_output.Text = string.Join(" ", result);
            else
                HandleWrongInput();
        }
    }
}
