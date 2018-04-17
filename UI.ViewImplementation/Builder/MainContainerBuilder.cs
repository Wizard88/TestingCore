using System;
using System.Windows.Forms;
using TestingCore.InteractorAbstraction;
using UI.ViewAbstraction;

namespace UI.ViewImplementation.Builder
{
    public class MainContainerBuilder : IBuilder
    {
        private IHardwareDetectionInteractor _detectionDeviceInteractor;

        public IView CreateView()
        {
            var mainContainer = new MainContainer();

            var presenter = TestingCore.PresenterFactory.Scope.Factory.MakeDevicePresenter(mainContainer);
            _detectionDeviceInteractor = TestingCore.InteractorFactory.Scope.Factory.MakeDetectionInteractorFTDI(presenter);

            mainContainer.FormClosed += FormClosed;
            mainContainer.Shown += FormShown;
            mainContainer.MdiChildActivate += MdiChildActivate;

            return mainContainer;
        }

        private void MdiChildActivate(object sender, EventArgs e)
        {
            //MessageBox.Show("Form activated");
        }

        private void FormShown(object sender, EventArgs e)
        {
            _detectionDeviceInteractor.InitObserve();
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            _detectionDeviceInteractor.Dispose();
        }
    }
}
