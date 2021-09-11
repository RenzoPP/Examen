using System;
using System.Collections.Generic;

namespace AppT1
{
    public class Program
    {
        private static List<Player> players;
        public static void Main(string[] args)
        {
            int numPlayers = SelectNumPlayers();
            players = new List<Player>();

            string name;

            for(int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("Ingrese Datos del Jugador");
                name = Convert.ToString(Console.ReadLine());

                players.Add(new Player(name));
            }

            Console.WriteLine($"8 {Suit.Spades}");
            PokerGame.Start(players);

            Console.ReadKey();
        }

        static int SelectNumPlayers()
        {
            Console.WriteLine("Ingrese número de jugadores");
            int numPlayers = Convert.ToInt16(Console.ReadLine());

            return numPlayers;
        }
    }
}
