using System.Collections.Generic;

namespace design_patterns.Observer
{
    public class ConcretePublisher : IPublisher
    {
        public string State { get; set; }

        private readonly IList<ISubscriber> _subscribers;

        public ConcretePublisher()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void NotifySubscribers()
        {
            System.Console.WriteLine("ConcretePublisher: notifying subscribers");
            foreach (var subscriber in _subscribers)
                subscriber.Update(this);
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void MainBusinessLogic()
        {
            System.Console.WriteLine("ConcretePublisher: updating state");

            State = "new state";
            NotifySubscribers();
        }
    }
}