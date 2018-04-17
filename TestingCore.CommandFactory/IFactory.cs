using TestingCore.CommandAbstraction;
using TestingCore.Common;

namespace TestingCore.CommandFactory
{
    public interface IFactory
    {
        ICommand CreateRemoteEnableCommand();
        ICommand CreateRemoteDisableCommand();
        ICommand CreateIdentificationCommand();
        ICommand CreateSerialNumberCommand();
        ICommand CreateSetConfigurationCommand(WindingConfiguration primary, WindingConfiguration secondary, int displacement);
        ICommand CreateSetConfigurationCommand(WindingConfiguration primary, int displacement);
        ICommand CreateSetVoltageAndFrequencyCommand(Voltage voltage, Frequency frequency);
        ICommand CreateSetHighSideVoltageCommand(int voltage);
        ICommand CreateSetLowSideVoltageCommand(int voltage);
        ICommand CreateStatusCommand();
        ICommand CreateErrorCommand();
        ICommand CreateStartTestCommand();
        ICommand CreatStopTestCommand();
    }
}
