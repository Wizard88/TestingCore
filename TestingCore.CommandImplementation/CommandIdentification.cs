using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandIdentification : ICommand
    {
        public string GetKey()
        {
            return "RGF";
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "[a-zA-Z]{3}[0-9]{2}[a-zA-Z]_[a-zA-Z1-9]+-[0-9].[0-9]+");
        }
    }
}