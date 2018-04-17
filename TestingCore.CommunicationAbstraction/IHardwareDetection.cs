using System;

namespace TestingCore.CommunicationAbstraction
{
    public delegate void HardwareDelegate(string commID, string deviceName = "");

    public interface IHardwareDetection : IDisposable
    {
        event HardwareDelegate Inserted;
        event HardwareDelegate Identified;
        event HardwareDelegate Removed;

        void Initialize();
    }
}
