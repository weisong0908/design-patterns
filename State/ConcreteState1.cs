namespace design_patterns.State
{
    public class ConcreteState1 : IState
    {
        public string Name { get { return _name; } set { _name = value; } }

        private Context _context;
        private string _name;

        public ConcreteState1()
        {
            Name = "Concrete state 1";
        }

        public void SetContext(Context context)
        {
            _context = context;
        }

        public void DoThat()
        {
            System.Console.WriteLine("ConcreteState1: Do that");
        }

        public void DoThis()
        {
            System.Console.WriteLine("ConcreteState1: Do this");
            var concreteState2 = new ConcreteState2();
            _context.ChangeState(concreteState2);
        }
    }
}