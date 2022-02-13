using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgram.DeckOfCardsProgram;

namespace ObjectOrientedProgram
{
    /// <summary>
    /// Object oriented programming
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Calling the deck of card object to arrange, shuffle and print deck of cards using 2d array
            DeckOfCards cards = new DeckOfCards();
            cards.ArrangeArrayOfCards();
        }
    }
}
