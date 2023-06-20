using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource body = LoadImage("body.png");
        public readonly static ImageSource cell = LoadImage("cell.png");
        public readonly static ImageSource deadbody = LoadImage("deadbody.png");
        public readonly static ImageSource deadhead = LoadImage("deadhead.png");
        public readonly static ImageSource deadtail = LoadImage("deadtail.png");
        public readonly static ImageSource food = LoadImage("food.png");
        public readonly static ImageSource head = LoadImage("head.png");
        public readonly static ImageSource tail = LoadImage("tail.png");

        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }

    }
}
