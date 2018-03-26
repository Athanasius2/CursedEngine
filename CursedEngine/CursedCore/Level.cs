using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedCore
{
    public class Level
    {
        private List<Room> rooms;

        //TODO Create system for setting original names for levels
        private static List<string> names;
        private string name;

        // TODO maybe add an exception if the level was not created correctly (e.g. it is a duplicate name)
        public Level()
        {
            if (names != null)
            {
                names = new List<string>();
            }
            name = "bad name";
        }

        public Level(string s)
        {
            this.name = s;
            this.rooms = new List<Room>();
        }

        // TODO implement load functionality once we get a file format figured out.
        /// <summary>
        /// Loads a level from a file
        /// </summary>
        public void Load()
        {
            this.rooms = new List<Room>();
            this.name = "default";
        }

        // TODO review this to make sure it makes sense
        public void addRoom(Room r)
        {
            rooms.Add(r);
        }

        public string getName()
        {
            return this.name;
        }
    }
}
