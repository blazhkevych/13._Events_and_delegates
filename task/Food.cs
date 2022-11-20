namespace task;

internal class Food
{
    // Constructor.
    public Food(string tamaName)
    {
        TamaName = tamaName;
    }

    // Tama name.
    private string TamaName { get; }

    // Feed the Tamagotchi.
    public int FeedTheTamagotchi()
    {
        Console.WriteLine($"\n{TamaName}: \"I want to eat ! Will you feed me ?\"");
        Console.WriteLine("1. Yes." +
                          "\n2. No.");
        var hostResponse = Convert.ToInt32(Console.ReadLine());
        if (hostResponse == 2)
        {
            Console.WriteLine("Tips >>> If you don't feed your Tamagotchi, he will starve to death.");
            return 1;
        }

        Console.WriteLine("Tamagotchi eats ...");
        return 0;
    }
}