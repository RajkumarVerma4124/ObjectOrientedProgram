using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgram.DeckOfCardsProgram;
using ObjectOrientedProgram.JsonInventory;

namespace ObjectOrientedProgram
{
    /// <summary>
    /// Object oriented programming
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome to the object oriented programing\n");
            try
            {
                while (true)
                {
                    Console.WriteLine("1: Deck Of Cards Using 2d Array \n2: Deck Of Card Using List And Sort \n3: Inventory Management \n4: Exit");
                    Console.Write("Enter a choice from above : ");
                    bool flag = int.TryParse(Console.ReadLine(), out int choice);
                    if (flag)
                    {
                        switch (choice)
                        {
                            case 1:
                                //Calling the deck of card object to arrange, shuffle and print deck of cards using 2d array
                                DeckOfCards cards = new DeckOfCards();
                                cards.ArrangeArrayOfCards();
                                break;
                            case 2:
                                //Calling the deck of cards
                                DeckOfCardsList list = new DeckOfCardsList();
                                list.DistributeCards();
                                break;
                            case 3:
                                //Calling the inventory method
                                Inventory.InventoryMain();
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;
                            default:
                                continue;
                        }
                    }
                    else
                        Console.WriteLine("Enter some value");
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }  
        }
    }
}
