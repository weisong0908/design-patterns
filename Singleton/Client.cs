using System.Threading;

namespace design_patterns.Singleton
{
    public static class Client
    {
        public static void Run()
        {
            Thread process1 = new Thread(() =>
            {
                Singleton s1 = Singleton.GetInstance("s1");
                System.Console.WriteLine(s1.Name);
            });

            Thread process2 = new Thread(() =>
            {
                Singleton s2 = Singleton.GetInstance("s2");
                System.Console.WriteLine(s2.Name);
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }
    }
}