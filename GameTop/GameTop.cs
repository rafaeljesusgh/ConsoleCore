using System;
using Game.Interfaces;

namespace GameTop
{
    public class GameTop
    {
        private readonly IPlayer _player;
        private readonly IPlayer _player2;

        public GameTop(IPlayer player, IPlayer player2)
        {
            _player = player;
            _player2 = player2;
        }

        public void StartGame()
        {
            Console.Write(_player.Punch());
            Console.Write(_player.PowerUp());

            Console.Write(_player2.Punch());
            Console.Write(_player2.PowerUp());
        }
    }
}