namespace task
{
    /// <summary>
    /// Разработать приложение «Тамагочи». Жизненный цикл персонажа — 
    /// 1-2 минуты. Персонаж случайным образом выдаёт просьбы (но подряд одна 
    /// и та же просьба не выдаётся). Просьбы могут быть следующие: покормить, 
    /// погулять, уложить спать, полечить, поиграть. Если просьбы не 
    /// удовлетворяются трижды, персонаж «заболевает» и просит его полечить. В 
    /// случае отказа — «умирает». Персонаж отображается в консольном окне при 
    /// помощи псевдографики.
    ///
    /// класс тамагочи - это обьект наблюдения, который выдает просьбы.
    /// 
    /// События, которые могут происходить с персонажем:
    /// покормить, погулять, уложить спать, полечить, поиграть.
    ///
    ///
    /// 
    /// 
    /// </summary>


    internal class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tamagotchi = new Tamagotchi();

            Food food = new Food();
            Walk walk = new Walk();
            Sleep sleep = new Sleep();
            Hospital hospital = new Hospital();
            Entertainment entertainment = new Entertainment();

            //tamagotchi._ev += food.FeedTheTamagotchi;
            //tamagotchi._ev += walk.WalkWithTamagotchi;
            //tamagotchi._ev += sleep.PutTheTamagotchiToSleep;
            //tamagotchi._ev += hospital.TreatTamagotchi;
            //tamagotchi._ev += entertainment.PlayWithTamagotchi;

            //tamagotchi.EventCaller();

            Random rand = new Random();
            int previousValue = -1;
            int newValue = -1;
            do
            {
                do
                {
                    newValue = rand.Next(0, 5);
                } while (newValue == previousValue);

                tamagotchi.NumberOfUnsatisfiedRequests = tamagotchi._list[newValue].Invoke();
                previousValue = newValue;

                if (tamagotchi.NumberOfUnsatisfiedRequests == 3)
                {
                    Console.WriteLine("You drove the Tamagotchi to death. You must be ashamed !");

                    // Place to display the Tamagotchi face.

                    Environment.Exit(0);
                }

            } while (tamagotchi.LifeCycleStop > DateTime.Now);

            Console.WriteLine("Tamagotchi's life is over." +
                              "\n He lived a long and happy life !");
        }
    }
}