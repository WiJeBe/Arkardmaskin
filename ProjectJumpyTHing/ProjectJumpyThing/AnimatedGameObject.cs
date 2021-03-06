<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectJumpyThing
{
    class AnimatedGameObject : MovableGameObject
    {
        private int numFrame;
        public Rectangle textureRectangle; 
        private int currentFrame;
        private int maxNrFrame; 
        private double animationTimer;
        private double timePerFrame = 0.2;
        private float rotation;
        protected int frameHeight;
        protected int frameWidht;

        public override void Update(GameTime gametime)
        {
            base.Update();
            Animate(gametime);
        }
        public void Animate(GameTime gameTime)
        {
            animationTimer -= gameTime.ElapsedGameTime.TotalSeconds;
            if (animationTimer < 0)
            {
                if (currentFrame == maxNrFrame)
                {
                    currentFrame = 0;
                }
                else
                {
                    currentFrame++;
                    textureRectangle = new Rectangle(currentFrame*frameWidht,textureRectangle.Y,texture.Width,texture.Height);
                    animationTimer = timePerFrame;
                }
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectJumpyThing
{
    class AnimatedGameObject : MovableGameObject
    {
        private int numFrame;
        public Rectangle sourceRectangle; 
        private int currentFrame;

        public void Animate()
        {

        }
    }
}
>>>>>>> 7b70fcede42acf16428357f54350f09f9344dac0
