namespace design_patterns.FactoryMethod
{
    public class ProductBFactory : Factory
    {
        public override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}