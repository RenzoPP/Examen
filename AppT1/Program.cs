using AppT1.Handler;
using AppT1.Model;
using System;
using System.Collections.Generic;

namespace AppT1
{
    public class Program
    {
        public Program() { 
        }
        public static void Main()
        {
            int numPlayers = SelectNumPlayers();

            try
            {
                VerifyNumPlayers(numPlayers);
                PokerGame.Start(numPlayers);
            }
            catch (Exception e)
            {
                Console.Write("Hubo un error al iniciar el juego, presione una tecla: ");
                Console.ReadKey();

                Console.Clear();
                Main();
            }

            Console.ReadKey();
        }

        static int SelectNumPlayers()
        {
            Console.Write("Ingrese número de jugadores: ");
            int numPlayers = Convert.ToInt16(Console.ReadLine());

            return numPlayers;
        }

        public static void VerifyNumPlayers(int numPlayers)
        {
            if(numPlayers < 0)
            {
                throw new NegativeNumberException();
            }
            else if (numPlayers < 2)
            {
                throw new NotEnoughPlayersException();
            }
            else if (numPlayers > 5)
            {
                throw new ReachMaxPlayersException();
            }
        }
    }
}
