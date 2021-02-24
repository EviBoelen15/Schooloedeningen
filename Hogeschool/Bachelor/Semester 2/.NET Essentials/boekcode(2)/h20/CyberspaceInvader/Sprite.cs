using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CyberspaceInvader
{
    public abstract class Sprite
    {
        private int x, y, width, height;

        public int X
        {
            get => x;
            set { x = value; UpdateElement(); }
        }
        
        public int Y
        {
            get => y;
            set { y = value; UpdateElement(); }
        }

        public int Width
        {
            get => width;
            set { width = value; UpdateElement(); }
        }

        public int Height
        {
            get => height;
            set { height = value; UpdateElement(); }
        }

        public abstract void DisplayOn(Canvas drawingCanvas);
        protected abstract void UpdateElement();

        protected BitmapImage CreateBitmap(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            return bitmap;
        }

        protected bool HasHit(Sprite otherSprite)
        {
            if (IsOnTheLeftOf(otherSprite)) return false;
            if (IsOnTheRightOf(otherSprite)) return false;
            if (IsAbove(otherSprite)) return false;
            if (IsBelow(otherSprite)) return false;

            return true;
        }

        private bool IsBelow(Sprite otherSprite)
        {
            return Y > otherSprite.Y + Height;
        }

        private bool IsAbove(Sprite otherSprite)
        {
            return Y + Height < otherSprite.Y;
        }

        private bool IsOnTheRightOf(Sprite otherSprite)
        {
            return X > otherSprite.X + otherSprite.Width;
        }

        private bool IsOnTheLeftOf(Sprite otherSprite)
        {
            return X + Width < otherSprite.X;
        }
    }
}
