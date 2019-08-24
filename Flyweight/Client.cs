namespace design_patterns.Flyweight
{
    public static class Client
    {
        public static void Run()
        {
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );
            factory.ListFlyweights();

            System.Console.WriteLine("Client: adding a car to database");
            var car = new Car()
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            };
            var flyweight = factory.GetFlyweight(car);

            flyweight.Execute(car);

            var newCar = new Car()
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",

            };
            Context context = new Context(factory, car, newCar);
            context.Execute();
        }
    }
}