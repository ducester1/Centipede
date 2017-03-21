using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Bullet : SpriteGameObject
    {
        public Bullet()
            :base("spr_bullet")
        {
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            velocity = Vector2.Zero;
            position.Y = -100;
        }

        public void Fire(Vector2 position)
        {
            this.position = position;
            this.position.Y -= 20;
            this.position.X += 13;
            velocity.Y = -200;
        }
    }
}
