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

        public Actor(string n, List<Action> a)
        {
            name = n;
            actions = a;
        }
    }
}
