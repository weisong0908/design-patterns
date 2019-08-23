using System.Collections.Generic;

namespace design_patterns.Composite
{
    public class Composite : IComponent
    {
        private readonly IList<IComponent> components;

        public Composite()
        {
            components = new List<IComponent>();
        }

        public Composite(IList<IComponent> components)
        {
            this.components = components;
        }
        public void Add(IComponent leaf)
        {
            components.Add(leaf);
        }

        public void Remove(IComponent leaf)
        {
            components.Remove(leaf);
        }

        public IList<IComponent> GetChildren()
        {
            return components;
        }

        public void Execute()
        {
            foreach (var item in components)
                item.Execute();
        }
    }
}