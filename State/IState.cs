namespace design_patterns.State
{
    public interface IState
    {
        string Name { get; set; }
        void SetContext(Context context);
        void DoThis();
        void DoThat();
    }
}