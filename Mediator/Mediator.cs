namespace design_patterns.Mediator
{
    public class Mediator : IMediator
    {
        private readonly Component1 _component1;
        private readonly Component2 _component2;

        public Mediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(BaseComponent sender, string operation)
        {
            if (operation == "A")
            {
                System.Console.WriteLine("Mediator reacts to component 1");
                _component2.OperateC();
            }
        }
    }
}