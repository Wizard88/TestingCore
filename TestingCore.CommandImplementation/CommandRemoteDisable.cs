using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandRemoteDisable : ICommand
    {
        public string GetKey()
        {
            return "RD";
        }

        public bool IsExpected(string response)
        {
            return response.Equals("00");
        }
    }
}