using System;
using CommandExample;

namespace CommandExample
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _a, _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);        }
    }
}