using System.Collections.Generic;

namespace design_patterns.Composite
{
    public static class Client
    {
        public static void Run()
        {
            Leaf leaf = new Leaf();
            IList<IComponent> leaves = new List<IComponent>()
            {
                new Leaf(),
                new Leaf(),
                new Leaf(),
                new Leaf()
            };

            IList<IComponent> moreLeaves = new List<IComponent>()
            {
                new Leaf(),
                new Leaf(),
                new Leaf(),
                new Leaf(),
                new Leaf(),
                new Leaf(),
                new Leaf()
            };

            Composite branch1 = new Composite(leaves);
            Composite branch2 = new Composite(moreLeaves);

            branch1.Add(leaf);

            Composite tree = new Composite();
            tree.Add(branch1);
            tree.Add(branch2);
            tree.Add(leaf);
            tree.Execute();
        }
    }
}