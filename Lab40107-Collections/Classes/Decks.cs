using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab40107_Collections.Classes
{
    /// <summary>
    /// Allows Us To Work With The Array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deck<T> : IEnumerable<T>
    {

        public T[] cardsInDeck = new T[10];
        public int currentCard = 0;


        /// <summary>
        /// This Method Adds Items To List And Resizes It
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (currentCard > cardsInDeck.Length - 1)
            {
                Array.Resize(ref cardsInDeck, cardsInDeck.Length * 2);
            }

            cardsInDeck[currentCard] = item;
            currentCard++;

        }

        /// <summary>
        /// Remove a card from the deck
        /// </summary>
        public void RemoveCards()
        {
            Array.Resize(ref cardsInDeck, currentCard - 1);
            currentCard--;
        }


        /// <summary>
        /// Print the amount of cards in the deck
        /// </summary>
        public void CardsInDeck()
        {
            Console.WriteLine($"There are {currentCard} left in deck");
        }

        /// <summary>
        /// Interface for Method
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentCard; i++)
            {
                yield return cardsInDeck[i];
            }

        }
        /// <summary>
        /// Calls method from above
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}