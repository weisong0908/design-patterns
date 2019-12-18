namespace design_patterns.Observer
{
    public class ConcreteSubscriber : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            System.Console.WriteLine("Concrete subscriber: new state received from publisher: " + publisher.State);
        }
    }
}