using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Centipede
{
    class Score : TextGameObject
    {
        public int score = 0;

        public Score()
            :base("GameFont")
        {
            position = Vector2.Zero;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            text = score.ToString();
        }
    }
}
