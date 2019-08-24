namespace design_patterns.Facade
{
    public class Facade
    {
        private readonly Subsystem1 subsystem1;
        private readonly Subsystem2 subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this.subsystem1 = subsystem1;
            this.subsystem2 = subsystem2;
        }

        public void Execute()
        {
            subsystem1.Execute();
            subsystem2.Operate();
        }
    }
}