using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System;

namespace BalloonWithProperties
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private Ellipse ellipse;
        
        public Balloon()
        {
            CreateEllipse();
            UpdateEllipse();
        }

        public int XCoord
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                UpdateEllipse();
            }
        }

        public int YCoord
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                UpdateEllipse();
            }
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();
        }

        public void moveUp(int yStep)
        {
            y = y - yStep;
            UpdateEllipse();
        }
        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            UpdateEllipse();
        }

        public void ChangeColor()
        {
            if (Color.Equals(ellipse.Stroke, Colors.Red))
            {
                ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            } 
            else {
                ellipse.Stroke = new SolidColorBrush(Colors.Red);
            }
        }
        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 2
            };
        }

        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }
    }
}
