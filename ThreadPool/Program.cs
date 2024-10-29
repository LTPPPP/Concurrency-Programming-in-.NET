using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            ThreadPool.QueueUserWorkItem(PrintNumbers, i);
        }

        Console.ReadLine(); // Đợi các tác vụ hoàn thành
    }

    static void PrintNumbers(object state)
    {
        int taskNumber = (int)state;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Task {taskNumber} - Number {i}");
            Thread.Sleep(500);
        }
    }
}
