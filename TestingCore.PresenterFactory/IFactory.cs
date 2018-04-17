using TestingCore.PresenterAbstraction;
using UI.ViewAbstraction;

namespace TestingCore.PresenterFactory
{
    public interface IFactory
    {
        IHardwareDetectionPresenter MakeDevicePresenter(IStatusDetection view);
        IHardwareDetectionPresenter MakeMultimeterPresenter(IStatusDetection view);
        IHardwareDetectionPresenter MakeMainDialogPresenter(IMainDialog mainDialog);
        ITestPresenter MakeTurnsRatioTestPresenter(ICalibrationView view);
    }
}
