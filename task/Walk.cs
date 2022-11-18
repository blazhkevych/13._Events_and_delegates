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
            Console.WriteLine("Tamagotchi asks to walk with him ! Shall we go for a walk with the Tamagotchi ?");
            Console.WriteLine("1. Yes." +
                              "\n2. No.");
            int hostResponse = Console.Read();
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
    }
}
