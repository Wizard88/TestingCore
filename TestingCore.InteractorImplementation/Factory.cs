using TestingCore.CommunicationAbstraction;
using TestingCore.InteractorAbstraction;
using TestingCore.InteractorFactory;
using TestingCore.PresenterAbstraction;
using TestingCore.TransactionAbstraction;

namespace TestingCore.InteractorImplementation
{
    public class InteractorFactory : IFactory
    {
        public IHardwareDetectionInteractor MakeHardwareDetector(IHardwareDetection hardwareDetection, IHardwareDetectionPresenter deviceDetectionPresenter)
        {
            return new HardwareDetector(hardwareDetection, deviceDetectionPresenter);
        }

        public ITestInteractor MakeTurnsRatioTestInteractor(ITransaction transaction, ITestPresenter presenter)
        {
            return new TurnsRatioTestInteractor(transaction, presenter);
        }

    }
}
