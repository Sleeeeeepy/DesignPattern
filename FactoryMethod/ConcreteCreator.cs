namespace FactoryMethod
{
    public class ConcreteCreator : Creator
    {
        public override Product Create(ProductID productID)
        {
            if (productID == ProductID.Product1) return new ConcreteProduct1();
            if (productID == ProductID.Product2) return new ConcreteProduct2();
            if (productID == ProductID.Product3) return new ConcreteProduct3();
            return new ConcreteProduct1();
        }
    }
}
