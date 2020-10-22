// Copyright (C) 2020 Mainul Iftekher, All Rights Reserved
using System;

namespace AdventureGame
{
    class Game
    {
        
        public const int MAP_SIZE = 10;
        // local variables
        private bool gameOver = false;
        private Map _gamemap = new Map();
    
        private Player _player = new Player(1, 3);

        public Game()
        {
            //create ,ap
            // load locations. location data

            // setup game


        }
        
        public void Run()
        {
            WelcomePlayer();
            _gamemap = new Map();
            Render();
            while(!gameOver)
            {
                Update();
                Render();
            }
        }

        private void Update() 
        {
            // collect user input
            string _answer = Console.ReadLine();

            AnswerHandler.HandleMovement(_answer, _gamemap, _player);

            //AnswerHandler.HandleAction(_answer); //THIS HERE IS TO LINK TO COLLECT ANSWERHANDLER
        }

        private void Render()
        {   
            Console.WriteLine(_gamemap.LocationAt(_player.locX, _player.locY).Name());
            // use the _currentLocation to show description
            Console.WriteLine(_gamemap.LocationAt(_player.locX, _player.locY).Desc());
            
        }

        //METHODS

        static void WelcomePlayer()
        {
            Console.WriteLine("What is your name?\n"); //prompt for name
            string name = Console.ReadLine(); 
            Console.Clear();
            Console.WriteLine("Hello "+ name);           
            Console.WriteLine("You wake up as a cat in a suburban home. You take a big stretch and are ready to explore.\n");
        }

        static void HandleAction(string answer) 
        {
            bool ifValid = false; // statement for invalid input
            

            for (int i = 0; i < 10; i++) // for loop so it goes from one location to the other. Trying to figure out how to go from one place to the next            
            { 
                ifValid = false;
                while (!ifValid)  //! means not true so only a, b, c can use as valid inputs/might also change to if else statements if i have less choices for some locations      
                {     
                    Console.WriteLine(i);
                            
                    switch (answer)
                    {
                        case "a":
                        {
                            ifValid = true;
                            Console.WriteLine("option A ");
                            
                            break;
                        }
                        case "b":
                        {
                            ifValid = true; 
                            Console.WriteLine("option B ");
                            
                            break;
                        }
                        case "c":
                        {
                            ifValid = true;
                            Console.WriteLine("option C");
                            
                            break;
                        }  
                                
                        default:
                        {
                            Console.WriteLine ("invalid input");
                            break;
                        }
                    }
                }       
            }
            Console.ReadLine();
        }
    }
}