using System.Windows;

namespace MultipleWindows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            DetailsWindow window = new DetailsWindow(this);
            window.Show();
        }
    }
}
