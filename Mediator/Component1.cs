namespace design_patterns.Mediator
{
    public class Component1 : BaseComponent
    {
        public void OperateA()
        {
            System.Console.WriteLine("Component 1 does A");
            _mediator.Notify(this, "A");
        }

        public void OperateB()
        {
            System.Console.WriteLine("Component 1 does B");
            _mediator.Notify(this, "B");
        }
    }
}