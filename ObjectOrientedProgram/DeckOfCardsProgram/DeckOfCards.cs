using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.DeckOfCardsProgram
{
    /// <summary>
    /// Program for initilizing, shuffling and printing deck of cards
    /// </summary>
    public class DeckOfCards: IDeckOfCards
    {
        //Initializing the cards suits, ranks and deck of cards array 
        public static string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        public static string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public static int totalCards = suits.Length * ranks.Length;
        public static string[] deckOfCards = new string[totalCards];

        //Method to shuffle the arranged cards using random number
        public void ShuffleOfCards()
        {
            Random random = new Random();
            for (int i = 0; i < totalCards; i++)
            {
                int randomnum = random.Next(0, totalCards);
                string temp = deckOfCards[randomnum];
                deckOfCards[randomnum] = deckOfCards[i];
                deckOfCards[i] = temp;
            }
        }

        //Method to print array of cards after shuffling in 2d array
        public void PrintTwoDArrayOfCards()
        {
            string[,] arr = new string[4, 9];
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("For player {0}....", i + 1);
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = deckOfCards[k];
                    Console.WriteLine(arr[i, j]);
                    k++;
                }
                Console.WriteLine();
            }
        }

        //Method to arrange array of cards in deck of cards and calling shuffle and print method
        public void ArrangeArrayOfCards()
        {
            Console.WriteLine("Welcome To DeckOfCards Problem");
            for (int i = 0; i < ranks.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    deckOfCards[suits.Length * i + j] = ranks[i] +"of"+ suits[j];
                }
            }
            ShuffleOfCards();
            PrintTwoDArrayOfCards();
            Console.ReadLine();
        }
    }
}
