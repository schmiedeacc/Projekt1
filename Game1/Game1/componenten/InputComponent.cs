using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    internal class InputComponent : GameComponent
    {

        public Vector2 Direction
        {
            get;
            private set;
        }

        public  InputComponent (Game1 game) : base(game)
        {

        }
        public override void Update(GameTime gameTime)
        {
            /*
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if  (Keyboard.GetState().IsKeyDown(Keys.Left))
                 Direction = new Vector2(-1f, 0f);

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                Direction = new Vector2(1f, 0f);

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                Direction = new Vector2(0f, 1f);

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                Direction = new Vector2(0f, -1f);
            */

            GamePadState state = GamePad.GetState(PlayerIndex.One);
            Direction = state.ThumbSticks.Left * new Vector2(1f, -1f);

            base.Update(gameTime);
        }
    }
}
