namespace design_patterns.Prototype
{
    public class Product : IPrototype
    {
        public string name;

        public IPrototype Clone()
        {
            return new Product() { name = this.name };
        }
    }
}