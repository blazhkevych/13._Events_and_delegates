using System.Drawing;
using System.Xml.Linq;

namespace task
{
    delegate int MyDelegate();

    // Tamagotchi class.
    internal class Tamagotchi
    {
        public event MyDelegate _ev;
        public List<MyDelegate> _list;

        // Tamagotchi name.
        public string Name { get; set; }

        //public string Stage { get; set; }
        //ConsoleColor Color { get; set; }


        // Number of unsatisfied requests.
        public int NumberOfUnsatisfiedRequests { get; set; } // Max 3.

        //public void EventCaller()
        //{
        //    Console.WriteLine("A Tamagotchi event happened !!!");
        //    _ev?.Invoke();
        //}

        // Character life cycle start.
        public DateTime LifeCycleStart { get; set; } // 60 - 120 seconds.

        // Character life cycle stop.
        public DateTime LifeCycleStop { get; set; }

        // Tama talks.
        public void TamaTalks(string String)
        {
            //Console.ForegroundColor = Color;
            Console.WriteLine();
            Console.Write("{0}: ", Name);
            //Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String);
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
        }

        // Show Tama name.
        public void WriteName()
        {
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("  ♥  ♥  ♥  {0}  ♥  ♥  ♥", Name);
            Console.WriteLine();
        }

        // The birth of the Tamagotchi.
        public void Hatching()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Clear();

                WriteName();

                if (i % 2 == 0)
                    Egg();
                else if (i % 3 == 0)
                    Egg2();
                else
                    Egg3();

                //Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(Name + " is hatching!!");
                System.Threading.Thread.Sleep(200);
                //Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Clear();
            WriteName();
            Egg();
            //Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(500);

            Console.Clear();
            WriteName();
            Egg4();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            TamaTalks("\"MOMMY!\"");
            System.Threading.Thread.Sleep(400);
            TamaTalks("\"*squeeek*\"");
            System.Threading.Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.White;
        }

        void Egg()
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

        void Egg2()
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

        void Egg3()
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

        void Egg4()
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


        // Constructor.
        public Tamagotchi(string name)
        {
            //Stage = "egg";
            //Color = ConsoleColor.White;
            Name = name;
            Random r = new Random();
            LifeCycleStart = DateTime.Now;
            NumberOfUnsatisfiedRequests = 0;
            LifeCycleStop = LifeCycleStart.AddSeconds(r.Next(60, 121));
            _list = new List<MyDelegate>
            {
                new Food().FeedTheTamagotchi, new Walk().WalkWithTamagotchi,
                new Sleep().PutTheTamagotchiToSleep, new Hospital().TreatTamagotchi,
                new Entertainment().PlayWithTamagotchi
            };
        }


    }
}