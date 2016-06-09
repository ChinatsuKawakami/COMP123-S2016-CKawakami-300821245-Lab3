using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_CKawakami_300821245_Lab3
{

    /**
     * <summary>
     * This class creates an object that represents a playing card
     * </summary>
     * @class Card
     */
    class Card
    {
        //Public property*********************************************************

        public int Face { get; set; }
        public string Suit { get; set;}
        
        /**
         * <summary>
         * This construcctor takes Card parameters : fase and suit to instance
         * </summary>
         * 
         * @constructor Card
         * @param {int} face
         * @param {string} suit
         */
        //Constructor**************************************************************
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
