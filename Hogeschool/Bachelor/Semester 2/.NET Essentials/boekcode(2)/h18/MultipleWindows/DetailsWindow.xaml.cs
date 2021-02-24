using System.Windows;

namespace MultipleWindows
{
    public partial class DetailsWindow : Window
    {
        private MainWindow _otherWindow;
        
        public DetailsWindow(MainWindow other)
        {
            InitializeComponent();
            _otherWindow = other;
        }

        private void hideButton_Click(object sender, RoutedEventArgs e)
        {
            _otherWindow.Hide();
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            _otherWindow.Show();
        }
    }
}
