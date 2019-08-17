namespace design_patterns.Prototype
{
    public static class Prototype
    {
        public static void Run()
        {
            var product1 = new Product();
            product1.name = "Product 1";

            var product2 = (Product)product1.Clone();
            System.Console.WriteLine(product2.name);
        }
    }
}