using Domain.GameControls;

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