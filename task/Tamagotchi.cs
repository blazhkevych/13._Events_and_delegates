namespace task;

internal delegate int MyDelegate();

// Tamagotchi class.
internal class Tamagotchi
{
    // Constructor.
    public Tamagotchi(string name)
    {
        Name = name;
        var r = new Random();
        LifeCycleStart = DateTime.Now;
        NumberOfUnsatisfiedRequests = 0;
        LifeCycleStop = LifeCycleStart.AddSeconds(r.Next(60, 121));
    }

    private int PreviousCase { get; set; }

    // Tamagotchi name.
    private string Name { get; }

    // Number of unsatisfied requests.
    private int NumberOfUnsatisfiedRequests { get; set; } // Max 3.

    // Character life cycle start.
    private DateTime LifeCycleStart { get; } // 60 - 120 seconds.

    // Character life cycle stop.
    public DateTime LifeCycleStop { get; set; }
    public event MyDelegate _food;
    public event MyDelegate _walk;
    public event MyDelegate _sleep;
    public event MyDelegate _hospital;
    public event MyDelegate _entertainment;

    private void IsStillAlive()
    {
        if (NumberOfUnsatisfiedRequests == 3)
        {
            Console.WriteLine("\nYou drove the Tamagotchi to death. You must be ashamed !");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Dead();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any button to throw him away !");
            Environment.Exit(0);
        }
    }

    public void GeneratorEventRandom()
    {
        var r = new Random();
        var caces = -1;
        do
        {
            caces = r.Next(1, 6);
        } while (PreviousCase == caces);

        switch (caces)
        {
            case 1:
                PreviousCase = 1;
                NumberOfUnsatisfiedRequests += _food.Invoke();
                break;
            case 2:
                PreviousCase = 2;
                NumberOfUnsatisfiedRequests += _walk.Invoke();
                break;
            case 3:
                PreviousCase = 3;
                NumberOfUnsatisfiedRequests += _sleep.Invoke();
                break;
            case 4:
                PreviousCase = 4;
                NumberOfUnsatisfiedRequests += _hospital.Invoke();
                break;
            case 5:
                PreviousCase = 5;
                NumberOfUnsatisfiedRequests += _entertainment.Invoke();
                break;
        }

        IsStillAlive();
    }

    // Tama talks.
    private void TamaTalks(string String)
    {
        Console.WriteLine();
        Console.Write("{0}: ", Name);
        Console.Write(String);
        Console.WriteLine();
        Thread.Sleep(1000);
    }

    // Show Tama name.
    private void WriteName()
    {
        Console.SetCursorPosition(7, 1);
        Console.WriteLine("  ♥  ♥  ♥  {0}  ♥  ♥  ♥", Name);
        Console.WriteLine();
    }

    // The birth of the Tamagotchi.
    public void Hatching()
    {
        for (var i = 0; i < 15; i++)
        {
            Console.Clear();

            WriteName();

            if (i % 2 == 0)
                Egg();
            else if (i % 3 == 0)
                Egg2();
            else
                Egg3();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Name + " is hatching!!");
            Thread.Sleep(200);
        }

        Console.Clear();
        WriteName();
        Egg();
        Thread.Sleep(500);

        Console.Clear();
        WriteName();
        Egg4();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        TamaTalks("\"MOMMY!\"");
        Thread.Sleep(400);
        TamaTalks("\"*squeeek*\"");
        Thread.Sleep(800);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private void Egg()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("                    ■■       ");
        Console.WriteLine("                  ■    ■     ");
        Console.WriteLine("                ■        ■   ");
        Console.WriteLine("               ■          ■  ");
        Console.WriteLine("              ■            ■ ");
        Console.WriteLine("             ■              ■");
        Console.WriteLine("             ■              ■");
        Console.WriteLine("             ■              ■");
        Console.WriteLine("               ■          ■  ");
        Console.WriteLine("                 ■ ■■■■ ■    ");
    }

    private void Egg2()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("                   ■■        ");
        Console.WriteLine("                 ■    ■      ");
        Console.WriteLine("               ■        ■    ");
        Console.WriteLine("              ■          ■   ");
        Console.WriteLine("             ■             ■  ");
        Console.WriteLine("            ■               ■ ");
        Console.WriteLine("            ■               ■");
        Console.WriteLine("             ■              ■");
        Console.WriteLine("               ■          ■  ");
        Console.WriteLine("                 ■ ■■■■ ■    ");
    }

    private void Egg3()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("                     ■■      ");
        Console.WriteLine("                   ■    ■     ");
        Console.WriteLine("                 ■        ■   ");
        Console.WriteLine("               ■           ■  ");
        Console.WriteLine("              ■             ■ ");
        Console.WriteLine("             ■               ■");
        Console.WriteLine("             ■               ■");
        Console.WriteLine("             ■              ■");
        Console.WriteLine("               ■          ■  ");
        Console.WriteLine("                 ■ ■■■■ ■    ");
    }

    private void Egg4()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("                    ■■       ");
        Console.WriteLine("                  ■    ■     ");
        Console.WriteLine("                ■        ■   ");
        Console.WriteLine("              ■            ■ ");
        Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("              ■  ■      ■  ■ ");
        Console.WriteLine("              ■    ■■■■    ■ ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■");
        Console.WriteLine("             ■              ■");
        Console.WriteLine("             ■              ■");
        Console.WriteLine("               ■          ■  ");
        Console.WriteLine("                 ■ ■■■■ ■    ");
    }

    public void Dead()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("                   ■ ■ ■ ■      ");
        Console.WriteLine("                   ■     ■      ");
        Console.WriteLine("                   ■     ■      ");
        Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■");
        Console.WriteLine("             ■      R.I.P.     ■");
        Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■");
        Console.WriteLine("                   ■     ■      ");
        Console.WriteLine("                   ■     ■      ");
        Console.WriteLine("                   ■     ■      ");
        Console.WriteLine("                   ■     ■      ");
        Console.WriteLine("                   ■     ■      ");
        Console.WriteLine("                   ■ ■ ■ ■      ");
    }
}