namespace design_patterns.Adapter
{
    public class Adapter : IAdapter
    {
        private readonly ThirdPartyLibrary thirdPartyLibrary;
        public Adapter(ThirdPartyLibrary thirdPartyLibrary)
        {
            this.thirdPartyLibrary = thirdPartyLibrary;
        }

        public void ServiceMethod(string data)
        {
            thirdPartyLibrary.ServiceMethod(data);
        }
    }
}