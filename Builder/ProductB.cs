using System.Collections;
using System.Collections.Generic;

namespace design_patterns.Builder
{
    public class ProductB
    {
        public IList Specifications { get; set; }

        public ProductB()
        {
            Specifications = new List<string>();
        }
    }
}