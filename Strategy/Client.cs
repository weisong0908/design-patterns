namespace design_patterns.Strategy
{
    public static class Client
    {
        public static void Run()
        {
            var strategy1 = new ConcreteStrategy1();
            var strategy2 = new ConcreteStrategy2();

            var context = new Context();
            context.SetStrategy(strategy1);
            context.DoSomething("doing something...");
            context.SetStrategy(strategy2);
            context.DoSomething("doing something...");
        }
    }
}