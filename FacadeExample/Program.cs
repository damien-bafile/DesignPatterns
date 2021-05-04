using System;

namespace FacadeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();

            Facade facade = new Facade(subsystem1, subsystem2);
            Program.ClientCode(facade);
        }

        private static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}