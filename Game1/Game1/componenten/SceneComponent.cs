﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
   internal class SceneComponent : DrawableGameComponent
    {

        private SpriteBatch spriteBatch;
        //private Texture2D star;
        private Texture2D pixel;
        private Game1 game;

        public SceneComponent (Game1 game) : base (game)
        {
            this.game = game;
        }

        protected override void LoadContent()
        {

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //star = game.Content.Load<Texture2D>("starGold");
            pixel = new Texture2D(GraphicsDevice, 1, 1);
            pixel.SetData<Color>(new Color[] { Color.White });


            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);


            int width = GraphicsDevice.Viewport.Width - 20;
            int height = GraphicsDevice.Viewport.Height - 20;

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            //spriteBatch.Draw(star, game.Simulation.Position, Color.White);
            spriteBatch.Draw(pixel, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, 10), Color.DarkGray);
            spriteBatch.Draw(pixel, new Rectangle(0, GraphicsDevice.Viewport.Height -10, GraphicsDevice.Viewport.Width, 10), Color.DarkGray);
            //spriteBatch.Draw(pixel, new Rectangle(0, 0, 10, GraphicsDevice.Viewport.Height), Color.DarkGray);
            spriteBatch.Draw(pixel, new Rectangle(GraphicsDevice.Viewport.Width -10, 0, 10, GraphicsDevice.Viewport.Height), Color.DarkGray);


            spriteBatch.Draw(pixel, new Rectangle(
                (int)(game.Simulation.BallPosition.X * width) +10, 
                (int)(game.Simulation.BallPosition.Y * height) + 10, 10, 10), Color.White);

            int PlayerRadius = (int)(game.Simulation.PlayerSize * height) / 2;
            int player = (int)(height * game.Simulation.PlayerPosition) - PlayerRadius + 10;

            spriteBatch.Draw(pixel, new Rectangle(0, player, 10, PlayerRadius * 2), Color.DarkGray);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
