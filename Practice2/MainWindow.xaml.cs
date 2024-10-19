using System.Windows;

namespace Practice2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            Instance = this;
        }

        private void SwitchWindow(Window to)
        {
            Hide();
            to.Show();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
            => SwitchWindow(new Exercise1());

        private void Button_Click(object sender, RoutedEventArgs e)
            => SwitchWindow(new Exercise2());

        private void Button_Click_1(object sender, RoutedEventArgs e)
            => SwitchWindow(new Exercise3());

        private void Button_Click_2(object sender, RoutedEventArgs e)
            => SwitchWindow(new Exercise4());

        private void Button_Click_3(object sender, RoutedEventArgs e)
            => SwitchWindow(new Exercise5());
    }
}