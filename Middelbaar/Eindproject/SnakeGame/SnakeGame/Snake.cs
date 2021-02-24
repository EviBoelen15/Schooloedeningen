using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SnakeGame
{
    public class Snake
    {
        public double x, y;
        public Ellipse ellipse = new Ellipse();


        //constructor
        public Snake(double x, double y)
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
            get { return Y; }
        }

        //deze fucntie geeft de slang een grootte, breedte, kleur en een plaats
        public void PlaatsSlang()
        {

            ellipse.Width = ellipse.Height = 12;
            ellipse.Fill = Brushes.White;

            //geeft linker en top waarde van het object
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
        }
    }
}
