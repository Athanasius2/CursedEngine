using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedCore
{
    public class Actor
    {
        public string name { set; get; }
        public List<Action> actions { get; }

        public Actor()
        {
            name = "default";
            actions = new List<Action>();
        }

        public Actor(string n, List<Action> a)
        {
            name = n;
            actions = a;
        }
    }
}
