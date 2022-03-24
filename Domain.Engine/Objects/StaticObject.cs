using Domain.GameEngine.Shapes;

namespace Domain.GameEngine.Objects
{
    public class StaticObject : Object
    {
        public StaticObject(int x, int y, Shape shape) : base(x, y, shape)
        {
        }
    }
}