using Domain.GameEngine.Objects;
using Domain.GameEngine.Physics;
using Object = Domain.GameEngine.Objects.Object;

namespace Domain.GameEngine
{
    public class Engine
    {
        public const int FrameRate = 60;
        public const double TargetFrameTime = 1000 / FrameRate;

        public Engine(List<Object> objects)
        {
            Objects = objects;
            Tickables = objects.Where(o => o is MovingObject).Cast<MovingObject>().ToList();
            Physics = new PhysicsEngine(objects);
        }

        public List<Object> Objects { get; }

        public List<MovingObject> Tickables { get; }

        public PhysicsEngine Physics { get; }

        public void Tick()
        {
            foreach (var obj in Tickables)
            {
                obj.Tick();
                Physics.Simulate(obj);
            }
        }
    }
}