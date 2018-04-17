using TestingCore.CommandAbstraction;
using TestingCore.CommandFactory;
using TestingCore.Common;

namespace TestingCore.CommandImplementation
{
    public class CommandFactory : IFactory
    {
        public ICommand CreateErrorCommand()
        {
            return new CommandError();
        }

        public ICommand CreateIdentificationCommand()
        {
            return new CommandIdentification();
        }

        public ICommand CreateRemoteDisableCommand()
        {
            return new CommandRemoteDisable();
        }

        public ICommand CreateRemoteEnableCommand()
        {
            return new CommandRemoteEnable();
        }

        public ICommand CreateSerialNumberCommand()
        {
            return new CommandSerialNumber();
        }

        public ICommand CreateSetConfigurationCommand(WindingConfiguration primary, WindingConfiguration secondary, int displacement)
        {
            return new CommandSetConfiguration(primary, secondary, displacement);
        }

        public ICommand CreateSetConfigurationCommand(WindingConfiguration primary, int displacement)
        {
            return new CommandSetConfiguration(primary, displacement);
        }

        public ICommand CreateSetHighSideVoltageCommand(int voltage)
        {
            return new CommandSetHighSideVoltage(voltage);
        }

        public ICommand CreateSetLowSideVoltageCommand(int voltage)
        {
            return new CommandSetLowSideVoltage(voltage);
        }

        public ICommand CreateSetVoltageAndFrequencyCommand(Voltage voltage, Frequency frequency)
        {
            return new CommandSetVoltageAndFrequency(voltage, frequency);
        }

        public ICommand CreateStartTestCommand()
        {
            return new CommandStartTest();
        }

        public ICommand CreateStatusCommand()
        {
            return new CommandStatus();
        }

        public ICommand CreatStopTestCommand()
        {
            return new CommandStopTest();
        }
    }
}
