using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.ViewImplementation
{
    internal class AppContext : ApplicationContext
    {
        private static ApplicationContext _currentContext;

        public AppContext(Form mainForm)
            : base(mainForm)
        {
            _currentContext = this;
        }

        public static ApplicationContext CurrentContext { get => _currentContext; set => _currentContext = value; }
    }
}