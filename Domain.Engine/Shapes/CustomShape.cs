namespace Domain.GameEngine.Shapes
{
    public class CustomShape : Shape
    {
        public CustomShape(int height, int width, List<Point> points) : base(height, width)
        {
            ShapePoints = points;
        }

        public List<Point> ShapePoints;

        protected override List<Point> GeneratePoints()
        {
            return ShapePoints;
        }
    }
}