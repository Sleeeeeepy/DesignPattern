namespace Builder
{
    public class ConcreteBuilder1 : Builder
    {
        private Product product;

        public override void BuildPart()
        {
            product = new Product("ConcreteBuilder1");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
