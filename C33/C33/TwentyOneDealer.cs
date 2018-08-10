using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
