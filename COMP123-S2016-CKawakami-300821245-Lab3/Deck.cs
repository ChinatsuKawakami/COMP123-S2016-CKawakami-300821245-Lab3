using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * <summary>
 * This class extends the List<Card> generic type
 * </summary>
 * @class Deck ( Deck is a List , it has a relation ship)
 */
namespace COMP123_S2016_CKawakami_300821245_Lab3
{
    /**
     * <summary>
     * This class extends the List<Card> generic type 
     * </summary>
     * @class Deck
     */
    public class Deck:List<Card> //Deck is subclass
    {
        //CONSTRUCTORS********************************************************************
        /**
         * <summary>
         * This is the default constructor for the Deck class
         * </summary>
         * @
         */
        //Deck is a List(List of Card type)
        public Deck()
        {

            //create my deck of cards 
            this._create();
        }

        //Private Mehod**************************************************************
        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * @private
         * @method CreateDeck()
         * @returns {void}
         */
   
        private void _create()
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
                 
                  //because this class is a List pf Card type
                 this.Add(new Card(face, suit));
              }// end for face 
          }// close loop for suit

        }//close _create Method

        //PUBLIC METHODS**************************************************************************
        /**
         * <summary>
         * This method displays a list of card objects to the console
         * </summary>
         * @method Display
         * @returns {void}
         */
        public void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Deck                                 +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
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
         * @method Shuffle
         * @returns {void}
         */
        public void Shuffle()
        {
            //shape of Random this is not object
            //create a pseudo random number sequence and stores it in random
            Random random = new Random();
            //record List number of cards in the deck List

            int cardCount = this.Count;

           //iterate through the list of cards
            for (int currentCard = 0;currentCard<cardCount;currentCard++)
            {
                //They are algorithm
                Card tempCard = this[currentCard];//copy current card to temp location
                int randomCard = random.Next(0, cardCount);//get a random Card index
                this[currentCard] = this[randomCard];//copy value from randomCard to currentCard
                this[randomCard] = tempCard; // copy current Card to random card
            }// end - for loop
        }
    }
}

