using System;
using System.Threading;

namespace design_patterns.Memento
{
    public class ConcreteOriginator : IOriginator
    {
        private string _state;

        public ConcreteOriginator(string state)
        {
            _state = state;
            System.Console.WriteLine("Originator: My initial state is " + state);
        }

        public void DoSomething()
        {
            System.Console.WriteLine("Originator: I'm doing something important.");
            _state = GenerateRandomString(30);
            System.Console.WriteLine($"Originator: and my state has changed to {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "";

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];
                Thread.Sleep(12);
                length--;
            }

            return result;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this, _state);
        }

        public void SetState(string state)
        {
            _state = state;
        }
    }
}