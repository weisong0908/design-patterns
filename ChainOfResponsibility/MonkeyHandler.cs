namespace design_patterns.ChainOfResponsibility
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            else
                return base.Handle(request);
        }
    }
}