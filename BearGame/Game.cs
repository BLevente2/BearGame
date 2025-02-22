﻿using MathNet.Numerics.Random;

namespace BearGame;

public class Game
{
    #region Properties&Constructors

    private MersenneTwister _dice;
    private List<Player> _activePlayers;
    private Player[] _players;
    private List<Player> _playersFinished;
    private CheckBox _slowModeBox;
    private TrackBar _gameSpeedBar;
    private ProgressBar _simulationProgress;
    private Label _simulationProgressLabel;

    public bool SlowMode => _slowModeBox.Checked;
    public double GameSpeed => 10.0 / _gameSpeedBar.Value;
    public long TotalNumberOfPlayersFinished { get; private set; }
    public long CurrentNumberOfPlayersFinished { get; private set; }
    public int SimulationProgress => (int)Math.Round((double)CurrentNumberOfPlayersFinished / TotalNumberOfPlayersFinished * _simulationProgress.Maximum);
    public string Progress => $"Progress: {SimulationProgress / 10.0} %";

    public Game(Player[] players, CheckBox slowModeBox, TrackBar gameSpeedBar, ProgressBar simulationProgress, Label simulationProgressLabel)
    {
        if (players.Length < 2 || players.Length > 4)
        {
            throw new ArgumentException("Invalid number of players");
        }

        _slowModeBox = slowModeBox;
        _gameSpeedBar = gameSpeedBar;
        _simulationProgress = simulationProgress;
        _simulationProgressLabel = simulationProgressLabel;
        _dice = new MersenneTwister();
        _players = players;
        _activePlayers = players.ToList();
        _playersFinished = new List<Player>();
    }

    #endregion

    public async Task StartGame(int numberOfMatches)
    {
        TotalNumberOfPlayersFinished = numberOfMatches * _players.Length;
        CurrentNumberOfPlayersFinished = 0;
        _simulationProgressLabel.Text = Progress;

        for (int i = 0; i < numberOfMatches; i++)
        {
            await StartMatch();

            _simulationProgress.Value = SimulationProgress;
            _simulationProgressLabel.Text = Progress;
            await Task.Delay(1); // Delay is in ms.

            if (SlowMode)
            {
                await Task.Delay((int)Math.Round(GameSpeed * 2000)); // Delay is in ms.
            }

            ResetGame();
        }
    }

    public void ResetGame()
    {
        foreach (Player player in _players)
        {
            player.Reset();
        }

        _playersFinished.Clear();
        _activePlayers = _players.ToList();
    }

    public async Task StartMatch()
    {
        int numberOfCicles = 0;
        int i = 0;
        while (_activePlayers.Count != 0)
        {
            numberOfCicles++;

            if (i > _activePlayers.Count - 1)
            {
                i = 0;
            }

            Player currentPlayer = _activePlayers[i];

            int roll = RollDice();
            Character? characterToMove = characterToMove = DecideWhichCharacterToMove(roll, currentPlayer);

            if (characterToMove != null)
            {
                TextBox endOfMove = currentPlayer.PlayerSquares[currentPlayer.IndexOfMoveEndingSquare(characterToMove, roll)];

                if (endOfMove.BackColor != SystemColors.Control && endOfMove.BackColor != currentPlayer.PlayerColor)
                {
                    KnockOutACharacter(currentPlayer, endOfMove);
                }
                currentPlayer.MoveCharacter(roll, characterToMove);
            }

            if (currentPlayer.AllCahractersInFinalSquare)
            {
                _activePlayers.Remove(currentPlayer);
                _playersFinished.Add(currentPlayer);
                CurrentNumberOfPlayersFinished++;

                if (_playersFinished.Count == _players.Length)
                {
                    break;
                }
            }

            i++;
            if (i == _activePlayers.Count)
            {
                i = 0;
            }

            if (SlowMode)
            {
                await Task.Delay((int)Math.Round(GameSpeed * 500)); // Delay is in ms.
            }
        }
    }

    private Character? DecideWhichCharacterToMove(int roll, Player player)
    {
        if ((player.PlayerStrategy.PrioritizeNewCharacter || player.ActiveCharacters.Count == 0) && (roll == 6 && player.PlayerStartingSquare.BackColor != player.PlayerColor && player.IsThereCharacterInStartingSquare()))
        {
            SetACharacterActiveFromAPlayer(player);
            return null;
        }

        if (player.ActiveCharacters.Count == 0)
        {
            return null;
        }

        Character? selectedCharacter = null;
        List<Character> charactersThatCanMove = player.GetCharactersThatCanMove(roll);

        if (charactersThatCanMove.Count == 0)
        {
            return null;
        }

        if (player.PlayerStrategy.PrioritizeOutOfStart && player.PlayerStartingSquare.BackColor == player.PlayerColor)
        {
            selectedCharacter = PriorityOutOfStart(roll, player);
            if (selectedCharacter != null && charactersThatCanMove.Contains(selectedCharacter))
            {
                return selectedCharacter;
            }
        }
        if (player.PlayerStrategy.PrioritizeKO)
        {
            selectedCharacter = PriorityKO(roll, player, charactersThatCanMove);
            if (selectedCharacter != null)
            {
                return selectedCharacter;
            }
        }

        if (player.PlayerStrategy.GoWithRandom)
        {
            return charactersThatCanMove[_dice.Next(0, charactersThatCanMove.Count)];
        }

        if (player.PlayerStrategy.GoWithClosest)
        {
            selectedCharacter = GoWithClosest(roll, player, charactersThatCanMove);
            if (selectedCharacter != null)
            {
                return selectedCharacter;
            }
        }

        if (player.PlayerStrategy.GoWithFurthest)
        {
            selectedCharacter = GoWithFurthest(roll, player, charactersThatCanMove);
        }

        return selectedCharacter;
    }

    private void SetACharacterActiveFromAPlayer(Player player)
    {
        if (player.PlayerStartingSquare.BackColor != SystemColors.Control && player.PlayerStartingSquare.BackColor != player.PlayerColor)
        {
            KnockOutACharacter(player, player.PlayerStartingSquare);
        }
        player.SetACharacterActive();
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
        foreach (Player player in _activePlayers)
        {
            if (location.BackColor == player.PlayerColor)
            {
                return player;
            }
        }
        return null;
    }

    private int RollDice()
    {
        return _dice.Next(1, 7);
    }

    private Character? GoWithClosest(int roll, Player player, List<Character> cahractersThatCanMove)
    {
        int minIndex = 2 * (2 * Player.NUMBER_OF_CHARACTERS + Player.NUMBER_OF_MOVEMENT_SQUARES - 1);
        foreach (Character character in cahractersThatCanMove)
        {
            if (character.LocationIndex < minIndex)
            {
                minIndex = character.LocationIndex;
            }
        }
        return cahractersThatCanMove.Find(character => character.LocationIndex == minIndex);
    }

    private Character? GoWithFurthest(int roll, Player player, List<Character> cahractersThatCanMove)
    {
        int maxIndex = 0;
        foreach (Character character in cahractersThatCanMove)
        {
            if (character.LocationIndex > maxIndex)
            {
                maxIndex = character.LocationIndex;
            }
        }
        return cahractersThatCanMove.Find(character => character.LocationIndex == maxIndex);
    }

    private Character? PriorityKO(int roll, Player player, List<Character> charactersThatCanMove)
    {
        foreach (Character character in charactersThatCanMove)
        {
            TextBox endOfMove = player.PlayerSquares[player.IndexOfMoveEndingSquare(character, roll)];
            if (endOfMove.BackColor != SystemColors.Control && endOfMove.BackColor != player.PlayerColor)
            {
                return character;
            }
        }
        return null;
    }

    private Character? PriorityOutOfStart(int roll, Player player)
    {
        Character? character = player.FindCahracterByLocation(player.PlayerStartingSquare);

        if (character == null)
        {
            throw new ArgumentException("Character not found in starting square.");
        }

        return character;
    }

}