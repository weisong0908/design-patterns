namespace design_patterns.Flyweight
{
    public class Context
    {
        private readonly FlyweightFactory factory;
        private readonly Car uniqueState;
        private readonly Flyweight flyweight;

        public Context(FlyweightFactory factory, Car sharedState, Car uniqueState)
        {
            this.factory = factory;
            flyweight = factory.GetFlyweight(sharedState);
            this.uniqueState = uniqueState;
        }

        public void Execute()
        {
            flyweight.Execute(uniqueState);
        }
    }
}