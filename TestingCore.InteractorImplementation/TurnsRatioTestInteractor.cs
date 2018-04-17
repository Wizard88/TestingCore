using TestingCore.CommandAbstraction;
using TestingCore.InteractorFactory;
using TestingCore.PresenterAbstraction;
using TestingCore.TransactionAbstraction;

namespace TestingCore.InteractorImplementation
{
    public class TurnsRatioTestInteractor : ITestInteractor
    {
        private ITestPresenter _presenter;
        private ITransaction _transaction;
        private ICommand _startCommand;
        private ICommand _stopCommand;

        public TurnsRatioTestInteractor(ITransaction transaction, ITestPresenter presenter)
        {
            _transaction = transaction;
            _presenter = presenter;
            _startCommand = TestingCore.CommandFactory.Scope.Factory.CreateStartTestCommand();
            _stopCommand = TestingCore.CommandFactory.Scope.Factory.CreatStopTestCommand();
        }

        public void Abort()
        {
            _transaction.Execute(_stopCommand);
        }

        public void Run()
        {
            _transaction.Execute(_startCommand);
        }
    }
}