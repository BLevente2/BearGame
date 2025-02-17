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
        public List<Player> PlayerFinished { get; set; }
        public GameStrategy Strategy { get; set; }


        public Game(Player[] players, GameStrategy strategy)
        {
            if (players.Length < 2 || players.Length > 4)
            {
                throw new ArgumentException("Invalid number of players");
            }

            _dice = new MersenneTwister();
            Players = players;
            ActivePlayers = players.ToList();
            PlayerFinished = new List<Player>();
            Strategy = strategy;
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

            PlayerFinished.Clear();
            ActivePlayers = Players.ToList();
        }

        private MersenneTwister _dice;

        private int RollDice()
        {
            return _dice.Next(1, 7);
        }

        private Character? DecideWhichCharacterToMove(int roll, Player player)
        {
            Character? selectedCharacter = null;

            switch (Strategy)
            {
                case GameStrategy.AlwaysGoForKnockOut:
                    selectedCharacter = GoForKnockOuts(roll, player);
                    break;
                case GameStrategy.GoWithWhatsFurthest:
                    selectedCharacter = GoWithFurthest(roll, player);
                    break;
                case GameStrategy.GoWithWhatsClosest:
                    selectedCharacter = GoWithClosest(roll, player);
                    break;
                case GameStrategy.ActionWithRandomCharacter:
                    selectedCharacter = GoWithRandom(roll, player);
                    break;
                default:
                    selectedCharacter = null;
                    break;
            }
            return selectedCharacter;
        }

        private Character? GoForKnockOuts(int roll, Player player)
        {
            return null;
        }

        private Character? GoWithFurthest(int roll, Player player)
        {
            return null;
        }

        private Character? GoWithClosest(int roll, Player player)
        {
            return null;
        }

        private Character? GoWithRandom(int roll, Player player)
        {
            return null;
        }

    }
}