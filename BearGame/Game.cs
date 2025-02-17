using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MathNet.Numerics.Random;

namespace BearGame
{
    public class Game
    {
        public Player[] Players { get; set; }
        public List<Player> ActivePlayers { get; set; }
        public Player? Winner { get; set; }


        public Game(Player[] players)
        {
            if (players.Length < 2 || players.Length > 4)
            {
                throw new ArgumentException("Invalid number of players");
            }

            _dice = new MersenneTwister();
            Players = players;
            ActivePlayers = players.ToList();
            Winner = null;
        }

        public void StartGame(int numberOfMatches)
        {
            for (int i = 0; i < numberOfMatches; i++)
            {
                StartMszvh();
                ResetGame();
            }
        }

        public void StartMszvh()
        {
            int activePlayerIndex = 0;

            while (ActivePlayers.Count != 0)
            {
                int roll = RollDice();

                Character? characterToMove = DecideWhichCharacterToMove(roll, ActivePlayers[activePlayerIndex]);

                if (characterToMove != null)
                {
                    ActivePlayers[activePlayerIndex].MoveCahracter(roll, characterToMove);
                }

                activePlayerIndex++;
                if (activePlayerIndex >= ActivePlayers.Count)
                {
                    activePlayerIndex = 0;
                }
            }
        }

        public void ResetGame()
        {
            foreach (Player player in Players)
            {
                player.Reset();
            }

            Winner = null;
            ActivePlayers = Players.ToList();
        }

        private MersenneTwister _dice;

        private int RollDice()
        {
            return _dice.Next(1, 7);
        }

        private Character? DecideWhichCharacterToMove(int roll, Player player)
        {
            return null;
        }

    }
}