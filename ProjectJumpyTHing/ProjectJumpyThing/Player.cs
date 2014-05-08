using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectJumpyThing
{
    class Player : MovableGameObject
    {
        int nrOfPlayers;
        public Player(Texture2D tex, Vector2 pos, int nrOfPlayer)
        {
            this.texture = tex;
            this.position = pos;
            this.nrOfPlayers = nrOfPlayer;
        }
    }
}
