using System;
using System.Windows;

namespace InterestCalculation
{
    public partial class MainWindow : Window
    {
        private int _year = 1;
        private double _oldAmount;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void yearButton_Click(object sender, RoutedEventArgs e)
        {
            if (_year == 1)
            {
                _oldAmount = Convert.ToDouble(initialAmountTextBox.Text);
            }

            double rate = Convert.ToDouble(rateTextBox.Text);

            double newAmount = _oldAmount + (_oldAmount * rate / 100);

            int euros = (int)newAmount;
            int cents = (int)Math.Round(100 * (newAmount - euros));
            string line = $"After {_year} years the money has become " +
                          $"{euros} euros and {cents} eurocents.";
            resultTextBox.AppendText(line);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText(Environment.NewLine);

            _oldAmount = newAmount;
            _year += 1;
        }
    }
}
