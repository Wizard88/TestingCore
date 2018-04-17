using System;
using TestingCore.CommunicationAbstraction;
using TestingCore.InteractorAbstraction;
using TestingCore.PresenterAbstraction;
using TestingCore.PresenterAbstraction.ResponseModel;

namespace TestingCore.InteractorImplementation
{
    internal class DetectionInteractionFTDI : IHardwareDetectionInteractor
    {
        private bool _isDisposed = false;
        private IHardwareDetectionPresenter _deviceDetectionPresenter;
        private IHardwareDetection _detectorFTDI;

        public DetectionInteractionFTDI(IHardwareDetectionPresenter deviceDetectionPresenter)
        {
            _deviceDetectionPresenter = deviceDetectionPresenter;

            _detectorFTDI = CommunicationFactory.Scope.Factory.MakeFTDICommunication();
            _detectorFTDI.Identified += DeviceIdentified;
            _detectorFTDI.Inserted += DeviceInserted;
            _detectorFTDI.Removed += DeviceRemoved;
        }

        #region Interface members
        public void InitObserve()
        {
            _detectorFTDI.Initialize();
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
                if (_detectorFTDI != null) _detectorFTDI.Dispose();
            }

            _isDisposed = true;
        }
        #endregion
    }
}
