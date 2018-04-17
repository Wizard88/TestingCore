using TestingCore.CommunicationAbstraction;

namespace TestingCore.CommunicationFactory
{
    public interface IFactory
    {
        IHardwareDetection MakeFTDICommunication();
        IHardwareDetection MakeAgilentCommunication();
        IPort MakeStandartPort(string commID, string channel);
    }
}
