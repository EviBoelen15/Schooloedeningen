using System;
using System.Windows;

namespace SinusReeks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string line = $"{Sin(14)} en {Math.Sin(14)}";
            MessageBox.Show(line);
        }

        private double Sin(double x)
        {
            double result = 0.0;
            double term = x;
            int n = 1;
            while (Math.Abs(term) >= 0.0001)
            {
                result += term;
                term = -term * x * x / ((n + 1) * (n + 2));
                n += 2;
            }
            return result;
        }
    }
}
