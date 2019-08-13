namespace design_patterns.FactoryMethod
{
    public class ProductBCreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}