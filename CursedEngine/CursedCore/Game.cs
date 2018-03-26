using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedCore
{
    /// <summary>
    /// Data structure to store game data
    /// </summary>
    public class Game
    {
        /// <summary>
        /// A list that contains all the levels in the game
        /// </summary>
        private List<Level> levels;

        public Game()
        {
            levels = new List<Level>();
        }

        /// <summary>
        /// Add a new Level to Game.  Levels should have unique identifiers and be placed in numerical order.
        /// </summary>
        /// <param name="l">Level to add</param>
        public void addLevel(Level l)
        {
            //TODO Come up with a level ordering system
            levels.Add(l);
        }

        /// <summary>
        /// Removes level from Game.  
        /// </summary>
        /// <param name="l"></param>
        public void removeLevel(Level l)
        {
            //TODO come up with level ordering system
            levels.Remove(l);
        }

        public Level getLevel(string l)
        {
            foreach (Level x in levels)
            {
                if (x.getName().Equals(l))
                {
                    return x;
                }
            }
            return null;
        }
    }
}
