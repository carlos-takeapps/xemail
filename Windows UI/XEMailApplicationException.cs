using System;
using System.Collections.Generic;
using System.Text;

namespace BAFactory.XEMail.Windows
{
    class XEMailApplicationException : Exception
    {
        private XEMailApplicationException() { }
        public XEMailApplicationException(string Message) : base(Message) { }
    }
}
