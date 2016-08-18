using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace A_Day_at_the_Races
{
    class Greyhound
    {
        public string Name;
        public int StartingPostion; //Where the picture box starts
        public int RacetrackLength; //Length of racetrack
        public PictureBox MyPictureBox = null;
        public int Location = 0; //My Location on the racetrack
        public Random Randomizer; //An instance of random
        public int distance;

        
        public int RandomNumber()
        {
            //Generates a random number between 1 and 4
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            distance = rnd.Next(1, 5);  
            
            return distance;
        }
        public bool Run()
        {
            //Move foward either 1,2,3 or 4 spaces at random 
            //Update the postion of my PictureBox on the form
            //Return true if I won the race
            
            //Current location of the picture
            Point p = MyPictureBox.Location;
            //Adds the value to move forward on its y coordinate
            p.Y += distance;
            //Updates the picture box location on the form
            MyPictureBox.Location = p;
            
            return true;
        }

        public void TakeStartingPosition()
        {
            new PictureBox();
            //Reset my location to the start line
            //Point p = MyPictureBox.Location;
            //p.Y = 3;
            //MyPictureBox.Top = 30;
            //MyPictureBox.Top = 10;
        }
    }


}
