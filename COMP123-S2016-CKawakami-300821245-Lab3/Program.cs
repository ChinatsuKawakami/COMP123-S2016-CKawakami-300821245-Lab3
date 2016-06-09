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
 * version 0.0.3 - Added DisplayDeck method and CreateDeck method in driver class
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
            DisplayDeck(Deck);
            
  
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
    }//close Program
}//close nameSpace
     
