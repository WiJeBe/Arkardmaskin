using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectJumpyThing
{
    class Platform : MovableGameObject
    {
        public Rectangle SurfaceRectangle;
        float widthChange;
        float plattformWidth = 230, platformHeight = 20;
        

        public Platform(Texture2D tex, Vector2 pos, float widthChange)
        {
            this.texture = tex;
            this.position = pos;
            this.widthChange = widthChange;
            SurfaceRectangle = new Rectangle((int)position.X, (int)position.Y, (int)plattformWidth * (int)widthChange, (int)platformHeight);
            color = Color.Red;
        }

        public override void Update()
        {
            position += velocity;
            base.Update();
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(texture, SurfaceRectangle, color);
        }
    }



}
