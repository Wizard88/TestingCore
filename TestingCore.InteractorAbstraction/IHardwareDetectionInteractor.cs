using System;

namespace TestingCore.InteractorAbstraction
{
    public interface IHardwareDetectionInteractor : IDisposable
    {
        void InitObserve();
    }
}
