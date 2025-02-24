namespace BeaverGame;

public class Strategy
{

    public bool GoWithRandom { get; set; }
    public bool GoWithClosest { get; set; }
    public bool GoWithFurthest { get; set; }
    public bool PrioritizeKO { get; set; }
    public bool PrioritizeNewCharacter { get; set; }
    public bool PrioritizeOutOfStart { get; set; }

    public Strategy(bool goWithRandom, bool goWithClosest, bool goWithFurthest, bool prioritizeKO, bool prioritizeNewCharacter, bool prioritizeOutOfStart)
    {
        GoWithRandom = goWithRandom;
        GoWithClosest = goWithClosest;
        GoWithFurthest = goWithFurthest;
        PrioritizeKO = prioritizeKO;
        PrioritizeNewCharacter = prioritizeNewCharacter;
        PrioritizeOutOfStart = prioritizeOutOfStart;
    }

    public Strategy()
    {

    }
}