namespace task;

internal class Sleep
{
    // Constructor.
    public Sleep(string tamaName)
    {
        TamaName = tamaName;
    }

    // Tama name.
    private string TamaName { get; }

    // Put the tamagotchi to sleep.
    public int PutTheTamagotchiToSleep()
    {
        Console.WriteLine(
            $"\n{TamaName}: \"Tamagotchi looks sleepy. He probably wants to sleep. Let's put the Tamagotchi to sleep ?\"");
        Console.WriteLine("1. Yes." +
                          "\n2. No.");
        var hostResponse = Convert.ToInt32(Console.ReadLine());
        if (hostResponse == 2)
        {
            Console.WriteLine("Tips >>> If Tamagotchi doesn't sleep, he won't live long ...");
            return 1;
        }

        Console.WriteLine("Tamagotchi sleeps sweetly ...");
        return 0;
    }
}