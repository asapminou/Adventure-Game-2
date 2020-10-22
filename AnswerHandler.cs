//TOO MUCH STUFF TO PUT INTO PROGRAM
// Copyright (C) 2020 Mainul Iftekher, All Rights Reserved
using System;

namespace AdventureGame
{
    public class AnswerHandler
    {
        public static void HandleMovement (string answer, Map map, Player player)
        {
            //get map location from player position
            Location loc = map.LocationAt(player.locX, player.locY);

            //prompt player that they are in an invalid location
            if(loc == null) 
            {
                Console.WriteLine("INVALID LOCATION");
                return;
            } 
            else 
            {
                int newPosX = 0;
                int newPosY = 0;

                //get player input
                if(answer == "left")
                {
                    newPosX = player.locX - 1;
                    newPosY = player.locY;
                } 
                else if(answer == "right")
                {
                    newPosX = player.locX + 1;
                    newPosY = player.locY;
                }
                else if(answer == "up")
                {
                    newPosX = player.locX;
                    newPosY = player.locY - 1;
                } 
                else if(answer == "down")
                {
                    newPosX = player.locX;
                    newPosY = player.locY + 1;
                }
                else
                {
                    return;
                }
                //check if where the player wants to go is valid
                if(map.IsLocation(newPosX, newPosY)) 
                {
                    //move the player
                    player.UpdatePlayerLocation(newPosX, newPosY);
                }
            }
        }

        
    }
}
