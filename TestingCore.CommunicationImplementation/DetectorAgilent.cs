using KvTeam.Communication.Agilent;
using TestingCore.CommunicationAbstraction;

namespace TestingCore.CommunicationImplementation
{
    internal class DetectorAgilent : IHardwareDetection
    {
        private AgilentCommunicationRepository _agilentRepository;

        public DetectorAgilent()
        {
            _agilentRepository = new AgilentCommunicationRepository();
            _agilentRepository.MultimeterDeviceInserted += DeviceInserted;
            _agilentRepository.MultimeterDeviceIdentified += DeviceIdentified;
            _agilentRepository.MultimeterDeviceRemoved += DeviceRemoved;
        }

        #region IHardwareDetection
        public event HardwareDelegate Inserted;
        public event HardwareDelegate Identified;
        public event HardwareDelegate Removed;

        public void Dispose()
        {

        }

        public void Initialize()
        {
            _agilentRepository.Initiate();
        }
        #endregion

        #region Methods
        private void DeviceRemoved(object sender, MultimeterEventArgs e)
        {
            if (Removed != null) Removed(e.Device.DeviceAddress, e.Device.DeviceModel);
        }

        private void DeviceIdentified(object sender, MultimeterEventArgs e)
        {
            if (Identified != null) Identified(e.Device.DeviceAddress, e.Device.DeviceModel);
        }

        private void DeviceInserted(object sender, AgilentDeviceEventArgs e)
        {
            if (Inserted != null) Inserted(e.DeviceAddress, e.DeviceName);
        }
        #endregion
    }
}
