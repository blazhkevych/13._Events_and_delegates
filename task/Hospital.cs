namespace task;

internal class Hospital
{
    // Constructor.
    public Hospital(string tamaName)
    {
        TamaName = tamaName;
    }

    // Tama name.
    private string TamaName { get; }

    // Treat Tamagotchi.
    public int TreatTamagotchi()
    {
        Console.WriteLine(
            $"\n{TamaName}: \"Tamagotchi doesn't feel very good. He must have gotten sick. Should we take him to the hospital for treatment ?\"");
        Console.WriteLine("1. Yes." +
                          "\n2. No.");
        var hostResponse = Convert.ToInt32(Console.ReadLine());
        if (hostResponse == 2)
        {
            Console.WriteLine(
                "Tips >>> If you do not monitor the health of the Tamagotchi and do not treat him, he will soon die !");
            return 1;
        }

        Console.WriteLine("Tamagotchi feels much better ...");
        return 0;
    }
}