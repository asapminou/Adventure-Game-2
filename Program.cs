// Copyright (C) 2020 Mainul Iftekher, All Rights Reserved
using System;

namespace AdventureGame
{
    
    public class Options
        {
            //public
            public const int MAP_SIZE = 10;
            public const bool DEBUG_MODE = true;
        }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }
}
