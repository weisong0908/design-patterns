namespace design_patterns.Builder
{
    public class ProductABuilder : IBuilder
    {
        private ProductA productA;

        public void BuildStep1()
        {
            System.Console.WriteLine("Building Product A... Step 1");
            productA.Specifications.Add("Step 1");
        }

        public void BuildStep2()
        {
            System.Console.WriteLine("Building Product A... Step 2");
            productA.Specifications.Add("Step 2");
        }

        public void BuildStep3()
        {
            System.Console.WriteLine("Building Product A... Step 3");
            productA.Specifications.Add("Step 3");
        }

        public void Reset()
        {
            productA = new ProductA();
        }

        public ProductA GetProduct()
        {
            return productA;
        }
    }
}