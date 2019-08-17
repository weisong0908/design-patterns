namespace design_patterns.AbstractFactory
{
    public static class AbstractFactory
    {
        public static void Run()
        {
            System.Console.WriteLine("-- Abstract Factory --");
            var factory = new Factory1();
            var productA = factory.createProductA();
            productA.DoStuff();
        }
    }
}