namespace design_patterns.Observer
{
    public static class Client
    {
        public static void Run()
        {
            ConcretePublisher publisher = new ConcretePublisher();
            ISubscriber subscriber1 = new ConcreteSubscriber();
            ISubscriber subscriber2 = new ConcreteSubscriber();

            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            publisher.MainBusinessLogic();
        }
    }
}