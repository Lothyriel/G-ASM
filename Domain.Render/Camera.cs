using Domain.GameControls;
using Object = Domain.GameEngine.Objects.Object;

namespace Domain.Render
{
    public class Camera
    {
        public Camera(Controls controls)
        {
            Controls = controls;
        }

        public Controls Controls { get; }
    }
}