namespace Octavia
{
    public class Game
    {
        Difficulty difficulty;
        StyleBand styleBand;
        string bandName;

        public Game( Difficulty difficulty, StyleBand styleBand, string bandName )
        {
            this.difficulty = difficulty;
            this.styleBand = styleBand;
            this.bandName = bandName;
        }
    }
}