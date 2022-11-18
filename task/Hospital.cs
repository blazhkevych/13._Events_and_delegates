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

            Console.WriteLine("\nTamagotchi doesn't feel very good. He must have gotten sick. Should we take him to the hospital for treatment ?");
            Console.WriteLine("1. Feed the Tamagotchi." +
                              "\n2. Refuse Tamagotchi.");
            int hostResponse = Convert.ToInt32(Console.ReadLine());
            if (hostResponse == 2)
            {
                Console.WriteLine("Tips >>> If you do not monitor the health of the Tamagotchi and do not treat him, he will soon die !");
                return 1;
            }
            else
            {
                Console.WriteLine("Tamagotchi feels much better ...");
                return 0;
            }

        }
    }
}
