namespace design_patterns.FactoryMethod
{
    public static class Pattern
    {
        public static void Run()
        {
            System.Console.WriteLine("-- Factory Method --");

            var productACreator = new ProductACreator();
            var productA = productACreator.CreateProduct();
            productA.DoStuff();
        }
    }
}