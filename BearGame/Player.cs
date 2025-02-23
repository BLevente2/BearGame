namespace BearGame;

public class Player
{

    public const int NUMBER_OF_CHARACTERS = 4;
    public const int NUMBER_OF_MOVEMENT_SQUARES = 40;

    #region Properties&Constructors

    public int PlayerIndex { get; set; }
    public Strategy PlayerStrategy { get; private set; }
    public bool AllCahractersInFinalSquare { get; private set; }
    public Color PlayerColor { get; private set; }
    public TextBox[] PlayerSquares { get; private set; }
    public TextBox PlayerStartingSquare { get; private set; }
    public Character[] PlayerCharacters { get; private set; }
    public int NumberOfCharactersInFinalSquare { get; private set; }
    public List<Character> ActiveCharacters { get; private set; }
    public int NumberOfTimesBeenKnockedOut { get; set; }
    public int NumberOfTimesKnockedOutAPlayer { get; set; }


    public Player(Color playerColor, TextBox[] playerSquares, Strategy playerStrategy, int playerIndex)
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
        NumberOfTimesBeenKnockedOut = 0;
        NumberOfTimesKnockedOutAPlayer = 0;
        PlayerColor = playerColor;
        PlayerStrategy = playerStrategy;
        NumberOfCharactersInFinalSquare = 0;
        PlayerSquares = playerSquares;
        AllCahractersInFinalSquare = false;
        PlayerStartingSquare = playerSquares[NUMBER_OF_CHARACTERS];

        PlayerCharacters = new Character[NUMBER_OF_CHARACTERS];
        ActiveCharacters = new List<Character>();

        for (int i = 0; i < NUMBER_OF_CHARACTERS; i++)
        {
            PlayerCharacters[i] = new Character(i, PlayerSquares[i], playerColor);
        }

        PlayerIndex = playerIndex;
    }

    #endregion

    public void KnockOutCharacterOfThisPlayer(Character characterToBeKnockedOut)
    {
        if (characterToBeKnockedOut.IsInFinalSquare || characterToBeKnockedOut.IsInStartingSquare || ActiveCharacters.Contains(characterToBeKnockedOut) == false)
        {
            throw new ArgumentException("Character can not be knocked out.");
        }

        characterToBeKnockedOut.Reset();
        ActiveCharacters.Remove(characterToBeKnockedOut);
    }

    public int IndexOfMoveEndingSquare(Character character, int roll)
    {
        int indexOfEndSquare = character.LocationIndex + roll;

        if (indexOfEndSquare < NUMBER_OF_CHARACTERS || roll < 1 || roll > 6)
        {
            throw new ArgumentException("Invalid move");
        }

        if (indexOfEndSquare >= 2 * NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES)
        {
            indexOfEndSquare = 2 * (2 * NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES - 1) - indexOfEndSquare;
        }

        return indexOfEndSquare;
    }

    public List<Character> GetCharactersThatCanMove(int roll)
    {
        List<Character> charactersThatCanMove = new List<Character>();
        foreach (Character character in ActiveCharacters)
        {
            int indexOfEndSquare = IndexOfMoveEndingSquare(character, roll);
            if (PlayerSquares[indexOfEndSquare].BackColor != PlayerColor)
            {
                charactersThatCanMove.Add(character);
            }
        }
        return charactersThatCanMove;
    }

    public Character? FindCahracterByLocation(TextBox location)
    {
        if (location.BackColor == PlayerColor)
        {
            foreach (Character character in ActiveCharacters)
            {
                if (character.LocationBox == location)
                {
                    return character;
                }
            }
        }
        return null;
    }

    public bool IsThereCharacterInStartingSquare()
    {
        if (AllCahractersInFinalSquare || ActiveCharacters.Count == NUMBER_OF_CHARACTERS)
        {
            return false;
        }

        foreach (Character character in PlayerCharacters)
        {
            if (character.IsInStartingSquare)
            {
                return true;
            }
        }
        return false;
    }

    public void SetACharacterActive()
    {
        if (IsThereCharacterInStartingSquare() == false)
        {
            throw new ArgumentException("No character in starting square");
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
    }

    public void MoveCharacter(int numOfSquaresToMove, Character character)
    {
        if (character.IsInStartingSquare || character.IsInFinalSquare || ActiveCharacters.Contains(character) == false)
        {
            throw new ArgumentException($"Character can not be moved: StartingSquare: {character.IsInStartingSquare}, FinalSquare: {character.IsInFinalSquare}, ActiveCharacter: {ActiveCharacters.Contains(character)}, Count: {ActiveCharacters.Count}");
        }

        int indexOfSqureToMove = IndexOfMoveEndingSquare(character, numOfSquaresToMove);

        if (PlayerSquares[indexOfSqureToMove].BackColor == PlayerColor)
        {
            return;
        }

        if (indexOfSqureToMove >= NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES)
        {
            MoveToFinalSquare(indexOfSqureToMove, character);
            return;
        }

        character.MoveCharacter(PlayerSquares[indexOfSqureToMove], indexOfSqureToMove);

    }

    private void MoveToFinalSquare(int indexOfSquareToMove, Character character)
    {
        character.MoveCharacter(PlayerSquares[indexOfSquareToMove], indexOfSquareToMove);
        character.IsInFinalSquare = true;
        ActiveCharacters.Remove(character);
        NumberOfCharactersInFinalSquare++;

        AllCahractersInFinalSquare = NumberOfCharactersInFinalSquare == NUMBER_OF_CHARACTERS;
    }

    public void Reset()
    {
        foreach (Character character in PlayerCharacters)
        {
            character.Reset();
        }

        NumberOfCharactersInFinalSquare = 0;
        ActiveCharacters.Clear();
        AllCahractersInFinalSquare = false;
        NumberOfTimesBeenKnockedOut = 0;
        NumberOfTimesKnockedOutAPlayer = 0;
    }

}