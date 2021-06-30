using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace StateMachineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}