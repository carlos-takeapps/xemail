using System;
using System.Collections.Generic;
using System.Text;

namespace BAFactory.XEMail.ServiceClient
{
    [Serializable]
    class ServerConfiguration
    {
        private bool serverEnabled;

        private ServerProtocol serverProtocol;
        private string serverName;
        private int serverPort;
        private string username;
        private string userPassword;
        private bool ssl;
        private string[] errorMessage;

        public bool ServerEnabled
        {
            get { return serverEnabled; }
            set { serverEnabled = value; }
        }
        public ServerProtocol ServerProtocol
        {
            get { return serverProtocol; }
            set { serverProtocol = value; }
        }
        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        public int ServerPort
        {
            get { return serverPort; }
            set { serverPort = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string UserPassword
        {
            internal get { return userPassword; }
            set { userPassword = value; }
        }
        public bool SslEnabled
        {
            get { return ssl; }
            set { ssl = value; }
        }
        public string[] ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }
    }

    enum ServerProtocol
    { 
        POP3,
        SMTP,
        IMAP,
        HTTP
    }
}
