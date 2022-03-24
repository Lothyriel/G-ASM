using Object = Domain.GameEngine.Objects.Object;

namespace Domain.GameEngine
{
    public class Engine : ITickable
    {
        public const int FrameRate = 60;
        public const double TargetFrameTime = 1000 / FrameRate;

        public Engine(List<Object> objects)
        {
            Objects = objects;
            Tickables = objects.Where(o => o is ITickable).Cast<ITickable>().ToList();
        }

        public List<Object> Objects { get; }
        public List<ITickable> Tickables { get; }

        public void Tick()
        {
            foreach (var obj in Tickables)
            {
                obj.Tick();
            }
        }
    }
}