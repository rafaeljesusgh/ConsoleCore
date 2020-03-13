using Game.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameTop(new Player("Hadzel"), new Player2());
            game.StartGame();
        }
    }
}
