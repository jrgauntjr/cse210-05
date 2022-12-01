using Unit05.Game.Casting;
using Unit05.Game.Directing;
using Unit05.Game.Scripting;
using Unit05.Game.Services;



namespace Unit05
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Point start1 = new Point(Constants.MAX_X / 6, Constants.MAX_Y / 2);
            Point start2 = new Point(Constants.MAX_X / 3, Constants.MAX_Y / 4);
            Color color1 = Constants.GREEN;
            Color color2 = Constants.RED;

            // create the cast
            Cast cast = new Cast();
            cast.AddActor("food", new Food());
            cast.AddActor("snake", new Snake(start1, color1));
            cast.AddActor("snake", new Snake(start2, color2));
            cast.AddActor("score", new Score());

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
        }
    }
}