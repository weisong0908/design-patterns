namespace design_patterns.TemplateMethod
{
    public class ConcreteClass1 : AbstractClass
    {
        public override void RequiredOperation()
        {
            System.Console.WriteLine("Concrete class 1: implemented required operation");
        }
    }
}