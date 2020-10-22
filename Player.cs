// Copyright (C) 2020 Mainul Iftekher, All Rights Reserved

using System;

namespace AdventureGame
{
    public class Player
    {
        // private variables

        // public variables
        public int locX = 0; //SETS THE START X POS
        public int locY = 0; //SETS THE START Y POS

        // constructor
        public Player(int x, int y)
        {
            locX = x;
            locY = y;
        }

        // methods

        public void UpdatePlayerLocation(int x, int y)
        {
            locX = x;
            locY = y;
        }
        static bool CanMove()
        {
            return true;
        }

    }
}