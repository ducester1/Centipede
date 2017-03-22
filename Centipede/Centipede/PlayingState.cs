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
        GameObjectList snake, mushrooms, bullets;
        SnakeSegment newSnakeSegment;
        Mushroom newMushroom;

        public PlayingState()
        {
            background = new SpriteGameObject("spr_background");
            player = new Player();
            player.Position = new Vector2(235, 500);
            snake = new GameObjectList();
            mushrooms = new GameObjectList();
            bullets = new GameObjectList();

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
            this.Add(bullets);

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullet = new Bullet();
                bullet.Fire(player.Position);
                bullets.Add(bullet);
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
            foreach (SnakeSegment s in snake.Objects)
            {
                foreach (Mushroom m in mushrooms.Objects)
                {
                    if (s.CollidesWith(m) && s.Visible) s.bounce();
                }

                foreach (Bullet b in bullets.Objects)
                {
                    if (b.CollidesWith(s) && s.Visible)
                    {
                        bullet.Reset();
                        s.Visible = false;
                        newMushroom = new Mushroom();
                        newMushroom.Position = s.Position;
                        mushrooms.Add(newMushroom);
                    }
                }
            }  
            
            foreach (Bullet b in bullets.Objects)
            {
                foreach (Mushroom m in mushrooms.Objects)
                {
                    if (b.CollidesWith(m) && m.Visible)
                    {
                        bullet.Reset();
                        m.Visible = false;
                    }
                }
            }
        }
    }
}
