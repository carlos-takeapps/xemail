using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml;

using BAFactory.Fx.Utilities.Encoding;
using BAFactory.Fx.Security.Cryptography;

namespace BAFactory.XEMail.ServiceClient
{
    public class XEMailClientConfiguration : XEMailBaseConfigurationObject
    {
        private int checkInterval;
        private bool autoCheckEnabled;
        private string webserviceUrl;
        private XEMailNetworkProxy networkProxy;
        private XEMailAccountCollection accounts;
        
        public int CheckInterval
        {
            get { return checkInterval; }
            set
            {
                checkInterval = value;
                NotifyConfigChange();
            }
        }
        public bool AutoCheckEnabled
        {
            get { return autoCheckEnabled; }
            set
            {
                autoCheckEnabled = value; NotifyConfigChange();
                NotifyConfigChange();
            }
        }
        public string WebserviceUrl
        {
            get { return webserviceUrl; }
            set
            {
                webserviceUrl = value;
                NotifyConfigChange();
            }
        }
        public XEMailNetworkProxy NetworkProxy
        {
            get { return networkProxy; }
            set
            {
                networkProxy = value;
                NotifyConfigChange();
            }
        }
        public XEMailAccountCollection Accounts
        {
            get { return accounts; }
            set
            {
                accounts = value;
                NotifyConfigChange();
            }
        }

        public XEMailClientConfiguration()
        {
            this.checkInterval = 60;
            this.autoCheckEnabled = false;
            this.networkProxy = new XEMailNetworkProxy();
            this.accounts = new XEMailAccountCollection();
        }

        public XEMailClientConfiguration Clone()
        {
            XEMailClientConfiguration result = new XEMailClientConfiguration();
            result.checkInterval = this.checkInterval;
            result.autoCheckEnabled = this.autoCheckEnabled;
            result.accounts = this.accounts;
            result.WebserviceUrl = this.WebserviceUrl;
            result.networkProxy.Enabled = this.networkProxy.Enabled;
            result.NetworkProxy.Url = this.NetworkProxy.Url;
            result.networkProxy.Port = this.networkProxy.Port;
            result.NetworkProxy.User = this.NetworkProxy.User;
            result.NetworkProxy.Password = this.NetworkProxy.Password;
            result.networkProxy.Domain = this.networkProxy.Domain;

            return result;
        }

        #region XML Parsing

        public XmlDocument ExportConfigurationToXml()
        {
            string xemailNS = "http://www.siprod.net/namespaces/XEMail/ClientConfig";
            string emptyNS = string.Empty;

            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateNode(XmlNodeType.Element, "XEMailClientConfig", xemailNS);
            doc.AppendChild(root);

            XmlNode clientNode = doc.CreateNode(XmlNodeType.Element, "ClientConfig", xemailNS);
            root.AppendChild(clientNode);
            GenerateChildNode(clientNode, xemailNS, "AutoCheckEnabled", AutoCheckEnabled.ToString(), ref doc);
            GenerateChildNode(clientNode, xemailNS, "CheckInterval", CheckInterval.ToString(), ref doc);
            GenerateChildNode(clientNode, xemailNS, "WebserviceUrl", WebserviceUrl, ref doc);

            XmlNode netProxyNode = doc.CreateNode(XmlNodeType.Element, "NetworkProxy", xemailNS);
            clientNode.AppendChild(netProxyNode);
            GenerateChildNode(netProxyNode, xemailNS, "Enabled", networkProxy.Enabled.ToString(), ref doc);
            GenerateChildNode(netProxyNode, xemailNS, "Url", networkProxy.Url, ref doc);
            GenerateChildNode(netProxyNode, xemailNS, "Port", networkProxy.Port.ToString(), ref doc);
            GenerateChildNode(netProxyNode, xemailNS, "User", networkProxy.User, ref doc);
            GenerateChildNode(netProxyNode, xemailNS, "Password", EncryptedDataHelper.ConvertToNumbersString(MachineBasedRijndaelEncryptor.Encrypt(networkProxy.Password)), ref doc);
            GenerateChildNode(netProxyNode, xemailNS, "Domain", networkProxy.Domain, ref doc);

            XmlNode accountsNode = doc.CreateNode(XmlNodeType.Element, "Accounts", xemailNS);
            clientNode.AppendChild(accountsNode);
            XmlNode accountNode;
            foreach (string key in accounts.Keys)
            {
                XEMailAccount account = accounts[key];
                accountNode = doc.CreateNode(XmlNodeType.Element, "Account", xemailNS);

                GenerateChildNode(accountNode, xemailNS, "AccountName", account.AccountName, ref doc);
                GenerateChildNode(accountNode, xemailNS, "UseSameCredentials", account.UseSameCredentialsToSend.ToString(), ref doc);

                XmlNode incomingServerNode = doc.CreateNode(XmlNodeType.Element, "IncomingServer", xemailNS);
                accountNode.AppendChild(incomingServerNode);
                GenerateChildNode(incomingServerNode, xemailNS, "ServerEnabled", account.IncomingServer.ServerEnabled.ToString(), ref doc);
                GenerateChildNode(incomingServerNode, xemailNS, "ServerProtocol", account.IncomingServer.ServerProtocol.ToString(), ref doc);
                GenerateChildNode(incomingServerNode, xemailNS, "ServerName", account.IncomingServer.ServerName, ref doc);
                GenerateChildNode(incomingServerNode, xemailNS, "ServerPort", account.IncomingServer.ServerPort.ToString(), ref doc);
                GenerateChildNode(incomingServerNode, xemailNS, "UserName", account.IncomingServer.Username, ref doc);
                GenerateChildNode(incomingServerNode, xemailNS, "UserPassword", EncryptedDataHelper.ConvertToNumbersString(MachineBasedRijndaelEncryptor.Encrypt(account.IncomingServer.UserPassword)), ref doc);
                GenerateChildNode(incomingServerNode, xemailNS, "SslEnabled", account.IncomingServer.SslEnabled.ToString(), ref doc);

                XmlNode outgoingServerNode = doc.CreateNode(XmlNodeType.Element, "OutgoingServer", xemailNS);
                accountNode.AppendChild(outgoingServerNode);
                GenerateChildNode(outgoingServerNode, xemailNS, "ServerEnabled", account.OutgoingServer.ServerEnabled.ToString(), ref doc);
                GenerateChildNode(outgoingServerNode, xemailNS, "ServerProtocol", account.OutgoingServer.ServerProtocol.ToString(), ref doc);
                GenerateChildNode(outgoingServerNode, xemailNS, "ServerName", account.OutgoingServer.ServerName, ref doc);
                GenerateChildNode(outgoingServerNode, xemailNS, "ServerPort", account.OutgoingServer.ServerPort.ToString(), ref doc);
                GenerateChildNode(outgoingServerNode, xemailNS, "UserName", account.OutgoingServer.Username, ref doc);
                GenerateChildNode(outgoingServerNode, xemailNS, "UserPassword", EncryptedDataHelper.ConvertToNumbersString(MachineBasedRijndaelEncryptor.Encrypt(account.OutgoingServer.UserPassword)), ref doc);
                GenerateChildNode(outgoingServerNode, xemailNS, "SslEnabled", account.OutgoingServer.SslEnabled.ToString(), ref doc);

                accountsNode.AppendChild(accountNode);
            }

            clientNode.AppendChild(accountsNode);

            return doc;
        }

        public bool ImportConfigurationFromXml(XmlDocument XmlConfigurationDoc)
        {
            XmlElement root = XmlConfigurationDoc["XEMailClientConfig"]["ClientConfig"];

            autoCheckEnabled = bool.Parse(GetNodeValue(root["AutoCheckEnabled"]).ToString());
            checkInterval = int.Parse(GetNodeValue(root["CheckInterval"]).ToString());
            webserviceUrl = GetNodeValue(root["WebserviceUrl"]).ToString();

            XmlNode proxyNode = root["NetworkProxy"];
            try
            {
                networkProxy.Enabled = bool.Parse(GetNodeValue(proxyNode["Enabled"]).ToString());
            }
            catch
            {
                networkProxy.Enabled = false;
            }
            networkProxy.Url = GetNodeValue(proxyNode["Url"]).ToString();
            try
            {
                networkProxy.Port = int.Parse(GetNodeValue(proxyNode["Port"]).ToString());
            }
            catch
            {
                networkProxy.Port = 0;
            }
            networkProxy.User = GetNodeValue(proxyNode["User"]).ToString();
            networkProxy.Domain = GetNodeValue(proxyNode["Domain"]).ToString();
            networkProxy.Password = MachineBasedRijndaelEncryptor.Decrypt(EncryptedDataHelper.ConvertFromNumbersString(GetNodeValue(proxyNode["Password"]).ToString()));

            foreach (XmlNode accountNode in root["Accounts"].ChildNodes)
            {
                string AccountName = GetNodeValue(accountNode["AccountName"]).ToString();
                XEMailAccount account = new XEMailAccount();
                account.AccountName = AccountName;

                try
                {
                    account.UseSameCredentialsToSend = bool.Parse(GetNodeValue(accountNode["UseSameCredentials"]).ToString());
                }
                catch
                {
                    account.UseSameCredentialsToSend = false;
                }

                XmlNode incSrvrNode = accountNode["IncomingServer"];
                ServerConfiguration incSrvc = new ServerConfiguration();
                try
                {
                    incSrvc.ServerEnabled = bool.Parse(GetNodeValue(incSrvrNode["ServerEnabled"]).ToString());
                }
                catch
                {
                    incSrvc.ServerEnabled = false;
                }
                try
                {
                    incSrvc.ServerProtocol = (ServerProtocol)int.Parse(GetNodeValue(incSrvrNode["ServerProtocol"]).ToString());
                }
                catch
                {
                    incSrvc.ServerProtocol = ServerProtocol.POP3;
                }
                incSrvc.ServerName = GetNodeValue(incSrvrNode["ServerName"]).ToString();
                incSrvc.ServerPort = int.Parse(GetNodeValue(incSrvrNode["ServerPort"]).ToString());
                incSrvc.Username = GetNodeValue(incSrvrNode["UserName"]).ToString();
                try
                {
                    incSrvc.UserPassword = MachineBasedRijndaelEncryptor.Decrypt(EncryptedDataHelper.ConvertFromNumbersString(GetNodeValue(incSrvrNode["UserPassword"]).ToString()));
                }
                catch
                {
                    incSrvc.UserPassword = string.Empty;
                }

                try
                {
                    incSrvc.SslEnabled = bool.Parse(GetNodeValue(incSrvrNode["SslEnabled"]).ToString());
                }
                catch
                {
                    incSrvc.SslEnabled = false;
                }

                account.IncomingServer = incSrvc;

                XmlNode outSrvrNode = accountNode["OutgoingServer"];
                ServerConfiguration outSrvc = new ServerConfiguration();
                try
                {
                    outSrvc.ServerEnabled = bool.Parse(GetNodeValue(outSrvrNode["ServerEnabled"]).ToString());
                }
                catch
                {
                    outSrvc.ServerEnabled = false;
                }
                try
                {
                    outSrvc.ServerProtocol = (ServerProtocol)int.Parse(GetNodeValue(outSrvrNode["ServerProtocol"]).ToString());
                }
                catch
                {
                    outSrvc.ServerProtocol = ServerProtocol.SMTP;
                }
                outSrvc.ServerName = GetNodeValue(outSrvrNode["ServerName"]).ToString();
                outSrvc.ServerPort = int.Parse(GetNodeValue(outSrvrNode["ServerPort"]).ToString());
                outSrvc.Username = GetNodeValue(outSrvrNode["UserName"]).ToString();

                try
                {
                    outSrvc.UserPassword = MachineBasedRijndaelEncryptor.Decrypt(EncryptedDataHelper.ConvertFromNumbersString(GetNodeValue(outSrvrNode["UserPassword"]).ToString()));
                }
                catch
                {
                    outSrvc.UserPassword = string.Empty;
                }

                try
                {
                    outSrvc.SslEnabled = bool.Parse(GetNodeValue(outSrvrNode["SslEnabled"]).ToString());
                }
                catch
                {
                    outSrvc.SslEnabled = false;
                }

                account.OutgoingServer = outSrvc;

                accounts.Add(AccountName, account);
            }
            this.NotifyConfigChange();
            return true;
        }

        private XmlNode GenerateChildNode(XmlNode Parent, string Namespace, string Name, string Value, ref XmlDocument Document)
        {
            XmlNode node = Document.CreateNode(XmlNodeType.Element, Name, Namespace); ;
            XmlNode valueNode = Document.CreateNode(XmlNodeType.Text, Name, Namespace); ;
            valueNode.Value = Value;
            node.AppendChild(valueNode);
            Parent.AppendChild(node);
            return node;
        }

        public object GetNodeValue(XmlNode Node)
        {
            if (Node != null && Node.FirstChild != null)
            {
                return Node.FirstChild.Value;
            }
            return string.Empty;
        }

        #endregion

        #region Helper Methods

        private string GetSHA1Text(string Text)
        {
            string result = SHA1Encryptor.Encrypt(Text);
            return result;
        }

        #endregion
    }
}
