namespace Domain.GameEngine.Shapes
{
    public abstract class Shape
    {
        private List<Point>? points;

        public Shape(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; }

        public int Width { get; }

        public List<Point> Points { get => points ??= GeneratePoints(); } //nao gostei do jeito q isso ficou...

        protected abstract List<Point> GeneratePoints();
    }
}