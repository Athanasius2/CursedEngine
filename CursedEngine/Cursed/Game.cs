using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursedCore;

namespace Cursed
{
    class Game
    {
        private CursedConsole cCons;
        static void Main(string[] args)
        {
            new Game();
        }
        
        public Game()
        {
            cCons = new CursedConsole(120, 30);
            cCons.init();
            if (Console.WindowLeft + Console.WindowWidth < cCons.getWidth() &&
            Console.WindowTop + Console.WindowHeight < cCons.getHeight())
            {
                System.Console.SetBufferSize(cCons.getWidth(), cCons.getHeight());
            }
            System.Console.SetWindowSize(cCons.getWidth(), cCons.getHeight());
            cCons.draw(0, 0);
            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }
    }
}
