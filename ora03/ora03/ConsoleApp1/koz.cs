class Koz
{
    static char[] bal = ['1', '3', '5', '6', '9'];
    static char[] jobb = ['2', '4', '7', '8', '0'];
    static int n = 80;
    static Random rnd = new Random();
    static char[] palya = new char[n];
    static void kiir()
    {
        for (int i = 0; i < palya.Length; i++)
        {
            System.Console.Write(palya[i]);
        }
    }
static void literal(){
    for (int i = 0; i < palya.Length; i++)
        {
            palya[i] = ' ';
        }
}

    static void gen()
    {
        double p = 0.5;
        double s = rnd.NextDouble();

        if (s > p)
        {
            palya[0] = (char)bal[rnd.Next(0, bal.Length - 1)];
        }
        s = rnd.NextDouble();
        if (s > p)
        {
            palya[n - 1] = (char)jobb[rnd.Next(0, bal.Length - 1)];
        }
    }

    static void Sims4()
    {
        bool exit = false;
        int timer = 1;
        while (!exit)
        {
            gen();
            timer++;
            Console.SetCursorPosition(0, 0);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
            }
            for (int i = 0; i < palya.Length; i++)
            {
                if (bal.Contains(palya[i]))
                {
                    if (i + 1 < n - 1)
                    {
                        if (palya[i + 1] == ' ' && timer % (int)palya[i] == 0)
                        {
                            palya[i + 1] = palya[i];
                            Console.SetCursorPosition(i, 1);
                        }
                        else
                        {
                            for (int j = 0; j < (int)palya[j]; j++)
                            {
                                if (i + j < n && palya[i + j] == ' ')
                                {
                                    Console.SetCursorPosition(i, 1);
                                    palya[i + j] = palya[i];
                                    palya[i] = ' ';
                                }
                            }
                        }
                    }
                }
                else if (jobb.Contains(palya[i]))
                {
                    if (i - 1 > 0)
                    {
                        if (palya[i - 1] == ' ' && timer % (int)palya[i] == 0)
                        {
                            palya[i - 1] = palya[i];
                        }
                        else
                        {
                            for (int j = 0; j < (int)palya[j]; j++)
                            {
                                if (i - j < n && palya[i - j] == ' ')
                                {
                                    palya[i - j] = palya[i];
                                    palya[i] = ' ';
                                }
                            }
                        }
                    }
                }
            }


            kiir();
            Thread.Sleep(100);
        }
    }


    static void Main()
    {
        Sims4();
        literal();
    }





}