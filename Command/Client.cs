using System.Collections.Generic;

namespace design_patterns.Command
{
    public static class Client
    {
        public static void Run()
        {
            Invoker invoker = new Invoker();
            invoker.SetCommand(new SimpleCommand());
            invoker.ExecuteCommand();

            Receiver receiver = new Receiver();
            IList<string> parameters = new List<string>()
            {
                "parameter 1", "parameter 2"
            };

            invoker.SetCommand(new ComplexCommand(receiver, parameters));
            invoker.ExecuteCommand();
        }
    }
}