using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Entertainment
    {
        // Play with tamagotchi.
        public int PlayWithTamagotchi()
        {
            Console.WriteLine("Tamagotchi asks for food !");
            Console.WriteLine("1. Feed the Tamagotchi." +
                              "\n2. Refuse Tamagotchi.");
            int hostResponse = Console.Read();
            if (hostResponse == 2)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("Tamagotchi is beside himself with entertainment ...");
                return 0;
            }

        }
    }
}
