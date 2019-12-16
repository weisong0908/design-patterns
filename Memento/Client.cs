namespace design_patterns.Memento
{
    public static class Client
    {
        public static void Run()
        {
            ConcreteOriginator originator = new ConcreteOriginator("Super-duper-super-puper-super.");
            CareTaker careTaker = new CareTaker(originator);

            careTaker.BackUp();
            originator.DoSomething();

            careTaker.BackUp();
            originator.DoSomething();

            careTaker.BackUp();
            originator.DoSomething();

            System.Console.WriteLine();
            careTaker.ShowHistory();

            System.Console.WriteLine("\nClient: Now, let's rollback\n");
            careTaker.Undo();

            System.Console.WriteLine("\n\nClient: once more!\n");
            careTaker.Undo();

            System.Console.WriteLine();
        }
    }
}