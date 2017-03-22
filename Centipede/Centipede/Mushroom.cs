using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Mushroom : SpriteGameObject
    {
        public Mushroom()
            : base("spr_mushroom")
        {
            position = new Vector2(GameEnvironment.Random.Next(0, 470), GameEnvironment.Random.Next(25, 450));

        }
    }
}
