using System.Drawing;
using TestingCore.PresenterAbstraction;
using TestingCore.PresenterAbstraction.ResponseModel;
using UI.ViewAbstraction;

namespace TestingCore.PresenterImplementation
{
    internal class MultimeterDetectionPresenter : IHardwareDetectionPresenter
    {
        private readonly IStatusDetection _view;

        public MultimeterDetectionPresenter(IStatusDetection view)
        {
            _view = view;
        }

        public void HardwareIdentified(Device device)
        {
            _view.NotifyMultimeterStatus("Multimeter identified", Color.Green);
        }

        public void HardwareInserted(Device device)
        {
            _view.NotifyMultimeterStatus("Multimeter inserted", Color.Blue);
        }

        public void HardwareRemoved(Device device)
        {
            _view.NotifyMultimeterStatus("Multimeter removed", Color.Red);
        }
    }
}
