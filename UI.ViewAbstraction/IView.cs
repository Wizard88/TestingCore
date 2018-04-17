namespace UI.ViewAbstraction
{
    public interface IView
    {
        void ShowView();
        void ShowViewAsDialog();
        void CloseView();
        void SetParent(object parent);
    }
}
