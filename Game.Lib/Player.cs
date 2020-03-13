using Game.Interfaces;

namespace Game.Lib
{
    public class Player : IPlayer
    {
        public string Name { get; set; }

        public Player(string name) => Name = name;

        public string PowerUp()
        {
            return $"{Name} used PowerUp. \n";
        }

        public string Punch()
        {
            return $"{Name} used Punch. \n";
        }

        public string Run()
        {
            return $"{Name} used Run. \n";
        }
    }
}