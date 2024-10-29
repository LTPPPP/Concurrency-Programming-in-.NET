using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Timer timer = new Timer(DisplayTime, null, 0, 1000);
        Console.ReadLine();
    }

    static void DisplayTime(object state)
    {
        Console.WriteLine($" Time: {DateTime.Now}");
    }
}
