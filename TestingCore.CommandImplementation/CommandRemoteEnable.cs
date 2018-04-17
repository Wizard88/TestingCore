using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandRemoteEnable : ICommand
    {
        public string GetKey()
        {
            return "RE";
        }

        public bool IsExpected(string response)
        {
            return response.Equals("00");
        }
    }
}