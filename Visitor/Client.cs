namespace design_patterns.Visitor
{
    public static class Client
    {
        public static void Run()
        {
            var elementA = new ConcreteElementA();
            var elementB = new ConcreteElementB();
            var visitor = new ConcreteVisitor();

            elementA.Accept(visitor);
            elementB.Accept(visitor);
        }
    }
}