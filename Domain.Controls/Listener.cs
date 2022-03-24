using Domain.GameEngine.Objects;

namespace Domain.GameControls
{
    public class Listener
    {
        public Listener(MovingObject player)
        {
            Task.Run(Listen);
            Player = player;
        }

        public MovingObject Player { get; }

        private void Listen()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Enter:
                        //restart
                        break;

                    case ConsoleKey.P:
                    case ConsoleKey.Pause:
                        //pause
                        break;

                    case ConsoleKey.Escape:
                        //quit game
                        break;

                    case ConsoleKey.Spacebar:
                        //fire
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Player.YSpeed += -1;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Player.YSpeed += 1;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Player.XSpeed += 1;
                        break;

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Player.XSpeed += -1;
                        break;

                    default: break;
                }
            } while (!Console.KeyAvailable && key != ConsoleKey.Escape);
        }
    }
}