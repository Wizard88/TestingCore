using UI.ViewAbstraction;

namespace UI.ViewImplementation.Builder
{
    public class HelpBuilder : IBuilder
    {
        public IView CreateView()
        {
            return new HelpDialog();
        }
    }
}
