namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA createProductA();
        IAbstractProductB createProductB();
    }

    public interface IAbstractProductB
    {
        string UsefulFunctionB();
    }
 
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }
}