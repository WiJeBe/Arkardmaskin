﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectJumpyThing
{
   abstract class MovableGameObject : gameobjects.GameObject
    {
       public Vector2 velocity;
       public Vector2 acceleration; 
       public Rectangle collisionRectangle;
       private float gravity = 9.81f; 

       // thought that player class will call method when pressing buttons. and then it will move 
       // powerups will have call move function with a bool that is always true 
       // plattforms will call move but will not call gravity 
       public void Move(bool up,bool left, bool right )
       {
           if (up)
           {
               position.Y -= velocity.Y; 
           }
           if (left)
           {
               position.X -= velocity.X;
           }
           if (right)
           {
               position.X += velocity.X;
           }
       }

       
       public void IsHit()
       {
          
       }

       public override void Update()
       {

       }

       public void Gravity(GameTime gameTime)
       {
           acceleration.Y = gravity; 
           velocity += acceleration * gameTime.ElapsedGameTime.Milliseconds;
           position += velocity; 
       }

       public void Jump()
       {
           velocity.Y += 10;
           position.Y += velocity.Y; 
       }
    }
}
