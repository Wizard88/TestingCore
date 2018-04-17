using System.Drawing;
using System.Windows.Forms;
using UI.ViewAbstraction;
using UI.ViewImplementation.Help;

namespace UI.ViewImplementation
{
    public partial class MainContainer : Form, IView, INotify, IStatusDetection
    {
        public MainContainer()
        {
            InitializeComponent();
        }

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

        #region IStatusDetection
        public void NotifyDeviceStatus(string text, Color color)
        {
            statusBar.SynchronizedInvoke(() => UpdateStatusFTDI(text, color));
        }

        public void NotifyMultimeterStatus(string text, Color color)
        {
            statusBar.SynchronizedInvoke(() => UpdateStatusMultimeter(text, color));
        }
        #endregion

        #region INotify
        public void NotifyError(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void NotifyWarning(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void NotifyInfo(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Methods
        private void UpdateStatusFTDI(string text, Color color)
        {
            tslCommunicationFtdiStatus.Text = text;
            tslCommunicationFtdiStatus.ForeColor = color;
        }

        private void UpdateStatusMultimeter(string text, Color color)
        {
            tslCommunicationMultimeterStatus.Text = text;
            tslCommunicationMultimeterStatus.ForeColor = color;
        }
        #endregion
    }
}
