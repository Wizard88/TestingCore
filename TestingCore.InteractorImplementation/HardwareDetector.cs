using System;
using TestingCore.CommunicationAbstraction;
using TestingCore.InteractorAbstraction;
using TestingCore.PresenterAbstraction;
using TestingCore.PresenterAbstraction.ResponseModel;

namespace TestingCore.InteractorImplementation
{
    internal class HardwareDetector : IHardwareDetectionInteractor
    {
        private bool _isDisposed = false;
        private IHardwareDetectionPresenter _deviceDetectionPresenter;
        private IHardwareDetection _hardwareDetection;

        public HardwareDetector(IHardwareDetection hardwareDetection, IHardwareDetectionPresenter deviceDetectionPresenter)
        {
            _hardwareDetection = hardwareDetection;
            _deviceDetectionPresenter = deviceDetectionPresenter;

            _hardwareDetection.Identified += DeviceIdentified;
            _hardwareDetection.Inserted += DeviceInserted;
            _hardwareDetection.Removed += DeviceRemoved;
        }

        #region Interface members
        public void InitObserve()
        {
            _hardwareDetection.Initialize();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region Methods
        private void DeviceInserted(string commID, string deviceName = "")
        {
            _deviceDetectionPresenter.HardwareInserted(new Device(deviceName, commID));
        }

        private void DeviceRemoved(string commID, string deviceName = "")
        {
            _deviceDetectionPresenter.HardwareRemoved(new Device(deviceName, commID));
        }

        private void DeviceIdentified(string commID, string deviceName = "")
        {
            _deviceDetectionPresenter.HardwareIdentified(new Device(deviceName, commID));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed) return;

            if (disposing)
            {
                if (_hardwareDetection != null) _hardwareDetection.Dispose();
            }

            _isDisposed = true;
        }
        #endregion
    }
}
