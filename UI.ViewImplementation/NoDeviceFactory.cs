using UI.ViewAbstraction;

namespace UI.ViewImplementation
{
    public class NoDeviceFactory : ViewFactory
    {
        public override IView MakeCalibrationView(string deviceID)
        {
            throw new System.NotImplementedException();
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
