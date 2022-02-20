using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.JsonInventory
{
    /// <summary>
    /// Main Method For Inventory Class
    /// </summary>
    public class Inventory
    {
        public static void InventoryMain()
        {
            //Displaying welcome message
            Console.WriteLine("Welcome To The Inventory Management Program");
            //Creating object for invetory manager
            InventoryManager inventory = new InventoryManager();
            //Declaring file path
            string jsonFilePath = @"E:\CODING\Coding\React Web Apps\coreAPI\Fellowship\ObjectOrientedProgram\ObjectOrientedProgram\JsonInventory\JsonFile\Inventory.json";
            //Reading the json file
            InventoryProperties listOfInventory = JsonConvert.DeserializeObject<InventoryProperties>(File.ReadAllText(jsonFilePath));
            while (true)
            {
                Console.WriteLine("\n1: Display Rice Inventory \n2: Display Wheat Inventory \n3: Display Pulse Inventory \n4: Go Back");
                bool flag = int.TryParse(Console.ReadLine(), out int choice);
                if (flag)
                {
                    switch (choice)
                    {
                        case 1:
                            //Calling the display inventory for rice
                            inventory.DisplayInventory(listOfInventory.RiceList);
                            break;
                        case 2:
                            //Calling the display inventory for wheat
                            inventory.DisplayInventory(listOfInventory.WheatList);
                            break;
                        case 3:
                            //Calling the display inventory for pulses
                            inventory.DisplayInventory(listOfInventory.PulseList);
                            break;
                        case 4:
                            Program.Main(null);
                            break;
                        default:
                            Console.WriteLine("Enter right choice");
                            continue;
                    }
                }
                else
                    Console.WriteLine("Enter some value");
                Console.ReadLine();
            }
        }
    }
}
