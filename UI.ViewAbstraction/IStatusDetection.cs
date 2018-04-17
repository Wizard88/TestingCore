using System.Drawing;

namespace UI.ViewAbstraction
{
    public interface IStatusDetection
    {
        void NotifyDeviceStatus(string text, Color color);
        void NotifyMultimeterStatus(string text, Color color);
    }
}
