using System;

namespace StateExample
{
    public class Program
    {
        Context _context = new Context(new ConcreteStateA());
        // _context.Request1();
        // _context.Request2();
    }
}