using System.Windows.Forms;
using UI.ViewAbstraction;

namespace UI.ViewImplementation
{
    public partial class HelpDialog : Form, IView
    {
        public HelpDialog()
        {
            InitializeComponent();
        }

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
    }
}
