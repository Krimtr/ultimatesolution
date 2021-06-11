using System;
using System.Threading;

namespace MyUltimateSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Hi Kamil");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(rand.Next(100,999));
            }
        }
    }
}
