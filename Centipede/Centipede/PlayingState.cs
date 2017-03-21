using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class PlayingState : GameObjectList
    {
        SpriteGameObject background;
        GameObject player;
        public PlayingState()
        {
            background = new SpriteGameObject("spr_background");
            player = new Player();
            player.Position = new Vector2(235, 500);


            this.Add(background);
            this.Add(player);
        }


    }
}
