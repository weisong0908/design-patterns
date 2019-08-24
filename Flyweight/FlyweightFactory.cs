using System;
using System.Collections.Generic;
using System.Linq;

namespace design_patterns.Flyweight
{
    public class FlyweightFactory
    {
        private IList<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
        }

        public string GetKey(Car key)
        {
            var elements = new List<string>();

            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                System.Console.WriteLine("FlyweightFactory: Cannot find a flyweight, creating new one");
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                System.Console.WriteLine("FlyweightFactory: Reusing existing flyweght");
            }

            return flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count();

            System.Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights");

            foreach (var flyweight in flyweights)
                System.Console.WriteLine(flyweight.Item2);
        }
    }
}