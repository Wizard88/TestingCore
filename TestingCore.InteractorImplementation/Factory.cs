using TestingCore.InteractorAbstraction;
using TestingCore.InteractorFactory;
using TestingCore.PresenterAbstraction;
using TestingCore.TransactionAbstraction;

namespace TestingCore.InteractorImplementation
{
    public class InteractorFactory : IFactory
    {
        public IHardwareDetectionInteractor MakeDetectionInteractorMultimeter(IHardwareDetectionPresenter deviceDetectionPresenter)
        {
            return new DetectionInteractorMultimeter(deviceDetectionPresenter);
        }

        public IHardwareDetectionInteractor MakeDetectionInteractorFTDI(IHardwareDetectionPresenter deviceDetectionPresenter)
        {
            return new DetectionInteractionFTDI(deviceDetectionPresenter);
        }

        public ITestInteractor MakeTurnsRatioTestInteractor(ITestPresenter presenter, ITransaction transaction)
        {
            return new TurnsRatioTestInteractor(presenter, transaction);
        }
    }
}
