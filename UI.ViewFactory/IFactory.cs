using UI.ViewAbstraction;

namespace UI.ViewFactory
{
    public interface IFactory
    {
        IView MakeMainContainer();
        IView MakeMainDialog();
        IView MakeAboutDialog();
        IView MakeHelpDialog();
        IView MakeCalibrationView(string deviceID);
        IView MakeJustifyView();
        IView MakeSettingsView();
    }
}
