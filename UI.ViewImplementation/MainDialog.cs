using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UI.ViewAbstraction;
using UI.ViewAbstraction.ViewModels;

namespace UI.ViewImplementation
{
    public partial class MainDialog : Form, IView, IMainDialog
    {
        public MainDialog()
        {
            InitializeComponent();
        }

        #region IMainDialogOutput
        public event ButtonAction JustifyEvent;
        public event ButtonAction CalibrateEvent;
        public event ButtonAction SettingsEvent;
        public event ButtonAction AboutEvent;
        public event ButtonAction HelpEvent;
        public event ComboAction DeviceChanged;
        public event ComboAction MultimeterChanged;
        public event ComboAction CalboxChanged;

        public void SetDevices(BindingList<ComboItem> list)
        {
            BindListToComboBox(list, cbDevice);
        }

        public void SetMultimeters(BindingList<ComboItem> list)
        {
            BindListToComboBox(list, cbMultimeter);
        }

        public void SetCalboxes(BindingList<ComboItem> list)
        {
            BindListToComboBox(list, cbCalbox);
        }

        public void SetEnableJustify(bool flag)
        {
            SetButtonStyle(btnJustify, flag);
        }

        public void SetEnableCalibrate(bool flag)
        {
            SetButtonStyle(btnCalibration, flag);
        }

        public void SetEnableSettings(bool flag)
        {
            SetButtonStyle(btnSettings, flag);
        }
        #endregion

        #region IView
        public void CloseView()
        {
            this.Close();
        }

        public void SetParent(object parent)
        {
            this.MdiParent = (Form)parent;
        }

        public void ShowView()
        {
            this.Show();
        }

        public void ShowViewAsDialog()
        {
            this.ShowDialog();
        }
        #endregion

        #region Events
        private void cbDevice_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            DeviceChanged?.Invoke(cbDevice.SelectedItem as ComboItem);
        }

        private void cbMultimeter_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            MultimeterChanged?.Invoke(cbMultimeter.SelectedItem as ComboItem);
        }

        private void cbCalbox_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            CalboxChanged?.Invoke(cbMultimeter.SelectedItem as ComboItem);
        }

        private void btnJustify_Click(object sender, System.EventArgs e)
        {
            JustifyEvent?.Invoke();
        }

        private void btnCalibration_Click(object sender, System.EventArgs e)
        {
            CalibrateEvent?.Invoke();
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            SettingsEvent?.Invoke();
        }

        private void btnHelp_Click(object sender, System.EventArgs e)
        {
            HelpEvent?.Invoke();
        }

        private void btnAbout_Click(object sender, System.EventArgs e)
        {
            AboutEvent?.Invoke();
        }

        #endregion

        private void BindListToComboBox(BindingList<ComboItem> list, ComboBox comboBox)
        {
            comboBox.DataSource = list;
            comboBox.DisplayMember = " ";
            comboBox.ValueMember = "Value";
        }

        private void SetButtonStyle(Button button, bool flag)
        {
            button.Enabled = flag;
            Color borderColor = (flag) ? SystemColors.ActiveCaption : SystemColors.ActiveBorder;
            Color backgroundColor = (flag) ? SystemColors.ControlLight : SystemColors.Control;
            button.ForeColor = borderColor;
            button.BackColor = backgroundColor;
        }
    }
}
