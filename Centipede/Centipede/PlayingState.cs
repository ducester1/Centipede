using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class PlayingState : GameObjectList
    {
        SpriteGameObject background;
        public PlayingState()
        {
            background = new SpriteGameObject("spr_background");

            this.Add(background);
        }
    }
}
