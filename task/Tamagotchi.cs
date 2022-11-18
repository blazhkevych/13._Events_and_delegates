namespace task
{
    delegate void MyDelegate();

    // Tamagotchi class.
    internal class Tamagotchi
    {
        public event MyDelegate _ev;
        private List<MyDelegate> _list;

        // Number of unsatisfied requests.
        public int NumberOfUnsatisfiedRequests { get; set; } // Max 3.

        public void EventCaller()
        {
            Console.WriteLine("A Tamagotchi event happened !!!");
            _ev?.Invoke();
        }

        // Character life cycle.
        public int LifeCycle { get; set; } // 60 - 120 seconds.

        // Changing the value of the Tamagotchi life cycle.
        Timer 

        // Shows the life cycle of Tamagotchi.
        public void ShowLifeCycle()
        {
            Console.WriteLine();
        }

        // Random life cycle.
        void RandomLifeCycle()
        {
            Random r = new Random();
            LifeCycle = r.Next(60, 121);
        }

        // Constructor.
        public Tamagotchi()
        {
            NumberOfUnsatisfiedRequests = 0;
            RandomLifeCycle();
            _list = new List<MyDelegate>
            {
                new Food().FeedTheTamagotchi, new Walk().WalkWithTamagotchi,
                new Sleep().PutTheTamagotchiToSleep, new Hospital().TreatTamagotchi,
                new Entertainment().PlayWithTamagotchi
            };
        }


    }
}

// покормить(Food.FeedTheTamagotchi), погулять(Walk.WalkWithTamagotchi),
// уложить спать(Sleep.PutTheTamagotchiToSleep), полечить(Hospital.TreatTamagotchi),
// поиграть(Entertainment.PlayWithTamagotchi).