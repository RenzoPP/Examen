using System;
using AppT1.Handler;
using System.Collections.Generic;
using System.Text;
using AppT1.Model;

namespace AppT1
{
    public class PokerGame
    {
        private static List<Player> players;
        public static void Start(int numPlayers)
        {
            players = new List<Player>();
            string name;

            Deck deck = new Deck(0);
            deck.Shuffle();

            Hand hand;

            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese Datos del Jugador");
                Console.WriteLine($"Jugador {i + 1}");
                Console.Write("Nombre: ");
                name = Convert.ToString(Console.ReadLine());

                hand = deck.DealHand();

                players.Add(new Player(name, hand));
            }

            int j = 0;
            foreach(var p in players)
            {
                Console.WriteLine($"Hand Player {j + 1}");
                p.Print();
                j++;
            }
        }
    }
}
