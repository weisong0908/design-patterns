namespace design_patterns.State
{
    public class ConcreteState2 : IState
    {
        public string Name { get { return _name; } set { _name = value; } }

        private Context _context;
        private string _name;

        public ConcreteState2()
        {
            Name = "Concrete state 2";
        }

        public void SetContext(Context context)
        {
            _context = context;
        }

        public void DoThat()
        {
            System.Console.WriteLine("ConcreteState2: Do that");
        }

        public void DoThis()
        {
            System.Console.WriteLine("ConcreteState2: Do this");
        }
    }
}