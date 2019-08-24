using Newtonsoft.Json;

namespace design_patterns.Flyweight
{
    public class Flyweight
    {
        private readonly Car sharedState;

        public Flyweight(Car car)
        {
            this.sharedState = car;
        }

        public void Execute(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            System.Console.WriteLine($"Flyweight: dispaying shared {s} and unique {u} states");
        }
    }
}