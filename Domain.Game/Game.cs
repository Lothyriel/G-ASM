using Domain.GameEngine;
using Domain.Render;
using System.Diagnostics;

namespace Domain.Game
{
    public class Game
    {
        public bool Running { get; set; }
        public Engine Engine { get; }
        public IRender Render { get; }

        public Game(Engine engine, IRender render)
        {
            Engine = engine;
            Render = render;
            Running = false;
        }

        public void Start()
        {
            Running = true;
            var clock = Stopwatch.StartNew();

            while (Running)
            {
                Render.DrawFrame();
                Engine.Tick();
                var frameTime = clock.ElapsedMilliseconds;
                Thread.Sleep(150 + (int)(Engine.TargetFrameTime - frameTime));
                clock.Restart();
            }
        }
    }
}