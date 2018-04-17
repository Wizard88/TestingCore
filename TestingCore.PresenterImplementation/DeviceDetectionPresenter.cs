using System.Drawing;
using TestingCore.PresenterAbstraction;
using TestingCore.PresenterAbstraction.ResponseModel;
using UI.ViewAbstraction;

namespace TestingCore.PresenterImplementation
{
    internal class DeviceDetectionPresenter : IHardwareDetectionPresenter
    {
        private IStatusDetection _view;

        public DeviceDetectionPresenter(IStatusDetection view)
        {
            _view = view;
        }

        public void HardwareIdentified(Device device)
        {
            _view.NotifyDeviceStatus("Device identified", Color.Green);
        }

        public void HardwareInserted(Device device)
        {
            _view.NotifyDeviceStatus("Device inserted", Color.Blue);
        }

        public void HardwareRemoved(Device device)
        {
            _view.NotifyDeviceStatus("Device removed", Color.Red);
        }
    }
}
