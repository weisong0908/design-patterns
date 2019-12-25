namespace design_patterns.Visitor
{
    public class ConcreteElementA : IElement
    {
        public void FeatureA()
        {
            System.Console.WriteLine("Concrete element A: feature A");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}