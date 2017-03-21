using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Player : SpriteGameObject
    {

        public Player()
            :base("spr_player")
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            position = Vector2.Clamp(position, Vector2.Zero, new Vector2(Centipede.Screen.X - Width, Centipede.Screen.Y - Height));
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            velocity = Vector2.Zero;
            if (inputHelper.IsKeyDown(Keys.Up)) velocity.Y = -200;
            if (inputHelper.IsKeyDown(Keys.Down)) velocity.Y = 200;
            if (inputHelper.IsKeyDown(Keys.Left)) velocity.X = -200;
            if (inputHelper.IsKeyDown(Keys.Right)) velocity.X = 200;
        }
    }
}
