using System.ComponentModel;
using UI.ViewAbstraction.ViewModels;

namespace UI.ViewAbstraction
{
    public delegate void ButtonAction();
    public delegate void ComboAction(ComboItem item);

    public interface IMainDialog
    {
        event ButtonAction JustifyEvent;
        event ButtonAction CalibrateEvent;
        event ButtonAction SettingsEvent;
        event ButtonAction AboutEvent;
        event ButtonAction HelpEvent;
        event ComboAction DeviceChanged;
        event ComboAction MultimeterChanged;
        event ComboAction CalboxChanged;

        void SetDevices(BindingList<ComboItem> list);
        void SetMultimeters(BindingList<ComboItem> list);
        void SetCalboxes(BindingList<ComboItem> list);
        void SetEnableJustify(bool flag);
        void SetEnableCalibrate(bool flag);
        void SetEnableSettings(bool flag);
    }
}
