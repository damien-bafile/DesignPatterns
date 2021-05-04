using System;
using System.Reflection.PortableExecutable;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();

            Facade::Facade facade = new Facade::Facade(subsystem1, subsystem2);
            Program.ClientCode(facade);
        }

        private static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }

    class Facade
    {
        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            throw new NotImplementedException();
        }
    }
}