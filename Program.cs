using Lab05.Game;
using Lab05.Game.Directing;
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
            cast.AddActor("food", new powerUp());
            cast.AddActor("P1", new Cycle());
            cast.AddActor("P2", new Cycle());

            // create the services
            KeyboardService keyboardservice = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
         // create the script
            Script script = new Script();
            script.AddAction("input", new controlActors(keyboardservice));
            script.AddAction("update", new moveActors());
            script.AddAction("update", new collisions());
            script.AddAction("output", new drawActor(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}