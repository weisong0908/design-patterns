namespace design_patterns.Decorator
{
    public class BaseDecorator : IComponent
    {
        private readonly IComponent wrapee;

        public BaseDecorator(IComponent wrapee)
        {
            this.wrapee = wrapee;
        }

        public virtual void Execute()
        {
            wrapee.Execute();
        }
    }
}