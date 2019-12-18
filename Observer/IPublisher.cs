namespace design_patterns.Observer
{
    public interface IPublisher
    {
        string State { get; set; }
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void NotifySubscribers();
    }
}