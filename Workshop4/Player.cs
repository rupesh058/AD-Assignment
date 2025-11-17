using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    class Player
    {
        public string playerName;
        public int level;
        public int health;

        // default constructor
        public Player()
        {
            Console.WriteLine("Default constructor has been called");
            playerName = "Unknown";
            level = 1;
            health = 100;
        }

        // parameterized constructor
        public Player(string playerName, int level, int health)
        {
            this.playerName = playerName;
            this.level = level;
            this.health = health;
        }

        public void PrintPlayerInfo()
        {
            Console.WriteLine("Player Name: " + playerName + ", Level: " + level + ", Health: " + health);
        }
    }
}
