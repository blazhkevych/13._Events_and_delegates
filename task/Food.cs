using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Food
    {
        // Feed the Tamagotchi.
        public int FeedTheTamagotchi()
        {
            Console.WriteLine("Tamagotchi asks for food ! Feed the Tamagotchi ?");
            Console.WriteLine("1. Yes." +
                              "\n2. No.");
            int hostResponse = Console.Read();
            if (hostResponse == 2)
            {
                Console.WriteLine("Tips >>> If you don't feed your Tamagotchi, he will starve to death.");
                return 1;
            }
            else
            {
                Console.WriteLine("Tamagotchi eats ...");
                return 0;
            }
        }
    }
}
