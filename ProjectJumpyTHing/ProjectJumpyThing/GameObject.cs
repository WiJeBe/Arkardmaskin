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
        //Thats not good enough
        //Swag
        public Texture2D texture;
        public Vector2 position;
        public Vector2 origin;
        public bool isDead;
        public SpriteEffects spriteEffect;
        public double scale;
        public Color color; 
<<<<<<< HEAD
        public virtual void Update(GameTime gameTime)
=======
        public virtual void Update()
>>>>>>> 7b70fcede42acf16428357f54350f09f9344dac0
        {

        }

        public virtual void Draw(SpriteBatch spritebatch)
<<<<<<< HEAD
        { 
            
        }
=======
        { }
>>>>>>> 7b70fcede42acf16428357f54350f09f9344dac0
        
            
        
    }
}
