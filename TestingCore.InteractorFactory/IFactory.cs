using TestingCore.InteractorAbstraction;
using TestingCore.PresenterAbstraction;
using TestingCore.TransactionAbstraction;

namespace TestingCore.InteractorFactory
{
    public interface IFactory
    {
        IHardwareDetectionInteractor MakeDetectionInteractorFTDI(IHardwareDetectionPresenter deviceDetectionPresenter);
        IHardwareDetectionInteractor MakeDetectionInteractorMultimeter(IHardwareDetectionPresenter deviceDetectionPresenter);
        ITestInteractor MakeTurnsRatioTestInteractor(ITestPresenter presenter, ITransaction transaction);
    }
}
