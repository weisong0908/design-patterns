namespace design_patterns.Visitor
{
    public interface IVisitor
    {
        void Visit(ConcreteElementA elementA);
        void Visit(ConcreteElementB elementB);
    }
}