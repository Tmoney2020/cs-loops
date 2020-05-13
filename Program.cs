using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var deckOfCards = new List<string>() { "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades", "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Clubs", "Queen of CLubs", "King of Clubs", "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds" };
            // make n = 52 since we are dealing with 52 elements
            var n = deckOfCards.Count();

            // for firstIndex from n - 1 down to 1 do:
            for (var firstIndex = n - 1; firstIndex >= 1; firstIndex--)
            {
                //   secondIndex = random integer that is greater than or equal to 0 and LESS than firstIndex
                Random rnd = new Random();
                var secondIndex = rnd.Next(firstIndex);

                //   Now swap the values at firstIndex and secondIndex by doing this:
                //     firstValue = the value from items[firstIndex]
                var firstValue = deckOfCards[firstIndex];

                //     secondValue = the value from items[secondIndex]
                var secondValue = deckOfCards[secondIndex];

                //     items[firstIndex] = secondValue
                deckOfCards[firstIndex] = secondValue;

                //     items[secondIndex] = firstValue
                deckOfCards[secondIndex] = firstValue;
            }
            Console.WriteLine(deckOfCards[0]);
            Console.WriteLine(deckOfCards[1]);





        }
    }
}
