namespace BearGame
{
    public struct Strategy
    {

        public bool GoWithRandom {  get; }
        public bool GoWithClosest { get; }
        public bool GoWithFurthest { get; }
        public bool PrioritizeKO { get; }
        public bool PrioritizeNewCharacter { get; }
        public bool PrioritizeOutOfStart { get; }

        public Strategy(bool goWithRandom, bool goWithClosest, bool goWithFurthest, bool prioritizeKO, bool prioritizeNewCharacter, bool prioritizeOutOfStart)
        {
            GoWithRandom = goWithRandom;
            GoWithClosest = goWithClosest;
            GoWithFurthest = goWithFurthest;
            PrioritizeKO = prioritizeKO;
            PrioritizeNewCharacter = prioritizeNewCharacter;
            PrioritizeOutOfStart = prioritizeOutOfStart;
        }

    }
}
