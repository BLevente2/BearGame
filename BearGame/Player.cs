using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearGame
{
    public class Player
    {

        public const int NUMBER_OF_CHARACTERS = 4;
        public const int NUMBER_OF_MOVEMENT_SQUARES = 40;

        public Color PlayerColor { get; set; }
        public TextBox[] PlayerSquares { get; set; }
        public TextBox[] PlayerCharacterSquares { get; set; }
        public TextBox[] PlayerFinalSauares { get; set; }
        public TextBox PlayerStartingSquare { get; set; }
        public TextBox PlayerLastMovementSquare { get; set; }
        public TextBox[] PlayerMovementSquares { get; set; }
        public int PlayerIndex { get; set; }
        public Character[] PlayerCharacters { get; set; }



        public Player(int playerIndex, Color playerColor, TextBox[] playerSquares)
        {
            if (playerSquares.Length != 2 * NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES)
            {
                throw new ArgumentException("Invalid number of squares for player");
            }

            if (playerIndex < 0 || playerIndex > 3)
            {
                throw new ArgumentException("Invalid player index");
            }

            PlayerIndex = playerIndex;
            PlayerColor = playerColor;
            PlayerSquares = playerSquares;
            PlayerCharacterSquares = new TextBox[NUMBER_OF_CHARACTERS];
            PlayerFinalSauares = new TextBox[NUMBER_OF_CHARACTERS];

            for (int i = 0; i < NUMBER_OF_CHARACTERS; i++)
            {
                PlayerCharacterSquares[i] = playerSquares[i];
                PlayerFinalSauares[i] = playerSquares[NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES + i];
            }

            PlayerStartingSquare = playerSquares[NUMBER_OF_CHARACTERS];
            PlayerLastMovementSquare = playerSquares[NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES - 1];

            PlayerMovementSquares = new TextBox[NUMBER_OF_MOVEMENT_SQUARES];

            for (int i = NUMBER_OF_CHARACTERS; i < NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES; i++)
            {
                PlayerMovementSquares[i - NUMBER_OF_CHARACTERS] = playerSquares[i];
            }

            PlayerCharacters = new Character[NUMBER_OF_CHARACTERS];

            for (int i = 0; i < NUMBER_OF_CHARACTERS; i++)
            {
                PlayerCharacters[i] = new Character(i, PlayerCharacterSquares[i], playerColor);
            }
        }

        public List<Character> ActiveCharacters = new List<Character>();



        public void SetACharacterActive()
        {
            if (ActiveCharacters.Count == NUMBER_OF_CHARACTERS)
            {
                throw new ArgumentException("All characters are already active");
            }

            if (PlayerStartingSquare.BackColor == PlayerColor)
            {
                throw new ArgumentException("Starting square is already occupied");
            }

            foreach (Character character in PlayerCharacters)
            {
                if (character.IsInStartingSquare)
                {
                    character.IsInStartingSquare = false;
                    ActiveCharacters.Add(character);
                    character.MoveCharacter(PlayerStartingSquare, NUMBER_OF_CHARACTERS);
                    return;
                }
            }

            throw new ArgumentException("There are no characters in starting squares.");
        }

        public void MoveCahracter(int numOfSquaresToMove, Character character)
        {
            if (character.IsInStartingSquare || character.IsInFinalSquare || ActiveCharacters.Contains(character) == false)
            {
                throw new ArgumentException("Invalid character location");
            }

            int indexOfSqureToMove = character.LocationIndex + numOfSquaresToMove;


            if (character.LocationIndex + numOfSquaresToMove > NUMBER_OF_MOVEMENT_SQUARES + NUMBER_OF_MOVEMENT_SQUARES)
            {
                indexOfSqureToMove = MoveToFinalSquare(character, numOfSquaresToMove);
            }
            else if (PlayerSquares[indexOfSqureToMove].BackColor == PlayerColor)
            {
                throw new ArgumentException("Square is already occupied");
            }

            character.MoveCharacter(PlayerSquares[indexOfSqureToMove], indexOfSqureToMove);

        }

        public int MoveToFinalSquare(Character character, int numOfSquaresToMove)
        {
            int indexOfFinalSquare = character.LocationIndex + numOfSquaresToMove;

            if (character.LocationIndex + numOfSquaresToMove >= PlayerSquares.Length)
            {
                int squresToTheEnd = PlayerSquares.Length - character.LocationIndex - 1;
                int numOfSquaresBackwards = numOfSquaresToMove - squresToTheEnd;
                indexOfFinalSquare = PlayerSquares.Length - 1 - numOfSquaresBackwards;
            }

            if (PlayerSquares[indexOfFinalSquare].BackColor == PlayerColor)
            {
                throw new ArgumentException("Finishing square is already occupied.");
            }

                character.IsInFinalSquare = true;
                ActiveCharacters.Remove(character);
            return indexOfFinalSquare;
        }

        public void Reset()
        {
            foreach (Character character in PlayerCharacters)
            {
                character.Reset();
            }
            ActiveCharacters.Clear();
        }

    }

}