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
            this.name = "Room";
        }

        public Room(string n)
        {
            new Room();
            this.name = n;
        }

        public string getName()
        {
            return this.name;
        }

        public Actor getActor(string a)
        {
            foreach (Actor x in actors)
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
