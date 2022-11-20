namespace task;

internal class Entertainment
{
    // Constructor.
    public Entertainment(string tamaName)
    {
        TamaName = tamaName;
    }

    // Tama name.
    private string TamaName { get; }

    // Play with tamagotchi.
    public int PlayWithTamagotchi()
    {
        Console.WriteLine($"\n{TamaName}: \"I'm in such a great mood. Let's play ?\"");
        Console.WriteLine("1. Yes." +
                          "\n2. No.");
        var hostResponse = Convert.ToInt32(Console.ReadLine());
        if (hostResponse == 2)
        {
            Console.WriteLine("Tips >>> If you do not play with Tamagotchi, he will be in a bad mood !");
            return 1;
        }

        Console.WriteLine("Tamagotchi glows with happiness when you play with it ...");
        return 0;
    }
}