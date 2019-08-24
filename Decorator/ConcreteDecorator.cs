namespace design_patterns.Decorator
{
    public class ConcreteDecorator : BaseDecorator
    {
        public ConcreteDecorator(IComponent wrapee) : base(wrapee)
        {

        }

        public override void Execute()
        {
            base.Execute();
        }
    }
}