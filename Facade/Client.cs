namespace design_patterns.Facade
{
    public static class Client
    {
        public static void Run()
        {
            var subsystem1 = new Subsystem1();
            var subsystem2 = new Subsystem2();

            var facade = new Facade(subsystem1, subsystem2);
            facade.Execute();
        }
    }
}