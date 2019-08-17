namespace design_patterns.AbstractFactory
{
    public class Factory2 : IFactory
    {
        public IProductA createProductA()
        {
            return new ProductA2();
        }

        public IProductB createProductB()
        {
            return new ProductB2();
        }
    }
}