using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectJumpyThing
{
    class AnimatedGameObject : MovableGameObject
    {
        public int numFrames;
        public Rectangle drawRextangle;
        public Rectangle sourceRectangle;
        public int currentFrame;

        public void Animate()
        {

        }
    }
}
