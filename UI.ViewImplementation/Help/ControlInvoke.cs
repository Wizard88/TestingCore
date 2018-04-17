using System;
using System.ComponentModel;

namespace UI.ViewImplementation.Help
{
    public static class ControlInvoke
    {
        public static void SynchronizedInvoke(this ISynchronizeInvoke sync, Action action)
        {
            if (!sync.InvokeRequired)
            {
                action();
                return;
            }

            sync.Invoke(action, new object[] { });
        }
    }
}
