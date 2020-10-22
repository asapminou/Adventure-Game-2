// Copyright (C) 2020 Mainul Iftekher, All Rights Reserved
using System;

namespace AdventureGame
{
    public class Map
    {
        public Location[,] _locations;
        
        public Map()
        {
            Init();
        }

        void Init()
        {
            _locations = new Location[,] 
            {
                {
                    new Location("lighthouse", "The lighthouse is empty but has an eerie feeling to it. A bright light shines and you disappear."),
                    new Location("street2", ""), // empty location
                    null,
                    new Location("kitchen", "You see a man making breakfast, there's also a dog. It looks like he's waitng for his food.\n up \n down \n left \n right"),
                    null
                },
                {
                    new Location ("beach", "The beach is filled with people playing volleyball, swimming in the water and tanning.\n up \n down \n left \n right"),
                    new Location ("street", "The street is parked with expensive cars and boats.\n up \n down \n left \n right"),
                    new Location ("front lawn", "The front lawn is all open space, realize that this is a beach house.\n up \n down \n left \n right"),
                    new Location ("living room", "You see a woman sitting on the ground playing with a baby while paw patrol is on the tv.\n up \n down \n left \n right"),
                    new Location ("backyard", "You walk out and walk to a huge backyard. There's swings and a slide and there are kids playing on it\n up \n down \n left \n right"),
                },
                {
                    null,
                    new Location("park", "The park has a playground, an open field, a basketball and tennis court.\n up \n down \n left \n right"),
                    null,
                    new Location("basement", "You go downstairs and see a theatre room and a home gym."),
                    new Location("dog house", "The dog house has some toys, a water bowl and dog food. Another dog tells you to try to find the light house.\n up \n down \n left \n right")
                }
            };

        }

        public Location LocationAt(int i, int j)
        {
            if(IsLocation(i, j)) return _locations[i,j];
            else return null;
        }

        public bool IsLocation(int i, int j)
        {
            //return nothing if i & j is out of bounds
            //if((i < 0) && (j < 0) && ...) return null
            if(i < 0) return false;
            else if(j < 0) return false;
            else if(i >= _locations.GetLength(0)) return false;
            else if(j >= _locations.GetLength(1)) return false;
            else if(_locations[i,j] == null) return false;
            else return true;
        }
    }
}

