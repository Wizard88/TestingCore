using TestingCore.CommunicationAbstraction;
using TestingCore.TransactionAbstraction;

namespace TestingCore.TransactionFactory
{
    public interface IFactory
    {
        ITransaction MakeStandardTransaction(IPort port);
    }
}
