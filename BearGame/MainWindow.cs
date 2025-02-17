using System.Runtime.CompilerServices;

namespace BearGame
{
    public partial class BearGameProject : Form
    {
        public BearGameProject()
        {
            InitializeComponent();

            GameViewButton.FlatAppearance.BorderSize = 0;
            GameViewButton.MouseEnter += Buttons_MouseEnter;
            GameViewButton.MouseLeave += Buttons_MouseLeave;
            StatisticsViewButton.FlatAppearance.BorderSize = 0;
            StatisticsViewButton.MouseEnter += Buttons_MouseEnter;
            StatisticsViewButton.MouseLeave += Buttons_MouseLeave;
            StartGAmeButton.FlatAppearance.BorderSize = 0;
            StartGAmeButton.MouseEnter += Buttons_MouseEnter;
            StartGAmeButton.MouseLeave += Buttons_MouseLeave;

            GameView.Visible = false;

        }

        private void GameViewButton_Click(object sender, EventArgs e)
        {
            GameView.Visible = true;
        }

        private void Buttons_MouseEnter(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                Button button = (Button)sender;
                button.FlatAppearance.BorderSize = 1;
                button.BackColor = SystemColors.Highlight;
            }
        }

        private void Buttons_MouseLeave(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                Button button = (Button)sender;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = SystemColors.Control;
            }
        }


        #region PlayerSquares

        private TextBox[]? _player1Squares = null;
        private TextBox[]? _player2Squares = null;
        private TextBox[]? _player3Squares = null;
        private TextBox[]? _player4Squares = null;

        public TextBox[] GetPlayer1Squares()
        {
            if (_player1Squares != null)
            {
                return _player1Squares;
            }

            List<TextBox> boxes = new List<TextBox>();
            boxes.Add(YC1);
            boxes.Add(YC2);
            boxes.Add(YC3);
            boxes.Add(YC4);
            boxes.Add(S1);
            boxes.Add(S2);
            boxes.Add(S3);
            boxes.Add(S4);
            boxes.Add(S5);
            boxes.Add(S6);
            boxes.Add(S7);
            boxes.Add(S8);
            boxes.Add(S9);
            boxes.Add(S10);
            boxes.Add(S11);
            boxes.Add(S12);
            boxes.Add(S13);
            boxes.Add(S14);
            boxes.Add(S15);
            boxes.Add(S16);
            boxes.Add(S17);
            boxes.Add(S18);
            boxes.Add(S19);
            boxes.Add(S20);
            boxes.Add(S21);
            boxes.Add(S22);
            boxes.Add(S23);
            boxes.Add(S24);
            boxes.Add(S25);
            boxes.Add(S26);
            boxes.Add(S27);
            boxes.Add(S28);
            boxes.Add(S29);
            boxes.Add(S30);
            boxes.Add(S31);
            boxes.Add(S32);
            boxes.Add(S33);
            boxes.Add(S34);
            boxes.Add(S35);
            boxes.Add(S36);
            boxes.Add(S37);
            boxes.Add(S38);
            boxes.Add(S39);
            boxes.Add(S40);
            boxes.Add(YF1);
            boxes.Add(YF2);
            boxes.Add(YF3);
            boxes.Add(YF4);

            _player1Squares = boxes.ToArray();
            return _player1Squares;
        }

        public TextBox[] GetPlayer2Squares()
        {
            if (_player2Squares != null)
            {
                return _player2Squares;
            }
            List<TextBox> boxes = new List<TextBox>();

            boxes.Add(RC1);
            boxes.Add(RC2);
            boxes.Add(RC3);
            boxes.Add(RC4);
            boxes.Add(S11);
            boxes.Add(S12);
            boxes.Add(S13);
            boxes.Add(S14);
            boxes.Add(S15);
            boxes.Add(S16);
            boxes.Add(S17);
            boxes.Add(S18);
            boxes.Add(S19);
            boxes.Add(S20);
            boxes.Add(S21);
            boxes.Add(S22);
            boxes.Add(S23);
            boxes.Add(S24);
            boxes.Add(S25);
            boxes.Add(S26);
            boxes.Add(S27);
            boxes.Add(S28);
            boxes.Add(S29);
            boxes.Add(S30);
            boxes.Add(S31);
            boxes.Add(S32);
            boxes.Add(S33);
            boxes.Add(S34);
            boxes.Add(S35);
            boxes.Add(S36);
            boxes.Add(S37);
            boxes.Add(S38);
            boxes.Add(S39);
            boxes.Add(S40);
            boxes.Add(S1);
            boxes.Add(S2);
            boxes.Add(S3);
            boxes.Add(S4);
            boxes.Add(S5);
            boxes.Add(S6);
            boxes.Add(S7);
            boxes.Add(S8);
            boxes.Add(S9);
            boxes.Add(S10);
            boxes.Add(RF1);
            boxes.Add(RF2);
            boxes.Add(RF3);
            boxes.Add(RF4);

            _player2Squares = boxes.ToArray();
            return _player2Squares;
        }

        public TextBox[] GetPlayer3Squares()
        {
            if (_player3Squares != null)
            {
                return _player3Squares;
            }
            List<TextBox> boxes = new List<TextBox>();
            boxes.Add(BC1);
            boxes.Add(BC2);
            boxes.Add(BC3);
            boxes.Add(BC4);
            boxes.Add(S21);
            boxes.Add(S22);
            boxes.Add(S23);
            boxes.Add(S24);
            boxes.Add(S25);
            boxes.Add(S26);
            boxes.Add(S27);
            boxes.Add(S28);
            boxes.Add(S29);
            boxes.Add(S30);
            boxes.Add(S31);
            boxes.Add(S32);
            boxes.Add(S33);
            boxes.Add(S34);
            boxes.Add(S35);
            boxes.Add(S36);
            boxes.Add(S37);
            boxes.Add(S38);
            boxes.Add(S39);
            boxes.Add(S40);
            boxes.Add(S1);
            boxes.Add(S2);
            boxes.Add(S3);
            boxes.Add(S4);
            boxes.Add(S5);
            boxes.Add(S6);
            boxes.Add(S7);
            boxes.Add(S8);
            boxes.Add(S9);
            boxes.Add(S10);
            boxes.Add(S11);
            boxes.Add(S12);
            boxes.Add(S13);
            boxes.Add(S14);
            boxes.Add(S15);
            boxes.Add(S16);
            boxes.Add(S17);
            boxes.Add(S18);
            boxes.Add(S19);
            boxes.Add(S20);
            boxes.Add(BF1);
            boxes.Add(BF2);
            boxes.Add(BF3);
            boxes.Add(BF4);
            _player3Squares = boxes.ToArray();
            return _player3Squares;
        }

        public TextBox[] GetPlayer4Squares()
        {
            if (_player4Squares != null)
            {
                return _player4Squares;
            }
            List<TextBox> boxes = new List<TextBox>();
            boxes.Add(GC1);
            boxes.Add(GC2);
            boxes.Add(GC3);
            boxes.Add(GC4);
            boxes.Add(S31);
            boxes.Add(S32);
            boxes.Add(S33);
            boxes.Add(S34);
            boxes.Add(S35);
            boxes.Add(S36);
            boxes.Add(S37);
            boxes.Add(S38);
            boxes.Add(S39);
            boxes.Add(S40);
            boxes.Add(S1);
            boxes.Add(S2);
            boxes.Add(S3);
            boxes.Add(S4);
            boxes.Add(S5);
            boxes.Add(S6);
            boxes.Add(S7);
            boxes.Add(S8);
            boxes.Add(S9);
            boxes.Add(S10);
            boxes.Add(S11);
            boxes.Add(S12);
            boxes.Add(S13);
            boxes.Add(S14);
            boxes.Add(S15);
            boxes.Add(S16);
            boxes.Add(S17);
            boxes.Add(S18);
            boxes.Add(S19);
            boxes.Add(S20);
            boxes.Add(S21);
            boxes.Add(S22);
            boxes.Add(S23);
            boxes.Add(S24);
            boxes.Add(S25);
            boxes.Add(S26);
            boxes.Add(S27);
            boxes.Add(S28);
            boxes.Add(S29);
            boxes.Add(S30);
            boxes.Add(GF1);
            boxes.Add(GF2);
            boxes.Add(GF3);
            boxes.Add(GF4);
            _player4Squares = boxes.ToArray();
            return _player4Squares;
        }

        #endregion

        public Player[] GetPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                throw new ArgumentException("Invalid number of players");
            }

            Player[] players = new Player[numberOfPlayers];

            for (int i = 0; i < numberOfPlayers; i++)
            {
                switch (i)
                {
                    case 0:
                        players[i] = new Player(i, Color.Yellow, GetPlayer1Squares());
                        break;
                    case 1:
                        players[i] = new Player(i, Color.Red, GetPlayer2Squares());
                        break;
                    case 2:
                        players[i] = new Player(i, Color.Blue, GetPlayer3Squares());
                        break;
                    case 3:
                        players[i] = new Player(i, Color.Green, GetPlayer4Squares());
                        break;
                }
            }
            return players;
        }

        private void StartGAmeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Game game = new Game(GetPlayers((int)NumberOfPlayersSelector.Value));

                string tempText = StartGAmeButton.Text;
                StartGAmeButton.Text = "GameIsRunning...";
                StartGAmeButton.UseWaitCursor = true;
                StartGAmeButton.Enabled = false;

                game.StartGame((int)NumberOfMatchesSelector.Value);

                StartGAmeButton.Text = tempText;
                StartGAmeButton.UseWaitCursor = false;
                StartGAmeButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
