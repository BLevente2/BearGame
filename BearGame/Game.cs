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
        public bool MakeItSlower { get; set; }
        public double GameSpeed { get; set; }


        public Game(Player[] players)
        {
            if (players.Length < 2 || players.Length > 4)
            {
                throw new ArgumentException("Invalid number of players");
            }

            GameSpeed = 1;
            _dice = new MersenneTwister();
            Players = players;
            ActivePlayers = players.ToList();
            PlayerFinished = new List<Player>();
            MakeItSlower = true;
        }

        public async Task StartGame(int numberOfMatches)
        {
            for (int i = 0; i < numberOfMatches; i++)
            {
                await StartMatch();

                if (MakeItSlower)
                {
                    await Task.Delay((int)Math.Round(GameSpeed * 2000)); // Delay is in ms.
                }

                ResetGame();
            }
        }

        private void SetACharacterActiveFromAPlayer(Player player)
        {
            if (player.PlayerStartingSquare.BackColor != SystemColors.Control)
            {
                KnockOutACharacter(player, player.PlayerStartingSquare);
            }
            player.SetACharacterActive();
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
                    SetACharacterActiveFromAPlayer(currentPlayer);
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
                    await Task.Delay((int)Math.Round(GameSpeed * 500)); // Delay is in ms.
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

            if (player.PlayerStartingSquare.BackColor == player.PlayerColor && player.PlayerStrategy.PrioritizeOutOfStart)
            {
                return player.FindCahracterByLocation(player.PlayerStartingSquare);
            }

            if (roll == 6 && player.PlayerStrategy.PrioritizeNewCharacter && player.PlayerStartingSquare.BackColor != player.PlayerColor)
            {
                SetACharacterActiveFromAPlayer(player);
            }

            return selectedCharacter;
        }

        private Character? GoWithRandom(int roll, Player player)
        {
            return null;
        }

        private Character? GoWithClosest(int roll, Player player)
        {
            return null;
        }

        private Character? GoWithFurthest(int roll, Player player)
        {
            return null;
        }

        private Character? PriorityKO(int roll, Player player)
        {
            return null;
        }

        private Character? PriorityNewCharacter(int roll, Player player)
        {
            return null;
        }

        private Character? PriorityOutOfStart(int roll, Player player)
        {
            return null;
        }

    }
}