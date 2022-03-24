namespace Domain.GameEngine.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width)
        {
        }

        protected override List<Point> GeneratePoints()
        {
            var points = new List<Point>();

            for (var x = -Width; x < Width; x++)       //quero trocar isso pra fazer retangulos impares
            {
                for (var y = -Height; y < Height; y++) //(talvez com 2 valores para cada dimensao (um pra cada lado))
                {
                    points.Add(new Point(x, y));
                }
            }

            return points;
        }
    }
}
