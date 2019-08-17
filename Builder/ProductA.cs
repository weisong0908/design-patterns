using System.Collections;
using System.Collections.Generic;

namespace design_patterns.Builder
{
    public class ProductA
    {
        public IList Specifications { get; set; }

        public ProductA()
        {
            Specifications = new List<string>();
        }
    }
}