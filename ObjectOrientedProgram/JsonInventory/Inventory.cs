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

            //Creating object for inventory manager using generics
            InventoryManager<InventoryFactory.Rice> inventoryRice = new InventoryManager<InventoryFactory.Rice>();
            InventoryManager<InventoryFactory.Wheat> inventoryWheat = new InventoryManager<InventoryFactory.Wheat>();
            InventoryManager<InventoryFactory.Pulse> inventoryPulse = new InventoryManager<InventoryFactory.Pulse>();

            //Declaring file path
            string jsonFilePath = @"E:\CODING\Coding\React Web Apps\coreAPI\Fellowship\ObjectOrientedProgram\ObjectOrientedProgram\JsonInventory\JsonFile\Inventory.json";
            //Reading the json file
            InventoryFactory listOfInventory = JsonConvert.DeserializeObject<InventoryFactory>(File.ReadAllText(jsonFilePath));
            while (true)
            {
                Console.WriteLine("\n1: Display Rice Inventory \n2: Display Wheat Inventory \n3: Display Pulse Inventory \n4: Add Rice \n5: Add Pulses \n6: Add Wheat"+
                                  "\n7: Delete Rice \n8: Delete Wheat \n9: Delete Pulse \n10: Go Back");
                bool flag = int.TryParse(Console.ReadLine(), out int choice);
                if (flag)
                {
                    switch (choice)
                    {
                        case 1:
                            //Calling the display inventory for rice using generics
                            new InventoryManager<InventoryFactory.Rice>(listOfInventory.RiceList).DisplayInventory();                           
                            break;
                        case 2:
                            //Calling the display inventory for wheat using generics
                            new InventoryManager<InventoryFactory.Wheat>(listOfInventory.WheatList).DisplayInventory();
                            break;
                        case 3:
                            //Calling the display inventory for pulses using generics
                            new InventoryManager<InventoryFactory.Pulse>(listOfInventory.PulseList).DisplayInventory();
                            break;
                        case 4:
                            inventoryRice.AddInventory(listOfInventory.RiceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(listOfInventory));
                            break;
                        case 5:
                            inventoryWheat.AddInventory(listOfInventory.WheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(listOfInventory));
                            break;
                        case 6:
                            inventoryPulse.AddInventory(listOfInventory.PulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(listOfInventory));
                            break;
                        case 7:
                            inventoryRice.DeleteInventory(listOfInventory.RiceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(listOfInventory));
                            break;
                        case 8:
                            inventoryWheat.DeleteInventory(listOfInventory.WheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(listOfInventory));
                            break;
                        case 9:
                            inventoryPulse.DeleteInventory(listOfInventory.PulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(listOfInventory));
                            break;
                        case 10:
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
