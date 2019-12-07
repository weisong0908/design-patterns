namespace design_patterns.Command
{
    public class SimpleCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Simple command executed.");
        }
    }
}