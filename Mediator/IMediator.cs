namespace design_patterns.Mediator
{
    public interface IMediator
    {
        void Notify(BaseComponent sender, string operation);
    }
}