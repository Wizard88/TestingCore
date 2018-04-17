using TestingCore.PresenterAbstraction;
using UI.ViewAbstraction;

namespace TestingCore.PresenterImplementation
{
    public class TestPresenter : ITestPresenter
    {
        private ICalibrationView view;

        public TestPresenter(ICalibrationView view)
        {
            this.view = view;
        }
    }
}