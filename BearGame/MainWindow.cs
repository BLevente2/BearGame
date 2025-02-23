using MathNet.Numerics.Statistics;
using System.Windows.Forms;

namespace BearGame;

public partial class BearGameProject : Form
{

    private ScottPlot.WinForms.FormsPlot _koDiagram;
    private ScottPlot.WinForms.FormsPlot _beenKOdDiagram;
    private ScottPlot.WinForms.FormsPlot _winsDiagram;

    #region Constructor

    public BearGameProject()
    {
        InitializeComponent();

        GameViewButton.FlatAppearance.BorderSize = 0;
        GameViewButton.MouseEnter += Buttons_MouseEnter;
        GameViewButton.MouseLeave += Buttons_MouseLeave;
        StatisticsViewButton.FlatAppearance.BorderSize = 0;
        StatisticsViewButton.MouseEnter += Buttons_MouseEnter;
        StatisticsViewButton.MouseLeave += Buttons_MouseLeave;
        StartGameButton.FlatAppearance.BorderSize = 0;
        StartGameButton.MouseEnter += Buttons_MouseEnter;
        StartGameButton.MouseLeave += Buttons_MouseLeave;
        SettingPlayer1.FlatAppearance.BorderSize = 0;
        SettingPlayer1.MouseEnter += Buttons_MouseEnter;
        SettingPlayer1.MouseLeave += Buttons_MouseLeave;
        SettingPlayer2.FlatAppearance.BorderSize = 0;
        SettingPlayer2.MouseEnter += Buttons_MouseEnter;
        SettingPlayer2.MouseLeave += Buttons_MouseLeave;
        SettingPlayer3.FlatAppearance.BorderSize = 0;
        SettingPlayer3.MouseEnter += Buttons_MouseEnter;
        SettingPlayer3.MouseLeave += Buttons_MouseLeave;
        SettingPlayer4.FlatAppearance.BorderSize = 0;
        SettingPlayer4.MouseEnter += Buttons_MouseEnter;
        SettingPlayer4.MouseLeave += Buttons_MouseLeave;
        SaveStatisticsButton.FlatAppearance.BorderSize = 0;
        SaveStatisticsButton.MouseEnter += Buttons_MouseEnter;
        SaveStatisticsButton.MouseLeave += Buttons_MouseLeave;
        LoadStatisticsButton.FlatAppearance.BorderSize = 0;
        LoadStatisticsButton.MouseEnter += Buttons_MouseEnter;
        LoadStatisticsButton.MouseLeave += Buttons_MouseLeave;

        ViewControlPanel.SendToBack();


        _player1Strategy = new Strategy(true, false, false, true, true, true);
        _player2Strategy = new Strategy(true, false, false, true, true, true);
        _player3Strategy = new Strategy(true, false, false, true, true, true);
        _player4Strategy = new Strategy(true, false, false, true, true, true);

        _koDiagram = GetNewBarDiagram();
        KOsDiagram.Controls.Add(_koDiagram);
        _beenKOdDiagram = GetNewBarDiagram();
        KOdDiagram.Controls.Add(_beenKOdDiagram);
        _winsDiagram = GetNewPieDiagram();
        VictoryDiagramPanel.Controls.Add(_winsDiagram);


        _dataCollection = null;

    }

    #endregion

    #region GameView

    private void GameViewButton_Click(object sender, EventArgs e)
    {
        StatisticsView.Visible = false;
        StatisticsView.Enabled = false;
        GameView.Visible = true;
        GameView.Enabled = true;
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
                    players[i] = new Player(Color.Yellow, GetPlayer1Squares(), _player1Strategy, i);
                    break;
                case 1:
                    players[i] = new Player(Color.Red, GetPlayer2Squares(), _player2Strategy, i);
                    break;
                case 2:
                    players[i] = new Player(Color.Blue, GetPlayer3Squares(), _player3Strategy, i);
                    break;
                case 3:
                    players[i] = new Player(Color.Green, GetPlayer4Squares(), _player4Strategy, i);
                    break;
            }
        }
        return players;
    }

    private void SetVisibilityWhileSimulating(bool visibility)
    {
        StartGameButton.Enabled = visibility;
        NumberOfPlayersSelector.Enabled = visibility;
        NumberOfMatchesSelector.Enabled = visibility;
        SettingPlayer1.Enabled = visibility;
        SettingPlayer2.Enabled = visibility;
        SettingPlayer3.Enabled = visibility;
        SettingPlayer4.Enabled = visibility;
        SaveStatisticsButton.Enabled = visibility;
        SaveStatisticsButton.Visible = visibility;
        LoadStatisticsButton.Enabled = visibility;
        LoadStatisticsButton.Visible = visibility;
        GeneralStatistics.Visible = visibility;

        StartGameButton.UseWaitCursor = !visibility;
        ProgressPanel.Visible = !visibility;
    }

    private async void StartGAmeButton_Click(object sender, EventArgs e)
    {
        try
        {
            GameStatistics gameStatistics = new GameStatistics((int)NumberOfMatchesSelector.Value, (int)NumberOfPlayersSelector.Value);
            _dataCollection = new DataCollection(gameStatistics);
            Player[] players = GetPlayers((int)NumberOfPlayersSelector.Value);
            Color[] playerColors = new Color[players.Length];
            string[] playerLabels = new string[players.Length];

            foreach (Player player in players)
            {
                gameStatistics.PlayerStrategies.Add(player.PlayerStrategy);
                playerColors[player.PlayerIndex] = player.PlayerColor;
                playerLabels[player.PlayerIndex] = $"Player{player.PlayerIndex + 1}";
            }

            KOsDiagram.Controls.Remove(_koDiagram);
            _koDiagram = GetNewBarDiagram(players.Length, playerLabels, playerColors, out List<ScottPlot.Bar> outBars);
            _koDiagram.Plot.Title("KOs per Player");
            KOsDiagram.Controls.Add(_koDiagram);

            KOdDiagram.Controls.Remove(_beenKOdDiagram);
            _beenKOdDiagram = GetNewBarDiagram(players.Length, playerLabels, playerColors, out List<ScottPlot.Bar> outBars2);
            _beenKOdDiagram.Plot.Title("KOd per Player");
            KOdDiagram.Controls.Add(_beenKOdDiagram);

            VictoryDiagramPanel.Controls.Remove(_winsDiagram);
            _winsDiagram = GetNewPieDiagram(players.Length, playerLabels, playerColors, out List<ScottPlot.PieSlice> outPie);
            _winsDiagram.Plot.Title("NumberOfVictories");
            VictoryDiagramPanel.Controls.Add( _winsDiagram);

            Game game = new Game(
                players, 
                UseSlowModeBox, 
                GameSpeedBar, 
                SimulationProgress, 
                ProgressLabel, 
                gameStatistics.
                MatchStatistics, 
                MatchesPlayedCounter, 
                RoundsPlayedCounter, 
                PlayerFinishedCounter, 
                outBars, 
                _koDiagram,
                outBars2, 
                _beenKOdDiagram, 
                outPie, 
                _winsDiagram);
            
            string tempText = StartGameButton.Text;
            StartGameButton.Text = "GameIsRunning...";
            SimulationProgress.Value = 0;
            SetVisibilityWhileSimulating(false);

            await game.StartGame((int)NumberOfMatchesSelector.Value);

            CalculateGeneralStatistics();
            SetVisibilityWhileSimulating(true);
            StartGameButton.Text = tempText;
            MatchesPlayedCounter.Text = "0";
            RoundsPlayedCounter.Text = "0";
            PlayerFinishedCounter.Text = "0";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void NumberOfPlayersSelector_ValueChanged(object sender, EventArgs e)
    {
        if (NumberOfPlayersSelector.Value <= 2)
        {
            SettingPlayer3.Visible = false;
            SettingPlayer3.Enabled = false;
            SettingPlayer4.Visible = false;
            SettingPlayer4.Enabled = false;
        }
        else if (NumberOfPlayersSelector.Value == 3)
        {

            SettingPlayer3.Visible = true;
            SettingPlayer3.Enabled = true;
            SettingPlayer4.Visible = false;
            SettingPlayer4.Enabled = false;
        }
        else
        {
            SettingPlayer3.Visible = true;
            SettingPlayer3.Enabled = true;
            SettingPlayer4.Visible = true;
            SettingPlayer4.Enabled = true;
        }
    }

    private Strategy _player1Strategy;
    private Strategy _player2Strategy;
    private Strategy _player3Strategy;
    private Strategy _player4Strategy;

    private void SettingPlayer1_Click(object sender, EventArgs e)
    {
        _player1Strategy = GetPlayerStrategy(_player1Strategy, SettingPlayer1.ForeColor);
    }

    private void SettingPlayer2_Click(object sender, EventArgs e)
    {
        _player2Strategy = GetPlayerStrategy(_player2Strategy, SettingPlayer2.ForeColor);
    }

    private void SettingPlayer3_Click(object sender, EventArgs e)
    {
        _player3Strategy = GetPlayerStrategy(_player3Strategy, SettingPlayer3.ForeColor);
    }

    private void SettingPlayer4_Click(object sender, EventArgs e)
    {
        _player4Strategy = GetPlayerStrategy(_player4Strategy, SettingPlayer4.ForeColor);
    }

    private Strategy GetPlayerStrategy(Strategy currentStrategy, Color playerColor)
    {
        try
        {
            PlayerSettings playerSettings = new PlayerSettings(currentStrategy, playerColor);
            var result = playerSettings.ShowDialog();
            if (result == DialogResult.OK)
            {
                return playerSettings.PlayerStrategy;
            }
            playerSettings.Dispose();
            return currentStrategy;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return currentStrategy;
        }

    }

    private void UseSlowModeBox_CheckedChanged(object sender, EventArgs e)
    {
        GameSpeedBar.Enabled = UseSlowModeBox.Checked;
    }

    #endregion

    #region Statistics

    private DataCollection? _dataCollection;

    private void StatisticsViewButton_Click(object sender, EventArgs e)
    {
        GameView.Visible = false;
        GameView.Enabled = false;
        StatisticsView.Visible = true;
        StatisticsView.Enabled = true;
    }

    private void SaveStatisticsButton_Click(object sender, EventArgs e)
    {
        if (_dataCollection != null)
        {
            try
            {
                var saveFile = new SaveFileDialog();
                saveFile.Filter = "JSON Files (*.json)|*.json";
                saveFile.Title = "Save statistics to JSON File";
                saveFile.DefaultExt = "json";
                saveFile.FileName = "game_statistics.json";
                var result = saveFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _dataCollection.JsonFilePath = saveFile.FileName;
                    _dataCollection.SaveGameStatistics();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void LoadStatisticsButton_Click(object sender, EventArgs e)
    {
        try
        {
           if (_dataCollection == null)
            {
                _dataCollection = new DataCollection();
            }

           var openFile = new OpenFileDialog();
            openFile.Filter = "JSON Files (*.json)|*.json";
            openFile.Title = "Open JSON FileCreatedByThisApp";
            var result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                _dataCollection.JsonFilePath = openFile.FileName;
                _dataCollection.LoadGameStatistics();
                SaveStatisticsButton.Enabled = true;
                SaveStatisticsButton.Visible = true;
                GeneralStatistics.Visible = true;
                LoadDataToDiagrams();
                CalculateGeneralStatistics();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public static ScottPlot.WinForms.FormsPlot GetNewBarDiagram(int numOfBars, string[] labels, Color[] colors, out List<ScottPlot.Bar> outBars)
    {
        if (labels.Length != numOfBars || colors.Length != numOfBars)
        {
            throw new ArgumentException("Invalid number of labels or colors");
        }

        outBars = new List<ScottPlot.Bar>();
        double[] values = new double[numOfBars];
        ScottPlot.WinForms.FormsPlot plot = new ScottPlot.WinForms.FormsPlot();
        plot.Plot.DataBackground.Color = ScottPlot.Colors.Transparent;
        plot.Dock = DockStyle.Fill;
        var bars = plot.Plot.Add.Bars(values);

        if (bars != null)
        {
            for (int i = 0; i < numOfBars; i++)
            {
                bars.Bars[i].Label = labels[i];
                bars.Bars[i].CenterLabel = true;
                bars.Bars[i].FillColor = ScottPlot.Color.FromARGB(colors[i].ToArgb());
                outBars = bars.Bars;
            }
        }

        return plot;
    }

    public static ScottPlot.WinForms.FormsPlot GetNewBarDiagram() => GetNewBarDiagram(4, new string[] { "Yellow", "Red", "Blue", "Green" }, new Color[] { Color.Yellow, Color.Red, Color.Blue, Color.Green }, out List<ScottPlot.Bar> outBars);

    public static ScottPlot.WinForms.FormsPlot GetNewPieDiagram(int numOfBars, string[] labels, Color[] colors, out List<ScottPlot.PieSlice> outPie)
    {
        if (labels.Length != numOfBars || colors.Length != numOfBars)
        {
            throw new ArgumentException("Invalid number of labels or colors");
        }

        outPie = new List<ScottPlot.PieSlice>();
        double[] values = new double[numOfBars];
        ScottPlot.WinForms.FormsPlot plot = new ScottPlot.WinForms.FormsPlot();
        plot.Plot.DataBackground.Color = ScottPlot.Colors.Transparent;
        plot.Dock = DockStyle.Fill;
        var pies = plot.Plot.Add.Pie(values);

        if (pies != null)
        {
            for (int i = 0; i < numOfBars; i++)
            {
                pies.Slices[i].Label = labels[i];
                pies.Slices[i].LabelAlignment = ScottPlot.Alignment.MiddleCenter;
                pies.Slices[i].LabelFontColor = ScottPlot.Color.FromARGB(SystemColors.WindowText.ToArgb());
                pies.Slices[i].FillColor = ScottPlot.Color.FromARGB(colors[i].ToArgb());
                outPie = (List<ScottPlot.PieSlice>)pies.Slices;
            }
        }

        return plot;
    }

    public static ScottPlot.WinForms.FormsPlot GetNewPieDiagram() => GetNewPieDiagram(4, new string[] { "Yellow", "Red", "Blue", "Green" }, new Color[] { Color.Yellow, Color.Red, Color.Blue, Color.Green }, out List<ScottPlot.PieSlice> outPie);

    private void LoadDataToDiagrams()
    {
        if (_dataCollection != null && _dataCollection.GameStatistics != null)
        {
            GameStatistics stat = _dataCollection.GameStatistics;

            NumberOfPlayersSelector.Value = stat.NumberOfPlayers;
            NumberOfMatchesSelector.Value = stat.NumberOfMatches;

            _player1Strategy = stat.PlayerStrategies[0];
            _player2Strategy = stat.PlayerStrategies[1];
            if (stat.NumberOfPlayers >= 3)
            {
                _player3Strategy = stat.PlayerStrategies[2];
            }
            if (stat.NumberOfPlayers == 4)
            {
                _player4Strategy = stat.PlayerStrategies[3];
            }

            KOdDiagram.Controls.Remove(_beenKOdDiagram);
            KOsDiagram.Controls.Remove(_koDiagram);
            VictoryDiagramPanel.Controls.Remove(_winsDiagram);
            Player[] players = GetPlayers(stat.NumberOfPlayers);
            Color[] playerColors = new Color[players.Length];
            string[] koLabels = new string[players.Length];
            string[] kodLabels = new string[players.Length];
            int[] values1 = _dataCollection.GetTotalKnockOuts();
            int[] values2 = _dataCollection.TotalNumberOfTimesBeenKOd();
            int[] victories = _dataCollection.GetNumberOfCictories();
            string[] victoriesLbels = new string[victories.Length];

            foreach (Player player in players)
            {
                playerColors[player.PlayerIndex] = player.PlayerColor;
                koLabels[player.PlayerIndex] = values1[player.PlayerIndex].ToString();
                kodLabels[player.PlayerIndex] = values2[player.PlayerIndex].ToString();
                victoriesLbels[player.PlayerIndex] = victories[player.PlayerIndex].ToString();
            }

            _koDiagram = GetNewBarDiagram(stat.NumberOfPlayers, koLabels, playerColors, out List<ScottPlot.Bar> outBar1);
            _beenKOdDiagram = GetNewBarDiagram(stat.NumberOfPlayers, kodLabels, playerColors, out List<ScottPlot.Bar> outBar2);
            _winsDiagram = GetNewPieDiagram(stat.NumberOfPlayers, victoriesLbels, playerColors, out List<ScottPlot.PieSlice> outPie);

            for (int i = 0; i < stat.NumberOfPlayers; i++)
            {
                outBar1[i].Value = values1[i];
                outBar2[i].Value = values2[i];
                outPie[i].Value = victories[i];
            }

            KOsDiagram.Controls.Add(_koDiagram);
            KOdDiagram.Controls.Add(_beenKOdDiagram);
            VictoryDiagramPanel.Controls.Add(_winsDiagram);
            _koDiagram.Plot.Axes.AutoScale();
            _koDiagram.Plot.Axes.AutoScale();
            _winsDiagram.Plot.Axes.AutoScale();
            _koDiagram.Refresh();
            _beenKOdDiagram.Refresh();
            _winsDiagram.Refresh();

        }
    }

    public void CalculateGeneralStatistics()
    {
        if (_dataCollection != null && _dataCollection.GameStatistics != null)
        {
            double[] numOfRounds = _dataCollection.GetNumOfRounds();
            double avgNumOfRounds = numOfRounds.Average();
            AvarageNumOfRoundsBox.Text = Math.Round(avgNumOfRounds, 4).ToString();
            double varianceOfRounds = MathNet.Numerics.Statistics.Statistics.Variance(numOfRounds);
            VarianceOfRoundsBox.Text += Math.Round(varianceOfRounds, 4).ToString();
            double standardDeviationOfRounds = MathNet.Numerics.Statistics.Statistics.StandardDeviation(numOfRounds);
            StandardDeviationBox.Text = Math.Round(standardDeviationOfRounds, 4).ToString();
            
        }
    }

    #endregion
}