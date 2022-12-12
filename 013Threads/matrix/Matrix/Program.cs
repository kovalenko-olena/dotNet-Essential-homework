using MatrixNS;

object locker = new object();
Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
Console.CursorVisible = false;
Random rand = new Random();
// for two lines in the column: j<2 
for (int j = 0; j < 2; j++)
{
    Thread[] threads = new Thread[Console.WindowWidth];
    for (int i = 0; i < Console.WindowWidth; i++)
    {
        threads[i] = new Thread(new ThreadStart(new Matrix(rand.Next(3, Console.WindowHeight / 2), i, ref locker).Write));
    }

    for (int i = 0; i < Console.WindowWidth * 5; i++)
    {
        int tmp = rand.Next(0, Console.WindowWidth - 1);
        if (!threads[tmp].IsAlive)
        {
            threads[tmp].Start();
            //Thread.Sleep(100);
        }
    }

    for (int i = 0; i < Console.WindowWidth; i++)
    {
        if (!threads[i].IsAlive) threads[i].Start();
    }
}

Console.ReadKey();
