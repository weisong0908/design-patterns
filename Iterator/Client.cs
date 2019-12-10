namespace design_patterns.Iterator
{
    public static class Client
    {
        public static void Run()
        {
            var collection = new WordsCollection();
            collection.AddItem("first");
            collection.AddItem("second");
            collection.AddItem("third");

            System.Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
                System.Console.WriteLine(element);

            System.Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
                System.Console.WriteLine(element);
        }
    }
}