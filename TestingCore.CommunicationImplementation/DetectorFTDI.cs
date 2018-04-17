using KvTeam.Communication;
using KvTeam.DeviceIo;
using System;
using System.Linq;
using TestingCore.CommunicationAbstraction;

namespace TestingCore.CommunicationImplementation
{
    internal class DetectorFTDI : IHardwareDetection
    {
        private CommunicationRepository _ftdiRepository;

        public DetectorFTDI()
        {
            _ftdiRepository = new CommunicationRepository();
            _ftdiRepository.DeviceInserted += DeviceInserted;
            _ftdiRepository.DeviceIdentified += DeviceIdentified;
            _ftdiRepository.DeviceRemoved += DeviceRemoved;
        }

        #region IHardwareDetection
        public event HardwareDelegate Inserted;
        public event HardwareDelegate Identified;
        public event HardwareDelegate Removed;

        public void Dispose()
        {
            _ftdiRepository.Dispose();
        }

        public void Initialize()
        {
            _ftdiRepository.Initiate();
        }
        #endregion

        #region Methods
        private Channels GetChannelEnum(string channel)
        {
            if (channel.ToUpper().Equals("A")) return Channels.A;
            else if (channel.ToUpper().Equals("B")) return Channels.B;
            else throw new InvalidOperationException("Wrong channel");
        }

        private void DeviceRemoved(object sender, DeviceEventArgs e)
        {
            if (Removed != null) Removed(e.Device.CommId, e.Device.DeviceName);
        }

        private void DeviceIdentified(object sender, DeviceEventArgs e)
        {
            if (Identified != null) Identified(e.Device.CommId, e.Device.DeviceName);
        }

        private void DeviceInserted(object sender, DeviceInsertedEventArgs e)
        {
            if (Inserted != null) Inserted(e.CommId, "");
        }

        public DeviceIo GetDeviceIo(string commID, string channel)
        {
            var channelEnum = GetChannelEnum(channel);
            var device = _ftdiRepository.DevicesAvailable.First(x => x.CommId.Equals(commID));

            return new DeviceIo(device.GetComChannel(channelEnum));
        }
        #endregion
    }
}
