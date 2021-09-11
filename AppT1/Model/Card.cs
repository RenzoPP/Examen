using System;
using System.Collections.Generic;
using System.Text;

namespace AppT1.Model
{
    public class Card
    {
        public string value { get; }
        public Suit symbol { get; }

        private short rank { get; }

        public Card(string value, Suit symbol, short rank = 0)
        {
            this.value = value;
            this.symbol = symbol;
            this.rank = rank;
        }

        public override String ToString()
        {
            return String.Format($"{value} {symbol}");
        }
    }
}
