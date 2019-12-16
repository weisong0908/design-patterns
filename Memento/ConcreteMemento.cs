using System;

namespace design_patterns.Memento
{
    public class ConcreteMemento : IMemento
    {
        private readonly ConcreteOriginator _originator;
        private readonly string _state;
        private readonly DateTime _date;

        public ConcreteMemento(ConcreteOriginator originator, string state)
        {
            _originator = originator;
            _state = state;
            _date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return $"{_date} / ({_state.Substring(0, 9)})...";
        }

        public string GetState()
        {
            return _state;
        }

        public void Restore()
        {
            _originator.SetState(_state);
            System.Console.WriteLine($"Memento: My state has changed to {_state}");
        }
    }
}