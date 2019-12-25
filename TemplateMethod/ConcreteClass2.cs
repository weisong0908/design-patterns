namespace design_patterns.TemplateMethod
{
    public class ConcreteClass2 : AbstractClass
    {
        public override void RequiredOperation()
        {
            System.Console.WriteLine("Concrete class 2: implemented required operation");
        }

        public override void OptionalOperation()
        {
            System.Console.WriteLine("Concrete class 2: implemented optional operation");
        }
    }
}