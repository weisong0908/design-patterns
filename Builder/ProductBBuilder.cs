namespace design_patterns.Builder
{
    public class ProductBBuilder : IBuilder
    {
        private ProductB productB;

        public void BuildStep1()
        {
            System.Console.WriteLine("Building Product B... Step 1");
            productB.Specifications.Add("Step 1");
        }

        public void BuildStep2()
        {
            System.Console.WriteLine("Building Product B... Step 2");
            productB.Specifications.Add("Step 2");
        }

        public void BuildStep3()
        {
            System.Console.WriteLine("Building Product B... Step 3");
            productB.Specifications.Add("Step 3");
        }

        public void Reset()
        {
            System.Console.WriteLine("Building Product B... Reset");
            productB = new ProductB();
        }

        public ProductB GetProduct()
        {
            return productB;
        }
    }
}