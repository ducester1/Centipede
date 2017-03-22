using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class GameOverGameState : GameObjectList
    {
        TextGameObject text;
        public GameOverGameState()
        {
            text = new TextGameObject("GameFont");
            text.Text = "Game Over!";
            text.Position = new Vector2(200, 200);

            this.Add(text);

        }
    }
}
