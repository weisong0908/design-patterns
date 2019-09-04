using System.Collections.Generic;

namespace design_patterns.ChainOfResponsibility
{
    public static class Client
    {
        public static void Run()
        {
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            System.Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");

            foreach (var food in new List<string> { "Nut", "Banana", "A cup of coffee" })
            {
                System.Console.WriteLine($"Client: Who wants a {food}?");
                var result = monkey.Handle(food);
                if (result == null)
                    System.Console.WriteLine($"\t{food} was left untouched");
                else
                    System.Console.WriteLine(result.ToString());
            }
        }
    }
}