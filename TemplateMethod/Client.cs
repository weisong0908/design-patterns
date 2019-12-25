namespace design_patterns.TemplateMethod
{
    public static class Client
    {
        public static void Run()
        {
            var concreteClass1 = new ConcreteClass1();
            var concreteClass2 = new ConcreteClass2();

            System.Console.WriteLine("Concrete class 1");
            concreteClass1.TemplateMethod();

            System.Console.WriteLine("Concrete class 2");
            concreteClass2.TemplateMethod();
        }
    }
}