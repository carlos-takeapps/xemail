using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using BAFactory.Fx.Network.Email;

namespace SiProd.Applications.XEMail.WCFService
{
    [ServiceContract]
    public interface IXEMailService
    {
        [OperationContract]
        EMailsListElement[] ListPop3EMails(String Server, int Port, string Username, string Password, bool Ssl);

        [OperationContract]
        EMailMessage[] GetAllPop3EMailsHeaders(String Server, int Port, string Username, string Password, bool Ssl);
        
        [OperationContract]
        DataSet GetAllPop3EMailsHeadersDS(String Server, int Port, string Username, string Password, bool Ssl);
        
        [OperationContract]
        EMailMessage RetrievePop3EMail(String Server, int Port, string Username, string Password, bool Ssl, int MessageNumber);
        
        [OperationContract]
        String RetrievePop3RawEMailStream(String Server, int Port, string Username, string Password, bool Ssl, int MessageNumber);
        
        [OperationContract]
        bool DeletePop3EMail(String Server, int Port, string Username, string Password, bool Ssl, int MessageNumber);
        
        [OperationContract]
        bool SendSmtpEMail(String Server, int Port, string Username, string Password, bool Ssl, EMailMessage Message);
    }
}
