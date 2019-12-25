namespace design_patterns.TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation();
            RequiredOperation();
            OptionalOperation();
        }

        void BaseOperation()
        {
            System.Console.WriteLine("Abstract class: base operation");
        }

        public abstract void RequiredOperation();

        public virtual void OptionalOperation()
        {
            System.Console.WriteLine("Abstract class: optional operation");
        }
    }
}