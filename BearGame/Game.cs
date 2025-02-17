using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearGame
{
    public class Game
    {
        public Player[] Players { get; set; }

        public Game(Player[] players)
        {
            if (players.Length < 2 || players.Length > 4)
            {
                throw new ArgumentException("Invalid number of players");
            }

            Players = players;
        }

        public void StartGame()
        {
            
        }

        public void ResetGame()
        {
            foreach (Player player in Players)
            {
                foreach (Character character in player.PlayerCharacters)
                {
                    character.Reset();
                }
            }
        }

    }
}