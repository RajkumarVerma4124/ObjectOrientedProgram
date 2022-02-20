using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.JsonInventory
{
    /// <summary>
    /// Created The Class For Displaying The Inventory Of Rice, Wheat And Pulse
    /// </summary>
    public class InventoryManager: IInventoryManager
    {
        //Method to calculate price for inventory
        public int CalculatePrice(int weight, int price)
        {
            return weight * price;
        }

        //Method to calulate and display rice inventory and its price
        public void DisplayInventory(List<InventoryProperties.Rice>riceList)
        {
            int totalInventoryValue = 0;
            foreach (InventoryProperties.Rice rice in riceList)
            {
                int totalRicePrice = 0;
                Console.WriteLine(rice);
                totalRicePrice += CalculatePrice(rice.Weight, rice.Price);
                totalInventoryValue += CalculatePrice(rice.Weight, rice.Price);
                Console.WriteLine($"Total Cost For {rice.Name} Is Rs. {totalRicePrice}");
            }
            Console.WriteLine($"Total Inventory cost for Rice Is Rs. {totalInventoryValue}");
        }

        //Method to calulate and display wheat inventory and its price
        public void DisplayInventory(List<InventoryProperties.Wheat> wheatList)
        {
            int totalInventoryValue = 0;
            foreach (InventoryProperties.Wheat wheat in wheatList)
            {
                int totalWheatPrice = 0;
                Console.WriteLine(wheat);
                totalWheatPrice += CalculatePrice(wheat.Weight, wheat.Price);
                totalInventoryValue += CalculatePrice(wheat.Weight, wheat.Price);
                Console.WriteLine($"Total Inventory Cost For {wheat.Name} Is Rs. {totalWheatPrice}");
            }
            Console.WriteLine($"Total Inventory Cost For Wheat Is Rs. {totalInventoryValue}");
        }

        //Method to calulate and display wheat inventory and its price
        public void DisplayInventory(List<InventoryProperties.Pulse> pulseList)
        {
            int totalInventoryValue = 0;
            foreach (InventoryProperties.Pulse pulse in pulseList)
            {
                int totalPulsePrice = 0;
                Console.WriteLine(pulse);
                totalPulsePrice += CalculatePrice(pulse.Weight, pulse.Price);
                totalInventoryValue += CalculatePrice(pulse.Weight, pulse.Price);
                Console.WriteLine($"Total Inventory cost for {pulse.Name} Is Rs. {totalPulsePrice}");
            }
            Console.WriteLine($"Total Inventory Cost For Pulse Is Rs. {totalInventoryValue}");
        }
    }
}
