using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy
{
    public class Units
    {
        public string unitClass;
        public int healthPoint;        
        public int damage;
        public int defense;
        public int cost;

        public void Print()
        {
            Console.WriteLine($"\nClass: {unitClass}");
            Console.WriteLine($"Health: {healthPoint}");
            Console.WriteLine($"Damage: {damage}");
            Console.WriteLine($"Defence: {defense}");
            Console.WriteLine($"Cost: {cost}");
        }
    }
}
