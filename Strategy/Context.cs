namespace design_patterns.Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomething(string data)
        {
            _strategy.Execute(data);
        }
    }
}