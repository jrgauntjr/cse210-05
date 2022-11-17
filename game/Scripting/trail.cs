using System.Collections.Generic;
using Lab05.Game.Actors;
using Lab05.Game.Services;


namespace Lab05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>
    public class GrowTrail : actions
    {
        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public GrowTrail()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
             Cycle cycle = (Cycle)cast.GetFirstActor("cycle");
            List<Actor> actors = cast.GetAllActors();
            foreach (Actor actor in actors)
            {
                int seg = 2;
                cycle.GrowTrail(seg);
            }
        }
    }
}