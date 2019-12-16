using System;

namespace design_patterns.Memento
{
    public interface IMemento
    {
        void Restore();
        string GetName();
        string GetState();
        DateTime GetDate();
    }
}