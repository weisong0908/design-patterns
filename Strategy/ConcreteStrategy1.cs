namespace design_patterns.Strategy
{
    public class ConcreteStrategy1 : IStrategy
    {
        public void Execute(string data)
        {
            System.Console.WriteLine("Concrete Strategy 1: " + data);
        }
    }
}