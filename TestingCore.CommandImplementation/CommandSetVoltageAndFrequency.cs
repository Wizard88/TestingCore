using System;
using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;
using TestingCore.Common;

namespace TestingCore.CommandImplementation
{
    internal class CommandSetVoltageAndFrequency : ICommand
    {
        private Voltage voltage;
        private Frequency frequency;

        public CommandSetVoltageAndFrequency(Voltage voltage, Frequency frequency)
        {
            this.voltage = voltage;
            this.frequency = frequency;
        }

        public string GetKey()
        {
            return string.Format("RSG{0}{1}", GetVoltageKey(voltage), GetFrequencyKey(frequency));
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "G:[0-9]{2}");
        }

        private string GetVoltageKey(Voltage voltage)
        {
            if (voltage.Equals(Voltage.V1)) return "1";
            else if (voltage.Equals(Voltage.V8)) return "2";
            else if (voltage.Equals(Voltage.V40)) return "3";
            else if (voltage.Equals(Voltage.V100)) return "4";
            else if (voltage.Equals(Voltage.V10)) return "5";
            else if (voltage.Equals(Voltage.V80)) return "6";
            else if (voltage.Equals(Voltage.V250)) return "7";
            else throw new ArgumentException("Invalid voltage enum");
        }

        private string GetFrequencyKey(Frequency frequency)
        {
            if (frequency.Equals(Frequency.F50)) return "1";
            else if (frequency.Equals(Frequency.F60)) return "2";
            else throw new ArgumentException("Invalid frequency enum");
        }
    }
}
