using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectJumpyThing
{
    class LevelManager
    {
        int x;
        int collum;
        int lenght;

        Random rnd = new Random();

        List<Platform> platformList;

        public LevelManager(List<Platform> list)
        {
            this.platformList = list;
        }

        //skapa en metod som slumpar längden
        public int getLenght()
        {
            int lenght;
            lenght = rnd.Next(0, 3);
            return lenght;
        }

        //skapa en metod som slumpar kolum
        public int getCollumn()
        {
            int collum;
            collum = rnd.Next(0, 3);
            return collum;
        }

        //skapa en metod som slumpar x-värde i rätt kolum
        public int getX()
        {
            int x;
            x = rnd.Next(0, 3);
            return x;
        }

        //kolla om gammal plattform är utanför skärm
        public bool nextPlatform()
        {
                return true;
        }

        //public override void Update(GameTime gametime)
        //{
        //    //lägg till en plattform i listan(i klassen platform?)
        //    if (nextPlatform)
        //    {
        //        platformList.Add(x, collum, lenght);
        //    }
        //}
    }
}
