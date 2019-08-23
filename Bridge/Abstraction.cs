namespace design_patterns.Bridge
{
    public class Abstraction
    {
        private readonly IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public void Feature1()
        {
            implementation.Method1();
            implementation.Method2();
        }
    }
}