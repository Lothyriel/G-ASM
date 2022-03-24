using Domain.GameControls;
using Domain.Game;
using Domain.GameEngine;
using Domain.GameEngine.Objects;
using Domain.GameEngine.Shapes;
using Infra.Loaders;
using Renders.ConsoleRender;
using Object = Domain.GameEngine.Objects.Object;

var shipShape = ShapeLoader.I.Load("spaceship.png");
var player = new MovingObject(10, 70, new Rectangle(1, 1));
var controls = new Controls(player);
var ship = new MovingObject(15, 80, shipShape);

var objects = new List<Object>()
{
    new StaticObject(20, 50, new Rectangle(3, 2)),
    player,
    ship
};

var render = new ConsoleRender(1280, 720, new(controls), objects);
var engine = new Engine(objects);
var game = new Game(engine, render);

game.Start();