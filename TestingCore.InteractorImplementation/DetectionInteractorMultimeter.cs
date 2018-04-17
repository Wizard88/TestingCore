using System;
using TestingCore.CommunicationAbstraction;
using TestingCore.InteractorAbstraction;
using TestingCore.PresenterAbstraction;
using TestingCore.PresenterAbstraction.ResponseModel;

namespace TestingCore.InteractorImplementation
{
    public class DetectionInteractorMultimeter : IHardwareDetectionInteractor
    {
        private bool _isDisposed = false;
        private IHardwareDetectionPresenter _deviceDetectionPresenter;
        private IHardwareDetection _detectorMultimeter;

        public DetectionInteractorMultimeter(IHardwareDetectionPresenter deviceDetectionPresenter)
        {
            _deviceDetectionPresenter = deviceDetectionPresenter;

            _detectorMultimeter = CommunicationFactory.Scope.Factory.MakeAgilentCommunication();
            _detectorMultimeter.Inserted += DeviceInserted;
            _detectorMultimeter.Removed += DeviceRemoved;
            _detectorMultimeter.Identified += DeviceIdentified;
        }

        #region Interface members
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void InitObserve()
        {
            _detectorMultimeter.Initialize();
        }
        #endregion

        #region Methods
        private void Dispose(bool disposing)
        {
            if (_isDisposed) return;
            if (disposing && _detectorMultimeter != null) _detectorMultimeter.Dispose();
            _isDisposed = true;
        }

        private void DeviceIdentified(string commID, string deviceName = "")
        {
            _deviceDetectionPresenter.HardwareIdentified(new Device(deviceName, commID));
        }

        private void DeviceRemoved(string commID, string deviceName = "")
        {
            _deviceDetectionPresenter.HardwareRemoved(new Device(deviceName, commID));
        }

        private void DeviceInserted(string commID, string deviceName = "")
        {
            _deviceDetectionPresenter.HardwareInserted(new Device(deviceName, commID));
        }
        #endregion
    }
}
