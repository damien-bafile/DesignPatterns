using System;

namespace Singleton
{
    static class Program
    {
        static void Main(string[] args)
        {
            Singleton test;
            test = Singleton.GetInstance();
            Console.WriteLine(test.Hello());
        }
    }
}