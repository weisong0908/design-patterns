namespace design_patterns.Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Execute()
        {
            System.Console.WriteLine("Executing...");
        }
    }
}