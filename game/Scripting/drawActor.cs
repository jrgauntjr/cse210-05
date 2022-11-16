using System.Collections.Generic;
using Lab05.Game.Actors;
using Lab05.Game.Services;


namespace Lab05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class drawActor : actions
    {
        private VideoService _videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public drawActor(VideoService videoService)
        {
            this._videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Cycle cycle = (Cycle)cast.GetFirstActor("cycle");
            List<Actor> segments = cycle.GetSegments();
            Actor powerUp = cast.GetFirstActor("power");
            List<Actor> messages = cast.GetActors("messages");
            
            _videoService.ClearBuffer();
            _videoService.DrawActors(segments);
            _videoService.DrawActor(powerUp);
            _videoService.DrawActors(messages);
            _videoService.FlushBuffer();
        }
    }
}