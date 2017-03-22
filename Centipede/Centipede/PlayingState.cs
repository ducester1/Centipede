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
        GameObjectList snake, mushrooms;
        SnakeSegment newSnakeSegment;
        Mushroom newMushroom;
        public PlayingState()
        {
            background = new SpriteGameObject("spr_background");
            player = new Player();
            player.Position = new Vector2(235, 500);
            snake = new GameObjectList();
            mushrooms = new GameObjectList();

            for (int i = 0; i < 10; i++)
            {
                newSnakeSegment = new SnakeSegment(new Vector2(i*32,0));
                snake.Add(newSnakeSegment);
            }

            for (int i = 0; i < 20; i++)
            {
                newMushroom = new Mushroom();
                mushrooms.Add(newMushroom);
            }



            this.Add(background);
            this.Add(player);
            this.Add(snake);
            this.Add(mushrooms);

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
