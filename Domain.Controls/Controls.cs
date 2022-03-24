using Domain.GameEngine.Objects;

namespace Domain.GameControls
{
    public class Controls
    {
        public Controls(MovingObject player)
        {
            Player = player;
            Listener = new Listener(player);
        }

        public Listener Listener { get; }

        public MovingObject Player { get; }
    }
}