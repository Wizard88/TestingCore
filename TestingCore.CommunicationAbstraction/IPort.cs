using System.Threading.Tasks;

namespace TestingCore.CommunicationAbstraction
{
    public interface IPort
    {
        Task Send(string command);
        Task<byte[]> Receive(int timeout = 500);
    }
}
