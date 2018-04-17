using System.Windows.Forms;
using UI.ViewAbstraction;

namespace UI.ViewImplementation
{
    public partial class Calibration : Form, IView, ICalibrationView
    {
        public Calibration()
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
    }
}
