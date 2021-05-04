namespace AbstractFactory
{
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA createProductA()
        {
            return new concreteProductA2();
        }

        public IAbstractProductB createProductB()
        {
            throw new System.NotImplementedException();
        }
    }
}