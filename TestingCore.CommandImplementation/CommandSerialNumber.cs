using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandSerialNumber : ICommand
    {
        public string GetKey()
        {
            return "RGN";
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "([0-9]{2}X[0-9]{3})?");
        }
    }
}