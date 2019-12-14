namespace design_patterns.Mediator
{
    public class Component2 : BaseComponent
    {
        public void OperateC()
        {
            System.Console.WriteLine("Component 2 does C");
            _mediator.Notify(this, "C");
        }

        public void OperateD()
        {
            System.Console.WriteLine("Component 2 does D");
            _mediator.Notify(this, "D");
        }
    }
}