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

            tamagotchi._ev += food.FeedTheTamagotchi;
            tamagotchi._ev += walk.WalkWithTamagotchi;
            tamagotchi._ev += sleep.PutTheTamagotchiToSleep;
            tamagotchi._ev += hospital.TreatTamagotchi;
            tamagotchi._ev += entertainment.PlayWithTamagotchi;

            tamagotchi.EventCaller();




        }
    }
}