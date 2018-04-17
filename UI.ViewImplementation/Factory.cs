using UI.ViewAbstraction;
using UI.ViewFactory;
using UI.ViewImplementation.Controller;

namespace UI.ViewImplementation
{
    public class Factory : IFactory
    {
        public IView MakeAboutDialog()
        {
            return new AboutBox();
        }

        public IView MakeCalibrationView(string deviceID)
        {
            throw new System.NotImplementedException();
        }

        public IView MakeHelpDialog()
        {
            throw new System.NotImplementedException();
        }

        public IView MakeJustifyView()
        {
            throw new System.NotImplementedException();
        }

        public IView MakeMainContainer()
        {
            var mainView = new MainContainer();
            var mainController = new MainContainerController(mainView, mainView, mainView);

            return mainView;
        }

        public IView MakeMainDialog()
        {
            var mainDialog = new MainDialog();

            return mainDialog;
        }

        public IView MakeSettingsView()
        {
            throw new System.NotImplementedException();
        }
    }
}
