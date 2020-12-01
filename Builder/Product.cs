namespace Builder
{
    public class Product
    {
        public string str { get; private set; }

        public Product(string str)
        {
            this.str = str;
        }
    }
}
