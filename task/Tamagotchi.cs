namespace task
{
    delegate int MyDelegate();

    // Tamagotchi class.
    internal class Tamagotchi
    {
        public event MyDelegate _ev;
        public List<MyDelegate> _list;

        // Number of unsatisfied requests.
        public int NumberOfUnsatisfiedRequests { get; set; } // Max 3.

        //public void EventCaller()
        //{
        //    Console.WriteLine("A Tamagotchi event happened !!!");
        //    _ev?.Invoke();
        //}

        // Character life cycle start.
        public DateTime LifeCycleStart { get; set; } // 60 - 120 seconds.

        // Character life cycle stop.
        public DateTime LifeCycleStop { get; set; }

        // Changing the value of the Tamagotchi life cycle.
        //void TamagotchiLifecycleManagement()
        //{
        //    //DateTime
        //}

        // Shows the life cycle of Tamagotchi.
        //public void ShowLifeCycle()
        //{
        //    Console.WriteLine();
        //}

        // Constructor.
        public Tamagotchi()
        {
            Random r = new Random();
            LifeCycleStart = DateTime.Now;
            NumberOfUnsatisfiedRequests = 0;
            LifeCycleStop = LifeCycleStart.AddSeconds(r.Next(60, 121));
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