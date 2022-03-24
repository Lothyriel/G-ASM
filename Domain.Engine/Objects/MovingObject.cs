using Domain.GameEngine.Shapes;

namespace Domain.GameEngine.Objects
{
    public class MovingObject : Object, ITickable
    {
        public MovingObject(int x, int y, Shape shape, int xSpeed = 0, int ySpeed = 0) : base(x, y, shape)
        {
            XSpeed = xSpeed;
            YSpeed = ySpeed;
        }

        public int XSpeed { get; set; }
        public int YSpeed { get; set; }

        public void Tick()
        {
            X += XSpeed;
            Y += YSpeed;
        }
    }
}