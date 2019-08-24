namespace design_patterns.Proxy
{
    public class Service : IService
    {
        public void Execute()
        {
            System.Console.WriteLine("Service: executing...");
        }
    }
}