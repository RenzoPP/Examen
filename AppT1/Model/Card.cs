using System;
using System.Collections.Generic;
using System.Text;

namespace AppT1.Model
{
    public class Card
    {
        private string value { get; }
        private Suit symbol { get; }

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
