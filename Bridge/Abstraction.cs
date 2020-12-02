namespace Bridge
{
    public class Abstraction
    {
        private IImplementor implementor;

        public Abstraction(IImplementor implementor)
        {
            this.implementor = implementor;
        }

        public void Operation()
        {
            this.implementor.OperationImpl();
        }
    }
}
