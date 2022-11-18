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
            Console.ResetColor();
            // Give your Tamagotchi a name.
            Console.WriteLine("Give your Tamagotchi a name:");
            string tamaName = Console.ReadLine();
            Tamagotchi tamagotchi = new Tamagotchi(tamaName);

            Food food = new Food(tamaName);
            Walk walk = new Walk(tamaName);
            Sleep sleep = new Sleep(tamaName);
            Hospital hospital = new Hospital(tamaName);
            Entertainment entertainment = new Entertainment(tamaName);

            //tamagotchi._ev += food.FeedTheTamagotchi;
            //tamagotchi._ev += walk.WalkWithTamagotchi;
            //tamagotchi._ev += sleep.PutTheTamagotchiToSleep;
            //tamagotchi._ev += hospital.TreatTamagotchi;
            //tamagotchi._ev += entertainment.PlayWithTamagotchi;

            //tamagotchi.EventCaller();


            // The birth of the Tamagotchi.
            tamagotchi.Hatching();

            Random rand = new Random();
            int previousValue = -1;
            int newValue = -1;
            do
            {
                do
                {
                    newValue = rand.Next(0, 5);
                } while (newValue == previousValue);

                tamagotchi.TamaTalks("");
                tamagotchi.NumberOfUnsatisfiedRequests = tamagotchi._list[newValue].Invoke();
                previousValue = newValue;

                if (tamagotchi.NumberOfUnsatisfiedRequests == 3)
                {
                    Console.WriteLine("\nYou drove the Tamagotchi to death. You must be ashamed !");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    tamagotchi.Dead();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any button to throw him away !");
                    Environment.Exit(0);
                }

            } while (tamagotchi.LifeCycleStop > DateTime.Now);

            Console.WriteLine("\nThe end !" +
                              "\nTamagotchi's life is over." +
                              "\nHe lived a long and happy life !");
        }
    }
}