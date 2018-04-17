using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandStatus : ICommand
    {
        public string GetKey()
        {
            return "RGS";
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "S:[0-9]{3}");
        }
    }
}