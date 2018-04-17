using TestingCore.InteractorAbstraction;
using UI.ViewAbstraction;

namespace UI.ViewImplementation.Controller
{
    public class MainContainerController
    {
        private readonly IView _view;
        private readonly INotify _notifyView;
        private readonly IStatusDetection _statusView;
        private readonly IHardwareDetectionInteractor _hardwareDetectionInteractor;

        public MainContainerController(IView view, INotify notifyView, IStatusDetection statusView)
        {
            _view = view;
            _notifyView = notifyView;
            _statusView = statusView;

            var hardwareDetection = TestingCore.CommunicationFactory.Scope.Factory.MakeFTDICommunication();
            var detectionPresenter = TestingCore.PresenterFactory.Scope.Factory.MakeDevicePresenter(_statusView);
            _hardwareDetectionInteractor = TestingCore.InteractorFactory.Scope.Factory.MakeHardwareDetector(hardwareDetection, detectionPresenter);

            _view.Shown += View_Shown;
            _view.Closed += View_Closed;
        }

        private void View_Closed(object sender, System.EventArgs e)
        {
            _hardwareDetectionInteractor.Dispose();
        }

        private void View_Shown(object sender, System.EventArgs e)
        {
            var mainDialog = UI.ViewFactory.Scope.Factory.MakeMainDialog();
            mainDialog.SetParent(_view);
            mainDialog.ShowView();
            _hardwareDetectionInteractor.InitObserve();
        }
    }
}
