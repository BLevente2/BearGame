namespace BeaverGame;

public class Character
{
    #region Properties&Constructors

    private readonly int _startingLocationIndex;

    public Color CharacterColor { get; private set; }
    public int LocationIndex { get; private set; }
    public TextBox LocationBox { get; private set; }
    public bool IsInFinalSquare { get; set; }
    public bool IsInStartingSquare { get; set; }
    public TextBox StartingSquare { get;private set; }
    public Color SavedForeColor { get; private set; }

    public Character(int locationIndex, TextBox locationBox, Color color)
    {
        if (locationIndex < 0 || locationIndex > 3)
        {
            throw new AggregateException($"Location index was incorrect: {locationBox}");
        }

        LocationIndex = locationIndex;
        LocationBox = locationBox;
        StartingSquare = locationBox;
        _startingLocationIndex = locationIndex;
        CharacterColor = color;
        IsInFinalSquare = false;
        IsInStartingSquare = true;
        SavedForeColor = locationBox.BackColor;
    }

    #endregion

    public void MoveCharacter(TextBox squareToMove, int indexToMove)
    {
        LocationBox.ForeColor = SavedForeColor;
        LocationBox.BackColor = SystemColors.Control;
        LocationBox = squareToMove;
        LocationBox.BackColor = CharacterColor;
        SavedForeColor = LocationBox.ForeColor;
        LocationBox.ForeColor = SystemColors.WindowText;
        LocationIndex = indexToMove;
    }

    public void Reset()
    {
        MoveCharacter(StartingSquare, _startingLocationIndex);
        IsInStartingSquare = true;
        IsInFinalSquare = false;
    }
}