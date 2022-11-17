using System;


namespace Lab05.Game.Actors
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class powerUp : Actor
    {

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public powerUp()
        {
            SetText("*");
            SetColor(Constants.RED); 
            Reset();
        }

        /// <summary>
        /// Selects a random position and points that the food is worth.
        /// </summary>
        public void Reset()
        {
            Random random = new Random();
            int x = random.Next(Constants.COLUMNS);
            int y = random.Next(Constants.ROWS);
            Point position = new Point(x, y);
            position = position.Scale(Constants.CELL_SIZE);
            SetPosition(position);
        }
    }
}