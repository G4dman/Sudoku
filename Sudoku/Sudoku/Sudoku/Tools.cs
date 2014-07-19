#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#endregion

namespace Sudoku
{
    public delegate void SigUpdate();
    public delegate void SigDraw();
    /// <summary>
    /// This static class contains basic tools in order to work with
    /// XNA effectivly.
    /// </summary>
    class Tools
    {
        public static ContentManager cm;
        public static SpriteBatch sb;
        public static GraphicsDeviceManager gdm;
        public static GraphicsDevice gd;

        public static void initilize(ContentManager cm) 
        {
            Tools.cm = cm;
            Tools.gd = gdm.GraphicsDevice;
            sb = new SpriteBatch(gd);
        }
    }
}
