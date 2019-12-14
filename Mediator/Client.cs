namespace design_patterns.Mediator
{
    public static class Client
    {
        public static void Run()
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            Mediator mediator = new Mediator(component1, component2);

            System.Console.WriteLine("Client triggers component 1 to do A");
            component1.OperateA();
        }
    }
}