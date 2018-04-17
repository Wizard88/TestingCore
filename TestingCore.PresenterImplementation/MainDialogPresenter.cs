using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using TestingCore.PresenterAbstraction;
using TestingCore.PresenterAbstraction.ResponseModel;
using UI.ViewAbstraction;
using UI.ViewAbstraction.ViewModels;

namespace TestingCore.PresenterImplementation
{
    internal class MainDialogPresenter : IHardwareDetectionPresenter
    {
        private IMainDialog _view;
        private BindingList<ComboItem> _devices;
        private BindingList<ComboItem> _multimeters;
        private BindingList<ComboItem> _calboxes;
        private TaskScheduler _taskScheduler;
        private Device _currentDevice;
        private Device _curentMultimeter;
        private Device _curentCalbox;

        public MainDialogPresenter(IMainDialog view)
        {
            _view = view;
            _devices = new BindingList<ComboItem>();
            _multimeters = new BindingList<ComboItem>();
            _calboxes = new BindingList<ComboItem>();
            _devices.ListChanged += DevicesListChanged;
            _taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            _view.SetDevices(_devices);
            _view.SetMultimeters(_multimeters);
            _view.SetCalboxes(_calboxes);
            _view.JustifyEvent += JustifyEvent;
            _view.CalibrateEvent += CalibrateEvent;
            _view.SettingsEvent += SettingsEvent;
            _view.AboutEvent += AboutEvent;
            _view.HelpEvent += HelpEvent;
            _view.DeviceChanged += DeviceChanged;
            _view.MultimeterChanged += MultimeterChanged;
            _view.CalboxChanged += CalboxChanged;
        }

        #region Interface members
        public void HardwareIdentified(Device device)
        {
            if (Regex.IsMatch(device.Name, "^(TRT|RMOT|TWA|RMO)"))
                SynchronizeExecute(() => _devices.Add(new ComboItem(device.Name, device.ID)));
            else if (Regex.IsMatch(device.Name, "Agilent"))
                SynchronizeExecute(() => _multimeters.Add(new ComboItem(device.Name, device.ID)));
            else if (Regex.IsMatch(device.Name, "Calbox"))
                SynchronizeExecute(() => _calboxes.Add(new ComboItem(device.Name, device.ID)));
        }

        public void HardwareInserted(Device device) { }

        public void HardwareRemoved(Device device)
        {
            if (Regex.IsMatch(device.Name, "^(TRT|RMOT|TWA|RMO)"))
            {
                var item = _devices.First(x => x.Value.Equals(device.ID));
                SynchronizeExecute(() => _devices.Remove(item));
            }
            else if (Regex.IsMatch(device.Name, "Agilent"))
            {
                var item = _multimeters.First(x => x.Value.Equals(device.ID));
                SynchronizeExecute(() => _multimeters.Remove(item));
            }
            else if (Regex.IsMatch(device.Name, "Calbox"))
            {
                var item = _calboxes.First(x => x.Value.Equals(device.ID));
                SynchronizeExecute(() => _calboxes.Remove(item));
            }
        }
        #endregion

        private void SynchronizeExecute(Action action)
        {
            Task.Factory.StartNew(() => { action(); }, CancellationToken.None, TaskCreationOptions.AttachedToParent, _taskScheduler);
        }

        private void HelpEvent()
        {

        }

        private void AboutEvent()
        {
            UI.ViewFactory.Scope.Factory.MakeAboutDialog().ShowViewAsDialog();
        }

        private void SettingsEvent()
        {


        }

        private void CalibrateEvent()
        {
            UI.ViewFactory.Scope.Factory.MakeCalibrationView(_currentDevice.ID).ShowView();
        }

        private void JustifyEvent()
        {
            throw new NotImplementedException();
        }

        private void CalboxChanged(ComboItem item)
        {
            _curentCalbox = new Device(item.View, item.Value.ToString());
        }

        private void MultimeterChanged(ComboItem item)
        {
            _curentMultimeter = new Device(item.View, item.Value.ToString());
        }

        private void DeviceChanged(ComboItem item)
        {
            _currentDevice = new Device(item.View, item.Value.ToString());
        }

        private void DevicesListChanged(object sender, ListChangedEventArgs e)
        {
            _view.SetEnableCalibrate(_devices.Count > 0);
        }
    }
}
