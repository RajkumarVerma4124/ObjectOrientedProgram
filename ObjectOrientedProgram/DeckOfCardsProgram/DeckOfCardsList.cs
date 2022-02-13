using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.DeckOfCardsProgram
{
    /// <summary>
    /// Deck of cards for distributing nine cards to four players and sort them
    /// </summary>
    public class DeckOfCardsList
    {
        //Initializing suit array and rank array
        string[] cardSuit = new string[] { "Clubs", "Diamond", "Heart", "Spade" };
        string[] cardRank = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        List<string> checkCard = new List<string>();
        public void DistributeCards()
        {
            string[,] cardDeck = new string[cardSuit.Length, cardRank.Length];

            for (int i = 0; i < cardSuit.Length; i++)
            {
                for (int j = 0; j < cardRank.Length; j++)
                {
                    cardDeck[i, j] = $"{cardRank[j]} of {cardSuit[i]}";
                }
            }
            //Printing the deck of cards
            PrintCardDeck(cardDeck);
            Console.WriteLine();

            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            Random rand = new Random();
            int randomSuit, randomRank;
            int k = 1;
            //Adding cards to each player using list
            while (k <= 4)
            {
                List<string> playerCard = new List<string>();
                while (playerCard.Count < 9)
                {
                    randomSuit = rand.Next(0, cardSuit.Length);
                    randomRank = rand.Next(0, cardRank.Length);
                    if (!checkCard.Contains(cardDeck[randomSuit, randomRank]))
                    {
                        playerCard.Add(cardDeck[randomSuit, randomRank]);
                        checkCard.Add(cardDeck[randomSuit, randomRank]);
                    }
                }
                players.Add($"Player {k++}", playerCard);
            }
            PrintPlayerCards(players);
            Console.ReadLine();
        }

        // Method for printing card hold by each players
        public void PrintPlayerCards(Dictionary<string, List<string>> players)
        {
            foreach (var i in players)
            {
                Console.WriteLine("\n"+i.Key+" has cards listed below ");
                SortByRank(i.Value, i.Key);
            }
        }

        //Method for printing card deck
        public void PrintCardDeck(string[,] cardDeck)
        {
            for (int i = 0; i < cardSuit.Length; i++)
            {
                for (int j = 0; j < cardRank.Length; j++)
                {
                    Console.Write(cardDeck[i, j]+" : ");
                }
                Console.WriteLine();
            }
        }

        //Method to find index of the element in the array
        public int FindIndex<T>(T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }

        //Method used to sort elements in array by rank
        public void SortByRank(List<string> playerCard, string playerName)
        {
            //Printing the player cards before sorting
            foreach (string j in playerCard)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
            //Bubble sort algorithm used to sort the elements in the array
            for (int i = 0; i < playerCard.Count - 1; i++)
            {
                int x, y;
                for (int j = 0; j < playerCard.Count - i - 1; j++)
                {
                    x = FindIndex(cardRank, playerCard[j].Split(' ')[0]);
                    y = FindIndex(cardRank, playerCard[j + 1].Split(' ')[0]);
                    //swap if x greater than y
                    if (x > y)
                    {
                        string temp = playerCard[j];
                        playerCard[j] = playerCard[j + 1];
                        playerCard[j + 1] = temp;
                    }
                }
            }

            //Printing the player cards after sorting
            Console.WriteLine("After sorting the {0} cards listed below",playerName);
            foreach (string j in playerCard)
            {
                Console.WriteLine(j);
            }
        }
    }
}
