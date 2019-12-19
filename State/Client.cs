namespace design_patterns.State
{
    public static class Client
    {
        public static void Run()
        {
            var initialState = new ConcreteState1();
            var context = new Context(initialState);
            context.DoThat();
            context.DoThis();
            context.DoThat();
        }
    }
}