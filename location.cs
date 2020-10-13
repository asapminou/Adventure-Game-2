// copy right (c) Mainul Iftekher
using System;

namespace AdventureGame
{
    class Location

    {   
        public const int UP = 0;
        private string _description;

        public bool CanGoUp {get; set;}
        public bool CanGoDown {get; set;}
        public bool CanGoLeft {get; set;}
        public bool CanGoRight {get; set;}


        public Location (string desc)
        {
            _description = desc;
            CanGoUp = true;
            CanGoDown = true;
            CanGoLeft = true;
            CanGoRight = true;
        }   

        public void SetDirections(bool up, bool down, bool left, bool right)
        {
            CanGoUp = up;
            CanGoDown = down;
            CanGoDown = left;
            CanGoRight = right;
        }
        
            
    

    }






}
