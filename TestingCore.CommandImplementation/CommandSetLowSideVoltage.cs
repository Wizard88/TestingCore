using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;

namespace TestingCore.CommandImplementation
{
    internal class CommandSetLowSideVoltage : ICommand
    {
        private int voltage;

        public CommandSetLowSideVoltage(int voltage)
        {
            this.voltage = voltage;
        }

        public string GetKey()
        {
            return string.Format("RSTL{0}", voltage.ToString().PadLeft(7, '0'));
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "L:[0-9]{7}");
        }
    }
}