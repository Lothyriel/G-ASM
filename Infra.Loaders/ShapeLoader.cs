using Domain.GameEngine.Shapes;
using System.Drawing;
using Point = Domain.GameEngine.Shapes.Point;

namespace Infra.Loaders
{
    public class ShapeLoader : Loader
    {
        public static ShapeLoader I = new();

        public override string DirectoryName => "Shapes";

        public CustomShape Load(string imageFileName)
        {
            var path = GetFilePath(imageFileName);
            var img = new Bitmap(path); //trocar para cross platform libray (ImageSharp ou Maui.Graphics)

            var points = new List<Point>();

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var pixel = img.GetPixel(x, y);

                    if (pixel.IsBlack())
                    {
                        points.Add(new Point(y, x));
                    }
                }
            }

            return new CustomShape(img.Width, img.Height, points);
        }
    }
}