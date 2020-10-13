
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
        }
    }
}
