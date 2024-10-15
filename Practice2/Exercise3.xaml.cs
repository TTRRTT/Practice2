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
    /// Interaction logic for Exercise3.xaml
    /// </summary>
    public partial class Exercise3 : Window
    {
        public Exercise3()
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

        private bool FindStreak(string[] sequence, out int maxStreak, out int maxIndex)
        {
            maxStreak = maxIndex = 0;
            int currentStreak = 1, currentIndex = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (!int.TryParse(sequence[i], out int num)
                    || !int.TryParse(sequence[i + 1], out int numNext))
                    return false;

                if (num != 0 && numNext != 0 && numNext % num == 0)
                {
                    if (currentStreak == 1)
                        currentIndex = i;
                    currentStreak++;
                }
                else
                    currentStreak = 1;

                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                    maxIndex = currentIndex;
                }
            }

            return true;
        }

        private void tb_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_input.Background != Brushes.White)
            {
                tb_input.Background = Brushes.White;
                tb_input.Foreground = Brushes.Black;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_input.Text == string.Empty)
            {
                HandleWrongInput();
                return;
            }

            var stringNums = tb_input.Text.Replace(",", "")
                .Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries);

            if (FindStreak(stringNums, out int maxStreak, out int maxIndex) && maxStreak > 1)
                tb_output.Text = string.Join(" ", stringNums.Skip(maxIndex).Take(maxStreak));
            else
                HandleWrongInput();
        }
    }
}
