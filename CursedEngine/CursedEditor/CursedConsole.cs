using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cursed
{
    /// <summary>
    /// A data structure to keep track of display information on the console.
    /// </summary>
    class CursedConsole
    {
        /// <summary>
        /// Contains color and character for each position in the console.
        /// </summary>
        public struct CursedChar
        {
            public Color bgColor;
            public Color charColor;
            public char ch;
        }

        private CursedChar[,] charMap;
        /// <summary>
        /// Initializes console to dimensions of 80x25
        /// </summary>
        public CursedConsole()
        {
            charMap = new CursedChar[80, 25];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="w">Console width</param>
        /// <param name="h">Console height</param>
        public CursedConsole(int w, int h)
        {
            charMap = new CursedChar[w, h];
        }

        public void init()
        {
            CursedChar c = new CursedChar();
            c.bgColor = Color.Black;
            c.charColor = Color.LightGray;
            c.ch = ' ';

            for (int i = 0; i < charMap.GetLength(0); i++)
            {
                for (int j = 0; j < charMap.GetLength(1); j++)
                {
                    charMap[i, j] = c;
                }
            }
        }

        public void setBgColor(int x, int y, Color c)
        {
            charMap[x, y].bgColor = c;
        }

        public void setCharColor(int x, int y, Color c)
        {
            charMap[x, y].charColor = c;
        }

        public void setChar(int x, int y, char c)
        {
            charMap[x, y].ch = c;
        }

        public void set(int x, int y, CursedChar c)
        {
            charMap[x, y] = c;
        }

        public CursedChar get(int x, int y)
        {
            return charMap[x, y];
        }

    }
}
