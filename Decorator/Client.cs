namespace design_patterns.Decorator
{
    public static class Client
    {
        public static void Run()
        {
            var component = new ConcreteComponent();

            var decoratorA = new ConcreteDecorator(component);
            var decoratorB = new ConcreteDecorator(decoratorA);

            decoratorB.Execute();
        }
    }
}