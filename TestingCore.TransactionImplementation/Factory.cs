using TestingCore.CommunicationAbstraction;
using TestingCore.TransactionAbstraction;
using TestingCore.TransactionFactory;

namespace TestingCore.TransactionImplementation
{
    public class Factory : IFactory
    {
        public ITransaction MakeStandardTransaction(IPort port)
        {
            return new StandardTransaction(port);
        }
    }
}
