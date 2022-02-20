using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.JsonInventory
{
    /// <summary>
    /// Interface for inventory manager
    /// </summary>
    internal interface IInventoryManager
    {
        int CalculatePrice(int weight, int price);
        void DisplayInventory(List<InventoryProperties.Rice> riceList);
        void DisplayInventory(List<InventoryProperties.Wheat> wheatList);
        void DisplayInventory(List<InventoryProperties.Pulse> pulseList);
    }
}
