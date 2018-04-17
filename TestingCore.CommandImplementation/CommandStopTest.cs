using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandStopTest : ICommand
    {
        public string GetKey()
        {
            return "RTI";
        }

        public bool IsExpected(string response)
        {
            return response.Equals("00");
        }
    }
}