namespace design_patterns.FactoryMethod
{
    public class ProductACreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}