using AppT1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppT1
{
    public class Player
    {
        public Player(string name, Hand hand)
        {
            this.name = name;
            this.hand = hand;
        }

        private String name { get; set; }
        private Hand hand { get; set; }

        public void Print()
        {
            Console.WriteLine($"{name} with");
            hand.Print();
        }
    }
}
