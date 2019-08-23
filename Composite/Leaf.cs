namespace design_patterns.Composite
{
    public class Leaf : IComponent
    {
        public void Execute()
        {
            System.Console.WriteLine("Leaf executing work...");
        }
    }
}