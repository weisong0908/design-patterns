namespace design_patterns.Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object singletonLock = new object();
        public string Name { get; set; }

        private Singleton()
        { }

        public static Singleton GetInstance(string name)
        {
            if (instance == null)
                lock (singletonLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                        instance.Name = name;
                    }
                }
            return instance;
        }
    }
}