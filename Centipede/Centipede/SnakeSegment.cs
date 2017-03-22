using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class SnakeSegment : SpriteGameObject
    {
        public SnakeSegment(Vector2 startPosition)
            :base("spr_snakebody")
        {
            position = startPosition;
            velocity.X = 200;
        }

        public void bounce()
        {
            velocity *= -1;
            position.Y += 32;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (BoundingBox.Right > Centipede.Screen.X || BoundingBox.Left < 0) bounce();
        }
    }
}
