namespace design_patterns.Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ConcreteElementA elementA)
        {
            elementA.FeatureA();
        }

        public void Visit(ConcreteElementB elementB)
        {
            elementB.FeatureB();
        }
    }
}