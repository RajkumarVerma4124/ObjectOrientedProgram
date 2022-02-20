using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectOrientedProgram.JsonInventory.InventoryFactory;

namespace ObjectOrientedProgram.JsonInventory
{
    /// <summary>
    /// Interface for inventory manager
    /// </summary>
    internal interface IInventoryManager
    {
        void DisplayInventory();
        List<Rice> AddInventory(List<Rice> riceList);
        List<Wheat> AddInventory(List<Wheat> wheatList);
        List<Pulse> AddInventory(List<Pulse> pulseList);
        List<Rice> DeleteInventory(List<Rice> riceList);
        List<Wheat> DeleteInventory(List<Wheat> wheatList);
        List<Pulse> DeleteInventory(List<Pulse> pulseList);
    }
}
