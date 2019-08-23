namespace design_patterns.Bridge
{
    public class ConcreteImplementation : IImplementation
    {
        public void Method1()
        {
            System.Console.WriteLine("Concrete implementation method 1");
        }

        public void Method2()
        {
            System.Console.WriteLine("Concrete implementation method 2");
        }

        public void Method3()
        {
            System.Console.WriteLine("Concrete implementation method 3");
        }
    }
}