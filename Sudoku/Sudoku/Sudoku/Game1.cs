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
    
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        Cell exCell;
        
        public Game1()
        {
            Tools.gdm = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        
        protected override void Initialize()
        {
            Tools.initilize(this.Content);
            exCell = new Cell(0, new Vector2(50, 50), 0);

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            
        }

        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Tools.sb.Begin();
            exCell.drawCell();
            Tools.sb.End();

            base.Draw(gameTime);
        }
    }
}
