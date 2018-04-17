using System.Threading.Tasks;
using TestingCore.CommandAbstraction;

namespace TestingCore.TransactionAbstraction
{
    public interface ITransaction
    {
        Task<string> Execute(ICommand command, int timeout = 500);
    }
}