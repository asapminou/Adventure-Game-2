// Copyright (C) 2020 Mainul Iftekher, All Rights Reserved
using System;

namespace AdventureGame
{
        
    
    
    class Program
    {

        
        static void Main(string[] args)
        {
            // Welcome the player
            WelcomePlayer();

            // initilize the game map
            string [,] gameMap = new string [5,5];
            gameMap = InitMap();
            // set the initial player location
            int[,] playerLocation = SetPlayerLocation (0,0);
        
        
            // display location
            DisplayLocation (playerLocation, gameMap);

            
            // prompt player for actions
            string answer = GetPlayerAction();
            
            // update player state based on their actions
            updatePlayerLocation();

            static void updatePlayerLocation

            // go back to display location
                //  

            
            // string [,] gameMap = new string [5,5]; cut and paste location list to game map list 2D GRID MAP
            // int [,] playerLocation = {{ 0 }, { 0 }}; x,y location on GRID
            
             // [x,y] represents location of player
            
            
        

            // string [] locationList = new string [10]; // list of locations. changed to gameMap
            
            



            bool ifValid = false; // statement for invalid input
            
            for (int i = 0; i < 10; i++) // for loop so it goes from one location to the other. Trying to figure out how to go from one place to the next
            
                    { ifValid = false;
                        while (!ifValid)  //! means not true so only a, b, c can use as valid inputs/might also change to if else statements if i have less choices for some locations

                        
                        {
                            
                            Console.WriteLine(i);
                            
                        
                            Console.WriteLine(gameMap[playerLocationX, playerLocationY]);
                           
                            

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
    
        static void WelcomePlayer()
        {
            Console.WriteLine("What is your name?\n"); //prompt for name
            string name = Console.ReadLine(); 
            Console.Clear();
            Console.WriteLine("Hello "+ name);           
            Console.WriteLine("You wake up as a cat in a suburban home. You take a big stretch and are ready to explore.\n");
        }
        static string[,] InitMap()
        {
            string [,] tempMap = new string [5,5];
            tempMap[0,0] = "Living Room \n \n You see a woman sitting on the ground playing with a baby while paw patrol is on the tv.";
            tempMap[0,1] = "Kitchen \n \n You see a man kaming breakfast, there's also a dog. It looks like he's waitng for his food";
            tempMap[0,2] = "Basement \n \n You go downstairs and see a theatre room and a home gym. ";
            tempMap[0,3] = "Backyard \n \n You walk out and walk to a huge backyard. There's swings and a slide and there are kids playing on it.";
            tempMap[0,4] = "Doghouse \n \n The dog house has some toys, a water bowl and dog food.";
            tempMap[1,0] = "Front Lawn \n \n The front lawn is all open space, realize that this is a beach house.";
            tempMap[1,1] = "Street \n \n The street is parked with expensive cars and boats.";
            tempMap[1,2] = "Park \n \n The park has a playground, an open field, a basketball and tennis court";
            tempMap[1,3] = "Beach \n \n The beach is filled with people playing volleyball, swimming in the water and tanning.";
            tempMap[1,4] = "Lighthouse \n \n The lighthouse is empty but has an eerie feeling to it. ";
            
            return tempMap;
        }
    
        static int[,] SetPlayerLocation( int x, int y)
        {
            int[,] tempLoc = {{x,y}};
            int playerLocationX = 0;
            int playerLocationY = 0;
            return tempLoc;
        }
        static void DisplayLocation (int[,] loc, string[,] map)
        {

        }
        static string GetPlayerAction()

        {
        string [] promptList = new string[10]; // user prompts
          
            promptList[0] = "a)\n b)\n c)";
            promptList[1] = "a)\n b)\n c)";
            promptList[2] = "a)\n b)\n c)";
            promptList[3] = "a)\n b)\n c)";
            promptList[4] = "a)\n b)\n c)";
            promptList[5] = "a)\n b)\n c)";
            promptList[6] = "a)\n b)\n c)";
            promptList[7] = "a)\n b)\n c)";
            promptList[8] = "a)\n b)\n c)";
            promptList[9] = "a)\n b)\n c)";

            Console.WriteLine(promptList[i]);
            string answer = Console.ReadLine();

            return answer;
        }
    }



}