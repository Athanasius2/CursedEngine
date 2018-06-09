using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedCore
{
    public class Action
    {
        public string action { get; }
        public string code { get; }
        public List<string> keys { get; }
        public string text { set; get; }

        public Action(string act, string c, List<string> k)
        {
            action = act;
            code = c;
            keys = k;
            text = "";
        }
    }
}
