using TestingCore.CommunicationAbstraction;
using TestingCore.CommunicationFactory;

namespace TestingCore.CommunicationImplementation
{
    public class DetectorFactory : IFactory
    {
        private IHardwareDetection _detectorAgilent;
        private IHardwareDetection _detectorFTDI;

        public IHardwareDetection MakeAgilentCommunication()
        {
            if (_detectorAgilent == null) _detectorAgilent = new DetectorAgilent();

            return _detectorAgilent;
        }

        public IHardwareDetection MakeFTDICommunication()
        {
            if (_detectorFTDI == null) _detectorFTDI = new DetectorFTDI();

            return _detectorFTDI;
        }

        public IPort MakeStandartPort(string commID, string channel)
        {
            var deviceIo = (_detectorFTDI as DetectorFTDI).GetDeviceIo(commID, channel);

            return new StandardPort(deviceIo);
        }
    }
}
