namespace design_patterns.Builder
{
    public interface IBuilder
    {
        void Reset();
        void BuildStep1();
        void BuildStep2();
        void BuildStep3();
    }
}