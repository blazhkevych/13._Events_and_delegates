using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Hospital
    {
        // Treat Tamagotchi.
        public int TreatTamagotchi()
        {

            Console.WriteLine("Tamagotchi doesn't feel very good. He must have gotten sick. Should we take him to the hospital for treatment ?");
            Console.WriteLine("1. Feed the Tamagotchi." +
                              "\n2. Refuse Tamagotchi.");
            int hostResponse = Console.Read();
            if (hostResponse == 2)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("Tamagotchi recovers ...");
                return 0;
            }

        }
    }
}
