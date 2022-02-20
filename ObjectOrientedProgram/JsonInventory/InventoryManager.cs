using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectOrientedProgram.JsonInventory.InventoryFactory;

namespace ObjectOrientedProgram.JsonInventory
{
    /// <summary>
    /// Created The Class For Displaying The Inventory Of Rice, Wheat And Pulse
    /// </summary>
    public class InventoryManager<T> : IInventoryManager
    {
        private readonly List<T> inventoryList;

        public InventoryManager(){ }   
        
        public InventoryManager(List<T> inventoryList)
        {
            this.inventoryList = inventoryList;
        }

        //Method to calulate and display rice, wheat and pulse inventory and its price
        public void DisplayInventory()
        {
            int totalInventoryValue = 0;
            foreach (var list in inventoryList)
            {
                int totalPrice = 0;
                Console.WriteLine(list);
                int weight = (int)list.GetType().GetProperty("Weight").GetValue(list);
                int price = (int)list.GetType().GetProperty("Price").GetValue(list);
                string name = (string)list.GetType().GetProperty("Name").GetValue(list);
                totalPrice += weight * price;
                totalInventoryValue += weight * price;
                Console.WriteLine($"Total Cost For {name} Is Rs. {totalPrice}");
            }
            Console.WriteLine($"Total Inventory Cost Is Rs. {totalInventoryValue}");
        }

        // Adding New Rice item to Inventory 
        public List<Rice> AddInventory(List<Rice> riceList)
        {
            Rice rice = new Rice();
            Console.Write("Enter Name Of The Rice : ");
            rice.Name = Console.ReadLine();
            Console.Write("Enter Weight Of The Rice : ");
            rice.Weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price Of The Rice : ");
            rice.Price = Convert.ToInt32(Console.ReadLine());
            riceList.Add(rice);
            Console.WriteLine($"Added Successfully : "+rice);
            return riceList;
        }
        
        // Adding New Wheat item to Inventory 
        public List<Wheat> AddInventory(List<Wheat> wheatList)
        {
            Wheat wheat = new Wheat();
            Console.Write("Enter Name Of The Rice : ");
            wheat.Name = Console.ReadLine();
            Console.Write("Enter Weight Of The Rice : ");
            wheat.Weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price Of The Rice : ");
            wheat.Price = Convert.ToInt32(Console.ReadLine());
            wheatList.Add(wheat);
            Console.WriteLine($"Added Successfully : " +wheat);
            return wheatList;
        }

        // Adding New Pulse item to Inventory 
        public List<Pulse> AddInventory(List<Pulse> pulseList)
        {
            Pulse pulse = new Pulse();
            Console.Write("Enter Name Of The Rice : ");
            pulse.Name = Console.ReadLine();
            Console.Write("Enter Weight Of The Rice : ");
            pulse.Weight = int.Parse(Console.ReadLine());
            Console.Write("Enter Price Of The Rice : ");
            pulse.Price = int.Parse(Console.ReadLine());
            pulseList.Add(pulse);
            Console.WriteLine($"Added Successfully : " +pulse);
            return pulseList;
        }

        //Deleting a Rice item from inventory 
        public List<Rice> DeleteInventory(List<Rice> riceList)
        {
            Rice rice = new Rice();
            Console.Write("Enter Name Of The Rice You Want To Delete : ");
            string nameOfRice = Console.ReadLine();
            riceList.Remove(riceList.Find(item => item.Name.Equals(nameOfRice)));
            Console.WriteLine($"Deleted {nameOfRice} From the Inventory Succesfully");
            return riceList;
        }

        //Deleting a Wheat item from inventory 
        public List<Wheat> DeleteInventory(List<Wheat> wheatList)
        {
            Rice rice = new Rice();
            Console.Write("Enter Name Of The Rice You Want To Delete : ");
            string nameOfRice = Console.ReadLine();
            wheatList.Remove(wheatList.Find(item => item.Name.Equals(nameOfRice)));
            Console.WriteLine($"Deleted {nameOfRice} From the Inventory Succesfully");
            return wheatList;
        }

        //Deleting a Pulse item from inventory 
        public List<Pulse> DeleteInventory(List<Pulse> pulseList)
        {
            Rice rice = new Rice();
            Console.Write("Enter Name Of The Rice You Want To Delete : ");
            string nameOfRice = Console.ReadLine();
            pulseList.Remove(pulseList.Find(item => item.Name.Equals(nameOfRice)));
            Console.WriteLine($"Deleted {nameOfRice} From the Inventory Succesfully");
            return pulseList;
        }
    }
}
