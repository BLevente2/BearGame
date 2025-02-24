namespace BeaverGame;

    public class MatchStatistics
    {

    public int TotalNumberOfRounds { get; set; }
    public List<int> PlayerFinishOrder { get; set; }
    public List<int> NumberOfRoundsNeededToFinish { get; set; }
    public List<KOStatistics> KOStatistics { get; set; }
    public int[] NumberOfTimesBeenKnockedOut { get; set; }
    public int[] NumberOfTimesKnockedOutAPlayer { get; set; }

    public MatchStatistics()
    {
        TotalNumberOfRounds = 0;
        PlayerFinishOrder = new List<int>();
        NumberOfRoundsNeededToFinish = new List<int>();
        KOStatistics = new List<KOStatistics>();
        NumberOfTimesBeenKnockedOut = new int[0];
        NumberOfTimesKnockedOutAPlayer = new int[0];
    }

    public MatchStatistics(int numOfPlayers)
    {
        TotalNumberOfRounds = 0;
        PlayerFinishOrder = new List<int>();
        NumberOfRoundsNeededToFinish = new List<int>();
        KOStatistics = new List<KOStatistics>();
        NumberOfTimesBeenKnockedOut = new int[numOfPlayers];
        NumberOfTimesKnockedOutAPlayer = new int[numOfPlayers];
    }

}