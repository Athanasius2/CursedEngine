﻿using System;
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

        public const int charWidth = 8;
        public const int charHeight = 16;
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
            c.bgColor = Color.Green;
            c.charColor = Color.LightGray;
            c.ch = '1';

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

        public int getWidth()
        {
            return charMap.GetLength(0);
        }

        public int getHeight()
        {
            return charMap.GetLength(1);
        }

        public void draw(int x, int y, Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.Black);
            Font f = new Font("Lucida Console", 8);
            for (int i = 0; i < charMap.GetLength(0); i++)
                for (int j = 0; j < charMap.GetLength(1); j++)
                {
                    b.Color = charMap[i, j].bgColor;
                    g.FillRectangle(b, new Rectangle(x + (i * charWidth), y + (j * charHeight) - 4, charWidth, charHeight));
                    b.Color = charMap[i, j].charColor;
                    g.DrawString(charMap[i, j].ch.ToString(), f, b, new PointF(x + (i * charWidth), y + (j * charHeight)));
                }
            b.Dispose();
            f.Dispose();
        }

    }
}