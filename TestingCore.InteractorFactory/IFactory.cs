using TestingCore.CommunicationAbstraction;
using TestingCore.InteractorAbstraction;
using TestingCore.PresenterAbstraction;
using TestingCore.TransactionAbstraction;

namespace TestingCore.InteractorFactory
{
    public interface IFactory
    {
        IHardwareDetectionInteractor MakeHardwareDetector(IHardwareDetection hardwareDetection, IHardwareDetectionPresenter deviceDetectionPresenter);
        ITestInteractor MakeTurnsRatioTestInteractor(ITransaction transaction, ITestPresenter presenter);
    }
}
