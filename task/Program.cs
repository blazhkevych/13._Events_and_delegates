namespace task;

/// <summary>
///     Разработать приложение «Тамагочи». Жизненный цикл персонажа —
///     1-2 минуты. Персонаж случайным образом выдаёт просьбы (но подряд одна
///     и та же просьба не выдаётся). Просьбы могут быть следующие: покормить,
///     погулять, уложить спать, полечить, поиграть. Если просьбы не
///     удовлетворяются трижды, персонаж «заболевает» и просит его полечить. В
///     случае отказа — «умирает». Персонаж отображается в консольном окне при
///     помощи псевдографики.
///     класс тамагочи - это обьект наблюдения, который выдает просьбы.
///     События, которые могут происходить с персонажем:
///     покормить, погулять, уложить спать, полечить, поиграть.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.ResetColor();
        // Give your Tamagotchi a name.
        Console.WriteLine("Give your Tamagotchi a name:");
        var tamaName = Console.ReadLine();
        var tamagotchi = new Tamagotchi(tamaName);

        var food = new Food(tamaName);
        var walk = new Walk(tamaName);
        var sleep = new Sleep(tamaName);
        var hospital = new Hospital(tamaName);
        var entertainment = new Entertainment(tamaName);

        tamagotchi._food += food.FeedTheTamagotchi;
        tamagotchi._walk += walk.WalkWithTamagotchi;
        tamagotchi._sleep += sleep.PutTheTamagotchiToSleep;
        tamagotchi._hospital += hospital.TreatTamagotchi;
        tamagotchi._entertainment += entertainment.PlayWithTamagotchi;

        tamagotchi.Hatching();
        do
        {
            tamagotchi.GeneratorEventRandom();
        } while (tamagotchi.LifeCycleStop > DateTime.Now);

        Console.WriteLine("\nThe end !");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        tamagotchi.Dead();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\nTamagotchi's life is over." +
                          "\nHe lived a long and happy life !");
    }
}