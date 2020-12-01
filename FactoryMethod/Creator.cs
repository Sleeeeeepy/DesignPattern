namespace FactoryMethod
{
    //없어도 무방합니다. ConcreteCreator에서 여러 Product를 생성하기 때문입니다.
    //ConcreteCreator를 나누는 방법도 있습니다.
    public abstract class Creator
    {
        public abstract Product Create(ProductID productID);

    }
}
