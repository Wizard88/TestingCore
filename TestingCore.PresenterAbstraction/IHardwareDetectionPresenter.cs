using TestingCore.PresenterAbstraction.ResponseModel;

namespace TestingCore.PresenterAbstraction
{
    public interface IHardwareDetectionPresenter
    {
        void HardwareInserted(Device device);
        void HardwareRemoved(Device device);
        void HardwareIdentified(Device device);
    }
}