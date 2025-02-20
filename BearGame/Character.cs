using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearGame
{
    public class Character
    {

        public int LocationIndex { get; set; }
        public int StartingLocationIndex { get; set; }
        public TextBox LocationBox { get; set; }
        public Color Color { get; set; }
        public bool IsInFinalSquare { get; set; }
        public bool IsInStartingSquare { get; set; }
        public TextBox StartingSquare { get; set; }

        public Character(int locationIndex, TextBox locationBox, Color color)
        {
            if (locationIndex < 0 || locationIndex > 3)
            {
                throw new AggregateException($"Location index was incorrect: {locationBox}");
            }

            LocationIndex = locationIndex;
            LocationBox = locationBox;
            StartingSquare = locationBox;
            StartingLocationIndex = locationIndex;
            Color = color;
            IsInFinalSquare = false;
            IsInStartingSquare = true;
        }

        public void MoveCharacter(TextBox squareToMove, int indexToMove)
        {
            LocationBox.BackColor = SystemColors.Control;
            LocationBox = squareToMove;
            LocationBox.BackColor = Color;
            LocationIndex = indexToMove;
        }

        public void Reset()
        {
            MoveCharacter(StartingSquare, StartingLocationIndex);
            IsInStartingSquare = true;
            IsInFinalSquare = false;
        }
    }
}
