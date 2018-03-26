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
        private string name;

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
    }
}
