using UI.ViewAbstraction;

namespace UI.ViewImplementation
{
    public class TurnsRatioFactory : ViewFactory
    {
        public TurnsRatioFactory() : base()
        {

        }

        public override IView MakeCalibrationView(string deviceID)
        {
            var view = new Calibration();
            var presenter = TestingCore.PresenterFactory.Scope.Factory.MakeTurnsRatioTestPresenter(view);
            var port = TestingCore.CommunicationFactory.Scope.Factory.MakeStandartPort(deviceID, "A");
            var transaction = TestingCore.TransactionFactory.Scope.Factory.MakeStandardTransaction(port);
            var interactor = TestingCore.InteractorFactory.Scope.Factory.MakeTurnsRatioTestInteractor(presenter, transaction);

            return view;
        }

        public override IView MakeJustifyView()
        {
            throw new System.NotImplementedException();
        }

        public override IView MakeSettingsView()
        {
            throw new System.NotImplementedException();
        }
    }
}
