using System;
using System.Text;
using System.Runtime.Serialization;

namespace BAFactory.XEMail.ServiceClient
{
    [Serializable]
    public class XEMailNetworkProxy : XEMailBaseConfigurationObject, ISerializable
    {
        private bool enabled;
        private string url;
        private int port = -1;
        private string user;
        private string domain;
        private string password;

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                enabled = value;
                NotifyConfigChange();
            }
        }
        public string Url
        {
            get { return url; }
            set { url = value; NotifyConfigChange(); }
        }
        public int Port
        {
            get { return port; }
            set { port = value; NotifyConfigChange(); }
        }
        public string User
        {
            get { return user; }
            set { user = value; NotifyConfigChange(); }
        }
        public string Domain
        {
            get { return domain; }
            set { domain = value; NotifyConfigChange(); }
        }
        public string Password
        {
            get { return password; }
            set { password = value; NotifyConfigChange(); }
        }

        #region ISerializable Members

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
