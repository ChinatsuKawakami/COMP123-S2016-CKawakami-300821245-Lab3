using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * This is driver class
 * Author :Chinatsu Kawakami
 * Student ID : 300821245
 * Date : 9th June 2016
 * Modified Date : 9th June 2016
 * version 0.0.4 - Added ShuffledDeck method in driver class
 *
 */
namespace COMP123_S2016_CKawakami_300821245_Lab3
{
    class Program
    {
         /**
         * The main method for our driver class program
          * 
         * @method Main
         * @params {string[]} args
         * @returns {void}
         */
        static void Main(string[] args)
        {

            //List that represents deck of cards
        List <Card> Deck = new List<Card>();

            CreateDeck(Deck);
            DisplayDeck(Deck);//display initial state of deck

            ShuffleDeck(Deck);
            DisplayDeck(Deck);//display the Shuffled state of deck
            
  
        }//close Main

        //PUBLIC STATIC ***********************************************************
        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * @method CreateDeck()
         * @param {List<Card>}deck
         * @returns {void}
         */
   
        public static void CreateDeck(List<Card>deck)
        {

          string suit = "";
          for (int suitIndex = 0; suitIndex < 4; suitIndex++)
          {
              switch (suitIndex)
              {

                  case 0:
                      suit = "Hearts";
                      break;
                  case 1:
                      suit = "Clubs";
                      break;
                  case 2:
                      suit = "Diamonds";
                      break;
                  case 3:
                      suit = "Spades";
                      break;
              }//close  loop switch

              for(int face =1 ; face<14; face++)
              {
                 deck.Add(new Card(face, suit));
              }// end for face 
          }// close loop for suit

        }//close _create Method


        /**
         * <summary>
         * This method displays a list of card objects to the console
         * </summary>
         * @method DisplayDeck
         * @params {List<Card>} deck
         * @returns {void}
         */
        public static void DisplayDeck(List<Card> deck)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Deck                                 +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in deck)
            {
                Console.WriteLine("{0} of {1}",card.Face,card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

        }//close DisplayDeck method

        /**
         * <summary>
         * This method randomly shuffles a list of Card object
         *
         * </summary>
         * @method ShuffledDeck
         * @params {List<Card>} deck
         * @returns {void}
         */
        public static void ShuffleDeck(List<Card> deck)
        {
            //shape of Random this is not object
            //create a pseudo random number sequence and stores it in random
            Random random = new Random();
            //record List number of cards in the deck List

            int cardCount = deck.Count;
           //iterate through the list of cards
            for (int currentCard = 0;currentCard<cardCount;currentCard++)
            {

                Card tempCard = deck[currentCard];//copy current card to temp location
                int randomCard = random.Next(0, cardCount);//get a random Card index
                deck[currentCard] = deck[randomCard];//copy value from randomCard to currentCard
                deck[randomCard] = tempCard; // copy current Card to random card
            }// end - for loop


        }

    }//close Program
}//close nameSpace
     
