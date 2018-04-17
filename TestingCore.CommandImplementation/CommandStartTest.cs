using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandStartTest : ICommand
    {
        public string GetKey()
        {
            return "RTS";
        }

        public bool IsExpected(string response)
        {
            return response.Equals("00");
        }
    }
}