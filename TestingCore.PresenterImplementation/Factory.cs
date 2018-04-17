using TestingCore.PresenterAbstraction;
using TestingCore.PresenterFactory;
using UI.ViewAbstraction;

namespace TestingCore.PresenterImplementation
{
    public class Factory : IFactory
    {
        public IHardwareDetectionPresenter MakeDevicePresenter(IStatusDetection view)
        {
            return new DeviceDetectionPresenter(view);
        }

        public IHardwareDetectionPresenter MakeMainDialogPresenter(IMainDialog view)
        {
            return new MainDialogPresenter(view);
        }

        public IHardwareDetectionPresenter MakeMultimeterPresenter(IStatusDetection view)
        {
            return new MultimeterDetectionPresenter(view);
        }

        public ITestPresenter MakeTurnsRatioTestPresenter(ICalibrationView view)
        {
            return new TestPresenter(view);
        }
    }
}
