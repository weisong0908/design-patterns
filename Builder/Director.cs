namespace design_patterns.Builder
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ChangeBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public void MakeProduct(string option)
        {
            switch (option)
            {
                case "simple":
                    builder.Reset();
                    builder.BuildStep1();
                    break;
            }
        }
    }
}