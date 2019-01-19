using System;

namespace Lab40107_Collections.Classes
{

    public class Card
    {
        public CardSuites CardSuit { get; set; }

        public CardValues CardValue { get; set; }
    }
    public enum CardSuites { Hearts, Diamonds, Spades, Clubs }

    public enum CardValues { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack }
}