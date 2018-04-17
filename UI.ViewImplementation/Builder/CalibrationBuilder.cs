using UI.ViewAbstraction;

namespace UI.ViewImplementation.Builder
{
    public class CalibrationBuilder : IBuilder
    {
        public IView CreateView()
        {
            var view = new Calibration();
            view.MdiParent = AppContext.CurrentContext.MainForm;
            return view;
        }
    }
}
