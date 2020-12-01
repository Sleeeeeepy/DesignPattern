namespace Builder
{
    public class ConcreteBuilder2 : Builder
    {
        private Product product;

        public override void BuildPart()
        {
            product = new Product("ConcreteBuilder2");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
