namespace design_patterns.AbstractFactory
{
    public class Factory1 : IFactory
    {
        public IProductA createProductA()
        {
            return new ProductA1();
        }

        public IProductB createProductB()
        {
            return new ProductB1();
        }
    }
}