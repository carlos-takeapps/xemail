using System;
using System.Collections.Generic;
using System.Text;

namespace BAFactory.XEMail.ServiceClient
{
    public class XEMailMessageHandlerException : Exception
    {
        private XEMailMessageHandlerException() { }
        public XEMailMessageHandlerException(string Message) : base(Message) { }
    }
}
