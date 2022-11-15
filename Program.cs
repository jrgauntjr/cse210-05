using Lab05.Game;
using Lab05.Game.Actors;
using Lab05.Game.Services;
using Lab05.Game.Scripting;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cast cast = new Cast();
            cast.AddActor("food", new Food());
            cast.AddActor("P1", new P1());
            cast.AddActor("P2", new P2());

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
            Director director = new Director();
            director.StartGame();
        }
    }
}