using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Sleep
    {
        // Put the tamagotchi to sleep.
        public int PutTheTamagotchiToSleep()
        {
            Console.WriteLine("\nTamagotchi looks sleepy. He probably wants to sleep. Let's put the Tamagotchi to sleep ?");
            Console.WriteLine("1. Yes." +
                              "\n2. No.");
            int hostResponse = Convert.ToInt32(Console.ReadLine());
            if (hostResponse == 2)
            {
                Console.WriteLine("Tips >>> If Tamagotchi doesn't sleep, he won't live long...");
                return 1;
            }
            else
            {
                Console.WriteLine("Tamagotchi sleeps sweetly ...");
                return 0;
            }
        }

        // Tama name.
        public string TamaName { get; set; }

        // Constructor.
        public Sleep(string tamaName)
        {
            TamaName = tamaName;
        }
    }
}
