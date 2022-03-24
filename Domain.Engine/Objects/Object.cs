using Domain.GameEngine.Shapes;

namespace Domain.GameEngine.Objects
{
    public abstract class Object
    {
        public Object(int x, int y, Shape shape)
        {
            Shape = shape;
            X = x;
            Y = y;
        }

        public Shape Shape { get; }
        public int X { get; set; }
        public int Y { get; set; }

        public HitDirection Hit(Object another) //provavelmente ta errado preciso testar
        {
            if (HitRight())
                return HitDirection.Right;

            if (HitLeft())
                return HitDirection.Left;

            if (HitTop())
                return HitDirection.Top;

            if (HitBottom())
                return HitDirection.Bottom;

            return HitDirection.None;

            bool HitRight()
            {
                return X + Shape.Width >= another.X + Shape.Width;
            }
            bool HitLeft()
            {
                return X - Shape.Width >= another.X - Shape.Width;
            }
            bool HitTop()
            {
                return Y + Shape.Height >= another.Y + Shape.Height;
            }
            bool HitBottom()
            {
                return Y - Shape.Height >= another.Y - Shape.Height;
            }
        }

        public List<(int X, int Y)> GetPoints()
        {
            return Shape.Points.Select(p => (p.X + X, p.Y + Y)).ToList();
        }
    }

    public enum HitDirection
    {
        None,
        Left,
        Right,
        Top,
        Bottom,
    }
}