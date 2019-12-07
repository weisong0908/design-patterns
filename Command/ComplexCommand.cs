using System.Collections.Generic;

namespace design_patterns.Command
{
    public class ComplexCommand : ICommand
    {
        private readonly Receiver receiver;
        private readonly IList<string> parameters;

        public ComplexCommand(Receiver receiver, IList<string> parameters)
        {
            this.parameters = parameters;
            this.receiver = receiver;
        }

        public void Execute()
        {
            System.Console.WriteLine("Complex command executed");
            receiver.Operation();
        }
    }
}