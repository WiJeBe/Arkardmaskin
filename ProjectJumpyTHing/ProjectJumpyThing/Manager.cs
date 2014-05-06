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
                    (ObjectB as Platform);
                    if (
                        (ObjectB as Platform).SurfaceRectangle.Contains(ObjectA.rectangle.Left, ObjectA.rectangle.Bottom) ||
                        (ObjectB as Platform).SurfaceRectangle.Contains(ObjectA.rectangle.Center, ObjectA.rectangle.Bottom) ||
                        (ObjectB as Platform).SurfaceRectangle.Contains(ObjectA.rectangle.Right, ObjectA.rectangle.Bottom)
                        )
                    {
                        ObjectA.velocity.Y = 0;
                        ObjectA.position.X = (ObjectB as Platform).SurfaceRectangle.Top + 1;
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

