using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.JsonInventory
{
    /// <summary>
    /// Created a file having inventory details for rice, wheat and pulses with properties
    /// </summary>
    public class InventoryProperties
    {
        //Declaring properties
        public List<Rice> RiceList { get; set; }
        public List<Pulse> PulseList { get; set; }
        public List<Wheat> WheatList { get; set; }

        //Declaring details for rice class with name, weight, and price per kg
        public class Rice
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return $"Rice Name : {Name} \tWeight : {Weight} \tPrice Per Kg : {Price}";
            }
        }

        //Declaring details for wheat class with name, weight, and price per kg
        public class Wheat
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return $"Wheat Name : {Name} \tWeight : {Weight} \tPrice Per Kg : {Price}";
            }
        }

        //Declaring details for pulse class with name, weight, and price per kg
        public class Pulse
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return $"Pulse Name : {Name} \tWeight : {Weight} \tPrice Per Kg : {Price}";
            }
        }
    }
}
