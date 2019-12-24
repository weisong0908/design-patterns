namespace design_patterns.Strategy
{
    public class ConcreteStrategy2 : IStrategy
    {
        public void Execute(string data)
        {
            System.Console.WriteLine("Concrete Strategy 2: " + data);
        }
    }
}