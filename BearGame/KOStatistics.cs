namespace BearGame;

public class KOStatistics
{

    public int PlayerWhoMoved { get; set; }
    public int KnockedOutPlayer { get; set; }
    public int Round { get; set; }

    public KOStatistics()
    {
        PlayerWhoMoved = 0;
        KnockedOutPlayer = 0;
        Round = 0;
    }

    public KOStatistics(int playerWhoMoved, int knockedOutPlayer, int round)
    {
        PlayerWhoMoved = playerWhoMoved;
        KnockedOutPlayer = knockedOutPlayer;
        Round = round;
    }

}