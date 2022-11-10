using System;
using System.Collections.Generic;

namespace test.Game
{
    public class Director
    {
        public Director()
        {
        }
        public void StartGame()
        {
            while (isPlaying == True)
            {
                getInputs();
                doUpdates();
                doOutputs();
            }
        }
        public void getInputs()
        {
        }

        public void doUpdates()
        {
        }

        public void doOutputs()
        {
        }
    }
}