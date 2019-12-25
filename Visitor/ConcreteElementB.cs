namespace design_patterns.Visitor
{
    public class ConcreteElementB : IElement
    {
        public void FeatureB()
        {
            System.Console.WriteLine("Concrete element B: feature B");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}