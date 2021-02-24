using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace SnakeGame
{
    public class Food
    {
        public double x, y;
        public Ellipse ellipse = new Ellipse();

        //constructor
        public Food(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        //deze functie geeft het voedsel een breedte, groote, kleur en een plaats
        public void PlaatsVoedsel()
        {
            ellipse.Width = ellipse.Height = 10;
            ellipse.Fill = Brushes.Red;

            //geeft linker en top waarde van het object
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
        }
    }
}
