using Lab40107_Collections;
using Lab40107_Collections.Classes;
using System;
using Xunit;

namespace Lab40107XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void CardOneWorks()
        {
            //Arrange
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;

            //act
            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            //assert

            Assert.Contains(cardOne, deck.internalItems);
        }

        [Fact]
        public void CardTwoWorks()
        {
            //Arrange
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;

            //act
            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            //assert

            Assert.Contains(cardTwo, deck.internalItems);
        }

        [Fact]
        public void GetSetWorks()
        {
            //Arrange
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;
            var heart = cardOne.CardSuit;
            //act
            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);
            //assert

            Assert.Equal(heart, cardOne.CardSuit);
        }

        [Fact]
        public void RemoveWorks()
        {
            //Arrange
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Diamonds;
            cardTwo.CardValue = CardValues.Five;

            Deck<Card> deck = new Deck<Card>();
            deck.Add(cardOne);
            deck.Add(cardTwo);


            //act
            deck.RemoveCards();
            //assert

            Assert.DoesNotContain(cardTwo, deck);
        }

    }
}