using Domain.Game;
using Domain.GameControls;
using Domain.GameEngine;
using Domain.GameEngine.Objects;
using Domain.GameEngine.Shapes;
using Infra.Loaders;
using Renders.ConsoleRender;
using Object = Domain.GameEngine.Objects.Object;

var dShape = ShapeLoader.I.Load("d.png");
var shipShape = ShapeLoader.I.Load("spaceship.png");
var player = new MovingObject(10, 70, new Rectangle(1, 1));
var controls = new Controls(player);
var rec = new StaticObject(20, 50, new Rectangle(3, 2));
var ship = new MovingObject(15, 80, shipShape);
var d = new StaticObject(0, 0, dShape);
var a1 = new StaticObject(0, 0, new Rectangle(3, 3));

var objects = new List<Object>()
{
    rec,
    player,
    //ship,
    a1,
    //d
};

var render = new ConsoleRender(1280*2, 720*2, new(controls), objects);
var engine = new Engine(objects);
var game = new Game(engine, render);

game.Start();