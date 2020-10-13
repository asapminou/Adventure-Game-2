
using System;

namespace AdventureGame
{

    class Map

    {
        private Location [,] _gameMap;
        
        public Map (int mapSize)
        {

            _gameMap = new Location[mapSize,mapSize];
        }

        public void Init()
        {
            // add new locations to the map
            _gameMap[0,0] = new Location("Living Room \n \n You see a woman sitting on the ground playing with a baby while paw patrol is on the tv.");
            _gameMap[0,0].SetDirections ( false, true, true, false);

            _gameMap[0,1] = new Location("Kitchen \n \n You see a man kaming breakfast, there's also a dog. It looks like he's waitng for his food");
            _gameMap[0,1].SetDirections ( false, true, true, false);

            _gameMap[0,2] = new Location("Basement \n \n You go downstairs and see a theatre room and a home gym. ");
            _gameMap[0,2].SetDirections ( false, true, true, false);

            _gameMap[0,3] = new Location("Backyard \n \n You walk out and walk to a huge backyard. There's swings and a slide and there are kids playing on it.");
            _gameMap[0,3].SetDirections ( false, true, true, false);

            _gameMap[0,4] = new Location("Doghouse \n \n The dog house has some toys, a water bowl and dog food.");
            _gameMap[0,4].SetDirections ( false, true, true, false);

            _gameMap[1,0] = new Location("Front Lawn \n \n The front lawn is all open space, realize that this is a beach house.");
            _gameMap[1,0].SetDirections ( false, true, true, false);

            _gameMap[1,1] = new Location("Street \n \n The street is parked with expensive cars and boats.");
            _gameMap[1,1].SetDirections ( false, true, true, false);

            _gameMap[1,2] = new Location("Park \n \n The park has a playground, an open field, a basketball and tennis court");
            _gameMap[1,2].SetDirections ( false, true, true, false);

            _gameMap[1,3] = new Location("Beach \n \n The beach is filled with people playing volleyball, swimming in the water and tanning.");
            _gameMap[1,3].SetDirections ( false, true, true, false);

            _gameMap[1,4] = new Location("Lighthouse \n \n The lighthouse is empty but has an eerie feeling to it.");
            _gameMap[1,4].SetDirections ( false, true, true, false);
        }
        public Location LocationAt (int i, int j)
        {
            return _gameMap[i,j];
        }
    }
}

