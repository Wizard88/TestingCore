using TestingCore.InteractorAbstraction;
using UI.ViewAbstraction;

namespace UI.ViewImplementation.Builder
{
    public class MainDialogBuilder : IBuilder
    {
        private IHardwareDetectionInteractor _interactor;

        public IView CreateView()
        {
            var mainDialog = new MainDialog();
            var presenter = TestingCore.PresenterFactory.Scope.Factory.MakeMainDialogPresenter(mainDialog);
            _interactor = TestingCore.InteractorFactory.Scope.Factory.MakeDetectionInteractorFTDI(presenter);
            mainDialog.MdiParent = AppContext.CurrentContext.MainForm;
            mainDialog.Shown += FormShown;

            return mainDialog;
        }

        private void FormShown(object sender, System.EventArgs e)
        {
            _interactor.InitObserve();
        }
    }
}
