using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandSetHighSideVoltage : ICommand
    {
        private int voltage;

        public CommandSetHighSideVoltage(int voltage)
        {
            this.voltage = voltage;
        }

        public string GetKey()
        {
            return string.Format("RSTH{0}", voltage.ToString().PadLeft(7, '0'));
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "H:[0-9]{7}");
        }
    }
}