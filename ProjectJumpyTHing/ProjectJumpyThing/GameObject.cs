using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectJumpyThing.gameobjects
{

    abstract class GameObject
    {
        public Texture2D texture;
        public Vector2 position;
        public Vector2 origin;
        public bool isDead;
        public SpriteEffects spriteEffect;
        public double scale;
        public Color color; 
        public abstract void Update()
        {

        }

        public abstract void Draw(SpriteBatch spritebatch)
        {
            
        }
    }
}
