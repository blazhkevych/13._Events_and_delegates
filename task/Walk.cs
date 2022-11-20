namespace task;

internal class Walk
{
    // Constructor.
    public Walk(string tamaName)
    {
        TamaName = tamaName;
    }

    // Tama name.
    private string TamaName { get; }

    // Walk with tamagotchi.
    public int WalkWithTamagotchi()
    {
        Console.WriteLine($"\n{TamaName}: \"I want to go for a walk. Will you go for a walk with me ?\"");
        Console.WriteLine("1. Yes." +
                          "\n2. No.");
        var hostResponse = Convert.ToInt32(Console.ReadLine());
        if (hostResponse == 2)
        {
            Console.WriteLine("Tips >>> If you do not walk with Tamagotchi, it will not end well for him.");
            return 1;
        }

        Console.WriteLine("Tamagotchi enjoys walking ...");
        return 0;
    }
}