using UI.ViewAbstraction;

namespace UI.ViewImplementation.Builder
{
    public interface IBuilder
    {
        IView CreateView();
    }
}
