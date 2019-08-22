namespace design_patterns.Adapter
{
    public class ThirdPartyLibrary
    {
        public void ServiceMethod(string data)
        {
            System.Console.WriteLine("This is adaptee's ServiceMethod");
            System.Console.WriteLine(data);
        }
    }
}