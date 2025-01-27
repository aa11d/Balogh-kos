class ᓚᘏᗢ
{
    static Random rnd = new Random();

    static char[,] palya = new char[30,50];

    static void Kiiratas(){
        for (int i = 0; i < palya.GetLength(0); i++)
        {
            Console.SetCursorPosition(0,i); 
            for(int j = 0; j < palya.GetLength(1); j++)
            {
                System.Console.Write(palya[i,j]);
            }
            System.Console.WriteLine();
        }
    }
    static void Main(){
        Console.SetWindowSize(30,50);
        Console.ReadKey();
        bool exit = false;
        int timer = 100;
        while(!exit){
            timer--;
            Console.SetCursorPosition(0,0);
            System.Console.Write(timer);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = System.Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape)
                    exit = true;
                else{
                    Console.SetCursorPosition(15,25);
                    Console.Write(pressed.KeyChar);
                }
            }
        }
    }
}