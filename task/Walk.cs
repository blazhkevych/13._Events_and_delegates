using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Walk
    {
        // Walk with tamagotchi.
        public int WalkWithTamagotchi()
        {
            Console.WriteLine("\nI want to go for a walk. Will you go for a walk with me ?");
            Console.WriteLine("1. Yes." +
                              "\n2. No.");
            int hostResponse = Convert.ToInt32(Console.ReadLine());
            if (hostResponse == 2)
            {
                Console.WriteLine("Tips >>> If you do not walk with Tamagotchi, it will not end well for him.");
                return 1;
            }
            else
            {
                Console.WriteLine("Tamagotchi enjoys walking ...");
                return 0;
            }
        }

        // Tama name.
        public string TamaName { get; set; }

        // Constructor.
        public Walk(string tamaName)
        {
            TamaName = tamaName;
        }
    }
}
