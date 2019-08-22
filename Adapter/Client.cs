namespace design_patterns.Adapter
{
    public static class Client
    {
        public static void Run()
        {
            ThirdPartyLibrary thirdPartyLibrary = new ThirdPartyLibrary();
            IAdapter adapter = new Adapter(thirdPartyLibrary);

            adapter.ServiceMethod("Calling by client using adapter");
        }
    }
}