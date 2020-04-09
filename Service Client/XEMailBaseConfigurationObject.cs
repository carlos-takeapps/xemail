using System;
using System.Collections.Generic;
using System.Text;

namespace BAFactory.XEMail.ServiceClient
{
    public delegate void ConfigChangedEventHandler(object sender, EventArgs e);

    public class XEMailBaseConfigurationObject
    {
        internal protected event ConfigChangedEventHandler ConfigurationChanged;

        internal protected virtual void NotifyConfigChange()
        {
            if (ConfigurationChanged != null)
            {
                ConfigurationChanged(this, new EventArgs());
            }
        }
    }
}
