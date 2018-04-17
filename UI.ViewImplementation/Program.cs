using System;
using System.Windows.Forms;

namespace UI.ViewImplementation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static AppContext _applicationContext;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TestingCore.CommunicationFactory.Scope.Factory = new TestingCore.CommunicationImplementation.DetectorFactory();
            TestingCore.CommandFactory.Scope.Factory = new TestingCore.CommandImplementation.CommandFactory();
            TestingCore.TransactionFactory.Scope.Factory = new TestingCore.TransactionImplementation.Factory();
            TestingCore.InteractorFactory.Scope.Factory = new TestingCore.InteractorImplementation.InteractorFactory();
            TestingCore.PresenterFactory.Scope.Factory = new TestingCore.PresenterImplementation.Factory();
            UI.ViewFactory.Scope.Factory = new UI.ViewImplementation.TurnsRatioFactory();

            var mainContainer = (Form)UI.ViewFactory.Scope.Factory.MakeMainContainer();
            _applicationContext = new AppContext(mainContainer);
            var mainDialog = UI.ViewFactory.Scope.Factory.MakeMainDialog();

            mainDialog.ShowView();

            Application.Run(_applicationContext);
        }
    }
}
