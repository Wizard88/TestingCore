namespace UI.ViewAbstraction
{
    public interface INotify
    {
        void NotifyError(string caption, string message);
        void NotifyWarning(string caption, string message);
        void NotifyInfo(string caption, string message);
    }
}
