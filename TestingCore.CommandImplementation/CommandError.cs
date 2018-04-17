using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandError : ICommand
    {
        public string GetKey()
        {
            return "RGE";
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "E:[0-9]{3}");
        }
    }
}