using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedCore
{
    public class Room
    {
        private List<Display> displays;
        private List<Actor> actors;
        public string text { get; set; }
        public string name { get; set; }

        public Room()
        {
            this.displays = new List<Display>();
            actors = new List<Actor>();
            this.name = "Room";
        }

        public Room(string n)
        {
            this.displays = new List<Display>();
            actors = new List<Actor>();
            this.name = n;
        }

        /// <summary>
        /// Checks to see if the room name is unique in a level
        /// </summary>
        /// <param name="n">Room name</param>
        /// <param name="l">Level</param>
        /// <returns></returns>
        public static bool isUnique(string n, Level l)
        {
            if (n == "") return false;
            else if (l.getRoom(n) == null) return true;
            else return false;
        }

        public bool IsUniqueActor(string a)
        {
            if (a == "") return false;
            else if (this.getActor(a) == null) return true;
            else return false;
        }

        public void addActor(Actor a)
        {
            actors.Add(a);
        }

        public Actor getActor(string a)
        {
            if (actors.Count == 0) return null;
            else foreach (Actor x in actors)
            {
                if (x.name.Equals(a))
                {
                    return x;
                }
            }
            return null;
        }
    }
}
