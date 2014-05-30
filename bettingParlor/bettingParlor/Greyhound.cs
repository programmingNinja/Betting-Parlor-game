using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingParlor
{
    class Greyhound
    {
        public int startPos;
        public int raceTrackLen;
        public PictureBox myPicBox;
        public int myLoc = 0;
        public Random randomizer;

        public bool run()
        {
            //startPos += myLoc;
            myLoc += randomizer.Next(10) + 5;            
            myPicBox.Left = startPos + myLoc ;

            if (myLoc >= raceTrackLen)
               return true;

            return false;            
        }

        public void takeStartPos()
        {
            myLoc = 0;
            myPicBox.Left = myLoc;
        }
    }
}
