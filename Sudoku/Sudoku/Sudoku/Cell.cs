using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Sudoku
{
    class Cell
    {
        byte value { get; set; }
        Vector2 position { get;  set; }
        int id { get;  set; }
        private const int LINELENGTH = 25;
        private static Texture2D cellTexutre = Tools.cm.Load<Texture2D>("Cell");

        public Cell(byte value, Vector2 position, int id)
        {
            this.value = value;
            this.position = position;
            this.id = id;
        }

        public Rectangle getCellRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, LINELENGTH, LINELENGTH);
        }

        public void drawCell()
        {
            Tools.sb.Draw(cellTexutre, position, Color.White);
        }
    }
}
