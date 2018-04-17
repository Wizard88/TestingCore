namespace TestingCore.CommandAbstraction
{
    public interface ICommand
    {
        string GetKey();
        bool IsExpected(string response);
    }
}
