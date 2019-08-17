namespace design_patterns.AbstractFactory
{
    public interface IFactory
    {
        IProductA createProductA();
        IProductB createProductB();
    }
}