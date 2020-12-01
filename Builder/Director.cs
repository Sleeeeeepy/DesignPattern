using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public Product Construct()
        {
            builder.BuildPart();
            return builder.GetResult();
        }
    }
}
