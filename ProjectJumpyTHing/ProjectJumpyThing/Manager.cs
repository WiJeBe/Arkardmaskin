using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectJumpyThing
{
    class Manager
    {
        #region Variables
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion

        private void CollisionChecking(MovableGameObject ObjectA, MovableGameObject ObjectB)
        {
            if (ObjectA is Player)
            {
                if (ObjectB is Platform && ObjectA.velocity.Y > 0)
                {
                    if (
                        (ObjectB as Platform).SurfaceRectangle.Contains(ObjectA.collisionRectangle.Left, ObjectA.collisionRectangle.Bottom) ||
                        (ObjectB as Platform).SurfaceRectangle.Contains(ObjectA.collisionRectangle.Center, ObjectA.collisionRectangle.Bottom) ||
                        (ObjectB as Platform).SurfaceRectangle.Contains(ObjectA.collisionRectangle.Right, ObjectA.collisionRectangle.Bottom)
                        )
                    {
                        ObjectA.velocity.Y = 0;
                        ObjectA.position.Y = (ObjectB as Platform).SurfaceRectangle.Top + 1;
                    }
                }
                else if (ObjectB is Player)
                {
                    
                }

                else if (ObjectB is PowerUp)
                {

                }
            }
        }
    }
}

