namespace design_patterns.Observer
{
    public interface ISubscriber
    {
        void Update(IPublisher publisher);
    }
}