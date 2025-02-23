namespace BearGame;

    public class GameStatistics : IDisposable
{


    public List<Strategy> PlayerStrategies { get; set; }
    public int NumberOfMatches { get; set; }
    public int NumberOfPlayers { get; set; }
    public List<MatchStatistics> MatchStatistics { get; set; }


    public GameStatistics()
    {
        PlayerStrategies = new List<Strategy>();
        NumberOfMatches = 0;
        NumberOfPlayers = 0;
        MatchStatistics = new List<MatchStatistics>();
    }

    public GameStatistics(int numberOfMatches, int numberOfPlayers)
    {
        PlayerStrategies = new List<Strategy>();
        NumberOfMatches = numberOfMatches;
        NumberOfPlayers = numberOfPlayers;
        MatchStatistics = new List<MatchStatistics>();
    }

    public void Dispose()
    {
        PlayerStrategies.Clear();
        MatchStatistics.Clear();
    }
}