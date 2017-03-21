using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class PlayingState : GameObjectList
    {
        SpriteGameObject background;
        Bullet bullet;
        GameObject player;
        public PlayingState()
        {
            background = new SpriteGameObject("spr_background");
            player = new Player();
            player.Position = new Vector2(235, 500);



            this.Add(background);
            this.Add(player);

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullet = new Bullet();
                bullet.Fire(player.Position);
                this.Add(bullet);
            }
        }
    }
}
