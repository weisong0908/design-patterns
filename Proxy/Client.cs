namespace design_patterns.Proxy
{
    public static class Client
    {
        public static void Run()
        {
            var realService = new Service();
            var proxy = new Proxy(realService);
            proxy.Execute();
        }
    }
}