using Game.Interfaces;

namespace Game.Lib
{
    public class Player2 : IPlayer
    {
        public string PowerUp()
        {
            return "Player2 used PowerUp.\n";
        }

        public string Punch()
        {
            return "Player2 used Punch.\n";
        }

        public string Run()
        {
            return "Player2 used Run.\n";
        }
    }
}