using VisitorExample;

namespace VisitorExample
{
    class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            throw new System.NotImplementedException();
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            throw new System.NotImplementedException();
        }

    }
}