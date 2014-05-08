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
<<<<<<< HEAD
        public Color color;
        
        public virtual void Update()
=======
        public Color color; 
<<<<<<< HEAD
        public virtual void Update(GameTime gameTime)
=======
        public virtual void Update()
>>>>>>> 7b70fcede42acf16428357f54350f09f9344dac0
>>>>>>> 2cd5e491b476f72ab49cd12f5150837937d2dcb0
        {

        }

        public virtual void Draw(SpriteBatch spritebatch)
<<<<<<< HEAD
        {
           
        }
=======
<<<<<<< HEAD
        { 
            
        }
=======
        { }
>>>>>>> 7b70fcede42acf16428357f54350f09f9344dac0
>>>>>>> 2cd5e491b476f72ab49cd12f5150837937d2dcb0
        
            
        
    }
}
