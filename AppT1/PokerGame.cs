using System;
using AppT1.Handler;
using System.Collections.Generic;
using System.Text;

namespace AppT1
{
    public class PokerGame
    {
        public static void Start(List<Player> players)
        {
            if (players.Count < 2)
            {
                throw new NotEnoughPlayersException();
            }

            else if (players.Count > 5)
            {
                throw new ReachMaxPlayersException();
            }
        }
    }
}
