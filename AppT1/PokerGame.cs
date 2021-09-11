using System;
using AppT1.Handler;
using System.Collections.Generic;
using System.Text;

namespace AppT1
{
    public class PokerGame
    {
        private static List<Player> players;
        public static void Start(int numPlayers)
        {
            players = new List<Player>(new Player[numPlayers]);
            string name;

            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese Datos del Jugador");
                Console.WriteLine($"Jugador {i + 1}");
                Console.Write("Nombre: ");
                name = Convert.ToString(Console.ReadLine());

                players.Add(new Player(name));
            }
        }
    }
}
