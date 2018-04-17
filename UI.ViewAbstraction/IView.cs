using System;

namespace UI.ViewAbstraction
{
    public interface IView
    {
        void ShowView();
        void ShowViewAsDialog();
        void CloseView();
        void SetParent(object parent);

        event EventHandler Shown;
        event EventHandler Closed;
    }
}
