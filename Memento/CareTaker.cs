using System;
using System.Collections.Generic;
using System.Linq;

namespace design_patterns.Memento
{
    public class CareTaker
    {
        private IList<IMemento> _history = new List<IMemento>();
        private ConcreteOriginator _originator = null;

        public CareTaker(ConcreteOriginator originator)
        {
            _originator = originator;
        }

        public void BackUp()
        {
            System.Console.WriteLine("\nCaretaker: Saving Originator's state...");
            _history.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_history.Count == 0)
                return;

            var memento = _history.Last();
            _history.Remove(memento);

            System.Console.WriteLine("CareTaker: Restoring state to: " + memento.GetName());

            try
            {
                memento.Restore();
            }
            catch (Exception ex)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            System.Console.WriteLine("CareTaker: Here's the list of mementos:");

            foreach (var memento in _history)
                System.Console.WriteLine(memento.GetName());
        }
    }
}