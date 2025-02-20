using System;
using System.Collections.Generic;
using System.Drawing.Design;
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
        public bool MakeItSlower { get; set; }


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
            MakeItSlower = true;
        }

        public async Task StartGame(int numberOfMatches)
        {
            for (int i = 0; i < numberOfMatches; i++)
            {
                await StartMatch();

                if (MakeItSlower)
                {
                    await Task.Delay(1000);
                }

                ResetGame();
            }
        }

        public async Task StartMatch()
        {
            int activePlayerIndex = 0;

            while (ActivePlayers.Count != 0)
            {
                Player currentPlayer = ActivePlayers[activePlayerIndex];
                int roll = RollDice();
                Character? characterToMove = null;

                if (currentPlayer.ActiveCharacters.Count == 0 && currentPlayer.AllCahractersInFinalSquare == false && roll == 6)
                {
                    if (currentPlayer.PlayerStartingSquare.BackColor != SystemColors.Control)
                    {
                        KnockOutACharacter(currentPlayer, currentPlayer.PlayerStartingSquare);
                    }
                    currentPlayer.SetACharacterActive();
                }
                else if (currentPlayer.ActiveCharacters.Count == 1)
                {
                    characterToMove = currentPlayer.ActiveCharacters[0];
                    TextBox endOfMove = currentPlayer.PlayerSquares[currentPlayer.IndexOfMoveEndingSquare(characterToMove, roll)];

                    if (endOfMove.BackColor != SystemColors.Control && endOfMove.BackColor != currentPlayer.PlayerColor)
                    {
                        KnockOutACharacter(currentPlayer, endOfMove);
                    }
                }
                else
                {
                    characterToMove = DecideWhichCharacterToMove(roll, currentPlayer);
                }

                if (characterToMove != null)
                {
                    ActivePlayers[activePlayerIndex].MoveCahracter(roll, characterToMove);
                }

                if (currentPlayer.AllCahractersInFinalSquare)
                {
                    ActivePlayers.Remove(currentPlayer);
                    PlayerFinished.Add(currentPlayer);
                }

                activePlayerIndex++;
                if (activePlayerIndex >= ActivePlayers.Count)
                {
                    activePlayerIndex = 0;
                }

                if (MakeItSlower)
                {
                    await Task.Delay(200);
                }
            }
        }

        private void KnockOutACharacter(Player playerWhoMoves, TextBox knockOutLocation)
        {
            Player? playerToBeKnockedOut = WhichPlayerStandsHere(knockOutLocation);

            if (playerToBeKnockedOut == null)
            {
                throw new ArgumentException("Player not found to be knocked out.");
            }

            Character? characterToBeKnockedOut = playerToBeKnockedOut.FindCahracterByLocation(knockOutLocation);

            if (characterToBeKnockedOut == null)
            {
                throw new ArgumentException("Character is not found to be knocked out.");
            }

            playerToBeKnockedOut.KnockOutCharacterOfThisPlayer(characterToBeKnockedOut);

        }

        public Player? WhichPlayerStandsHere(TextBox location)
        {
            foreach (Player player in ActivePlayers)
            {
                if (location.BackColor == player.PlayerColor)
                {
                    return player;
                }
            }
            return null;
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