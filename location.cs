// Copyright (C) 2020 Mainul Iftekher, All Rights Reserved
using System;

namespace AdventureGame
{
    public class Location

    {   
        private string _name;
        private string _description;

        // public bool CanGoUp {get; set;}
        // public bool CanGoDown {get; set;}
        // public bool CanGoLeft {get; set;}
        // public bool CanGoRight {get; set;}

        public Location (string name, string desc)
        {
            _name = name;
            _description = desc;
            // CanGoUp = true;
            // CanGoDown = true;
            // CanGoLeft = true;
            // CanGoRight = true;
        } 

        public string Name() { return _name; }

        public string Desc() { return _description; }
        // public void SetDirections(bool up, bool down, bool left, bool right)
        // {
        //     CanGoUp = up;
        //     CanGoDown = down;
        //     CanGoLeft = left;
        //     CanGoRight = right;
        // }
    }
}
