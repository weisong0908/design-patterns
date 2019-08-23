namespace design_patterns.Bridge
{
    public static class Client
    {
        public static void Run()
        {
            IImplementation concreteImplementation = new ConcreteImplementation();
            Abstraction abstraction = new Abstraction(concreteImplementation);
            abstraction.Feature1();
        }
    }
}