namespace design_patterns.Proxy
{
    public class Proxy : IService
    {
        private readonly Service realService;

        public Proxy(Service realService)
        {
            this.realService = realService;
        }

        public bool CheckAccess()
        {
            return true;
        }

        public void Execute()
        {
            if (CheckAccess())
                realService.Execute();
        }
    }
}