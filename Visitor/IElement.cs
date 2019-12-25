namespace design_patterns.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}