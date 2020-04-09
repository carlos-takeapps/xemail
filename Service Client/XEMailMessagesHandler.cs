using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


using BAFactory.Fx.Network.Email;
using BAFactory.Fx.Utilities.Encoding;

namespace BAFactory.XEMail.ServiceClient
{
    public static class XEMailMessagesHandler
    {
        private static ContentEncoder encoder;
        private static QuotedPrintableEncoder qpEncoder;

        static XEMailMessagesHandler()
        {
            encoder = new ContentEncoder();
            qpEncoder = new QuotedPrintableEncoder();
        }

        public static string GetHigherBodyView(EMailMessage Messsage)
        {
            string messageText;
            string messageTextEncoding;
            string messageTextType;

            if (Messsage.Views != null && Messsage.Views.Length > 0)
            {
                messageText = Messsage.Views[Messsage.Views.Length - 1].ContentStream;
                messageTextEncoding = Messsage.Views[Messsage.Views.Length - 1].ContentTransferEncoding;
                messageTextType = Messsage.Views[Messsage.Views.Length - 1].ContentType;
            }
            else
            {
                messageText = Messsage.Body.ContentStream;
                messageTextEncoding = Messsage.Body.ContentTransferEncoding;
                messageTextType = Messsage.Body.ContentType;
            }

            if (messageTextEncoding != null)
            {
                byte[] origEncoded;
                switch (messageTextEncoding.ToLower())
                {
                    case "quoted-printable":
                        ContentEncoder qpqtDecoder = new ContentEncoder();
                        messageText = qpEncoder.DecodeFromQuotedPrintable(messageText);
                        break;
                    case "7bit":
                        origEncoded = Encoding.Convert(Encoding.UTF7, Encoding.Default, Encoding.UTF7.GetBytes(messageText));
                        messageText = Encoding.Default.GetString(origEncoded);
                        break;
                    case "8bit":
                        origEncoded = Encoding.Convert(Encoding.UTF8, Encoding.Default, Encoding.UTF8.GetBytes(messageText));
                        messageText = Encoding.Default.GetString(origEncoded);
                        break;
                    case "base64":
                        origEncoded = Convert.FromBase64String(messageText);
                        messageText = Encoding.Default.GetString(origEncoded);
                        break;
                    default:
                        throw new XEMailMessageHandlerException(messageTextEncoding);
                }
            }
            if (messageTextType != null)
            {
                switch (messageTextType.ToLower())
                {
                    case "text/plain":
                    case "":
                        messageText = messageText.Replace("\n", "<br>");
                        break;
                    case "text/html":
                        break;
                    default:
                        break;
                }
            }
            else
            {
                messageText = messageText.Replace("\n", "<br>");

            }
            return messageText;
        }

        public static string GetTextOnlyBodyView(EMailMessage Message)
        {
            foreach (EMailBodyAlternateView view in Message.Views)
            {
                if (view.ContentType.Contains("plain") && view.ContentStream.Replace("\n", string.Empty) != string.Empty)
                {
                    return view.ContentStream;
                }
            }
            if (Message.Body.ContentStream.Replace("\n", string.Empty) != string.Empty)
            {
                string newBody = GetHigherBodyView(Message);
                string stripped = GetHtmlStrippedText(newBody);
                return stripped;
            }
            return string.Empty;
        }

        public static string GetEMailAddressTag(EMailAddress Address)
        {
            string result = string.Empty;
            if ((Address.DisplayName == null || Address.DisplayName == string.Empty) &&
                (Address.Address != null || Address.Address != string.Empty))
            {
                result = Address.Address;
            }
            else
            {
                if (Address.Address == null || Address.Address == string.Empty)
                {
                    result = Address.DisplayName;
                }
                else
                {
                    result = string.Format("{0} <{1}>", Address.DisplayName, Address.Address);
                }
            }
            return result;
        }

        public static string GetConcatenatedAddressesStrings(EMailAddress[] Addresses)
        {
            StringBuilder strBuilder = new StringBuilder();
            if (Addresses != null)
            {
                foreach (EMailAddress address in Addresses)
                {
                    strBuilder.AppendFormat("{0}; ", XEMailMessagesHandler.GetEMailAddressTag(address));
                }
            }
            return strBuilder.ToString();
        }

        public static EMailAddress[] ParseEMailsString(String EMailsList)
        {
            string[] emails = EMailsList.Split(new string[] { ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            List<EMailAddress> list = new List<EMailAddress>();

            foreach (string email in emails)
            {
                try
                {
                    list.Add(new EMailAddress(email));
                }
                catch
                {
                    throw new XEMailMessageHandlerException("Invalid EMail");
                }
            }
            return list.ToArray();

        }

        public static string GetHtmlStrippedText(string HtmlText)
        {
            string pattern = "</?\\w+((\\s+\\w+(\\s*=\\s*(?:\".*?\"|'.*?'|[^'\">\\s]+))?)+\\s*|\\s*)/?>";
            Regex regEx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            string result = regEx.Replace(HtmlText, string.Empty);
            return result;

        }

        public static string GetUTF8DecodedText(string InputText)
        {
            //StringBuilder result = new StringBuilder();

            //if (encoder.IsEncoded(InputText))
            //{
            //    string[] parts = encoder.SplitEncodedString(InputText);

            //    foreach (string part in parts)
            //    {

            //        result.Append(DecodeString(part));
            //    }
            //}
            //else
            //{
            //    result.Append(InputText);
            //}
            //return result.ToString();
            return encoder.GetUTF8DecodedText(InputText);
        }

    //    private static string DecodeString(string t)
    //    {
    //        string result = string.Empty;

    //        string charSet = string.Empty;
    //        string trxEncoding = string.Empty;

    //        string text = encoder.StripEncodedString(t, out charSet, out trxEncoding);

    //        switch (trxEncoding.ToUpper())
    //        {
    //            case "B":
    //                Base64Encoder b64Enc = new Base64Encoder();
    //                result = b64Enc.Decode(text);
    //                break;
    //            case "Q":
    //                QuotedPrintableEncoder qpEnc = new QuotedPrintableEncoder();
    //                result = qpEnc.DecodeFromQuotedPrintable(text);
    //                break;
    //            default:
    //                result = text;
    //                break;
    //        }

    //        if (!string.IsNullOrEmpty(charSet))
    //        {
    //            Encoding enc = null;
    //            try
    //            {
    //                enc = Encoding.GetEncoding(charSet);
    //            }
    //            catch
    //            {
    //                return result;
    //            }
    //            byte[] decoded = Encoding.Convert(enc, new UTF8Encoding(), enc.GetBytes(result));
    //            result = UTF8Encoding.UTF8.GetString(decoded);
    //        }

    //        return result;
    //    }
    }
}
