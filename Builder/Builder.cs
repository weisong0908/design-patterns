namespace design_patterns.Builder
{
    public static class Builder
    {
        public static void Run()
        {
            var builder = new ProductABuilder();
            var director = new Director(builder);
            director.MakeProduct("simple");
            var product = builder.GetProduct();

            foreach (var specification in product.Specifications)
                System.Console.WriteLine(specification);
        }
    }
}