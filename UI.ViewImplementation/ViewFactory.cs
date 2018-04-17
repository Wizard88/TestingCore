using UI.ViewAbstraction;
using UI.ViewFactory;
using UI.ViewImplementation.Builder;

namespace UI.ViewImplementation
{
    public abstract class ViewFactory : IFactory
    {
        public IView MakeMainContainer()
        {
            var mainContainer = new MainContainer();

            var presenter = TestingCore.PresenterFactory.Scope.Factory.MakeDevicePresenter(mainContainer);
            var _detectionDeviceInteractor = TestingCore.InteractorFactory.Scope.Factory.MakeDetectionInteractorFTDI(presenter);

            //mainContainer.FormClosed += FormClosed;
            //mainContainer.Shown += FormShown;

            return mainContainer;
        }

        public IView MakeMainDialog()
        {
            return new MainDialogBuilder().CreateView();
        }

        public IView MakeAboutDialog()
        {
            return new AboutBox();
        }

        public IView MakeHelpDialog()
        {
            return new HelpDialog();
        }

        public abstract IView MakeCalibrationView(string deviceID);
        public abstract IView MakeJustifyView();
        public abstract IView MakeSettingsView();
    }
}
