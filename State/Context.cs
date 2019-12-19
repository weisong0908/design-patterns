namespace design_patterns.State
{
    public class Context
    {
        private IState _state;

        public Context(IState initialState)
        {
            _state = initialState;
            _state.SetContext(this);
        }

        public void ChangeState(IState newState)
        {
            _state = newState;
            _state.SetContext(this);
        }

        public void DoThis()
        {
            _state.DoThis();
            System.Console.WriteLine("Context: current state - " + _state.Name);
        }

        public void DoThat()
        {
            _state.DoThat();
            System.Console.WriteLine("Context: current state - " + _state.Name);
        }
    }
}