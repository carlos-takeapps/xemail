using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BAFactory.XEMail.ServiceClient
{
    public delegate void XEMailProcessFinishedEventHandler(object sender, EventArgs e);

    public class XEMailProcessStatusManager
    {
        public event XEMailProcessFinishedEventHandler ProcessFinished; 

        private ArrayList inProcessAccounts;
        private bool workPending = false;

        public bool WorkPending
        {
            get { return workPending; }
        }

        public string[] InProcessAccounts
        {
            get
            {
                return (string[])inProcessAccounts.ToArray(typeof(string));
            }
        }

        public XEMailProcessStatusManager()
        {
            inProcessAccounts = new ArrayList();
        }

        public void AddAccount(string AccountName)
        {
            if (!inProcessAccounts.Contains(AccountName))
            {
                inProcessAccounts.Add(AccountName);
                workPending = true;
            }
        }

        public void RemoveAccount(string AccountName)
        {
            if (inProcessAccounts.Contains(AccountName))
            {
                inProcessAccounts.Remove(AccountName);
                if (inProcessAccounts.Count == 0)
                {
                    workPending = false;
                    NotifyFinish();
                }
            }
        }

        public void Reset()
        {
            inProcessAccounts.Clear();
            NotifyFinish();
        }

        public bool IsInProcess(string AccountName)
        {
            return inProcessAccounts.Contains(AccountName);
        }
     
        private void NotifyFinish()
        {
            XEMailProcessFinishedEventHandler finishedEvnt = ProcessFinished;
            if (finishedEvnt != null)
            {
                finishedEvnt(this, new EventArgs());
            }
        }
    }
}
