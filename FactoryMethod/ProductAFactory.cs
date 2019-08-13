namespace design_patterns.FactoryMethod
{
    public class ProductAFactory : Factory
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}