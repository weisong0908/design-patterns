namespace design_patterns.FactoryMethod
{
    public static class FactoryMethod
    {
        public static void Run()
        {
            System.Console.WriteLine("-- Factory Method --");

            var productAFactory = new ProductAFactory();
            var productA = productAFactory.CreateProduct();
            productA.DoStuff();
        }
    }
}