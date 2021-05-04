using System;

namespace Singleton
{
    class Singleton
    {
        private static Singleton _test;
        private Singleton()
        {
            
        }

        public String Hello()
        {
            return "Hello Im a SingletonExample";
        }
        public static Singleton GetInstance()
        {
            _test = new Singleton();
            return _test;
        }
    }
}