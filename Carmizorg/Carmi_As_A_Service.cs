using Cassia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Carmizorg
{
    public partial class Carmi_As_A_Service : ServiceBase
    {

        string sSource;
        string sLog;
        string sEvent;



        public Carmi_As_A_Service()
        {
            InitializeComponent();

            sSource = "Carmizorg";
            sLog = "Events";



        }
        public void onDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            int iNumberOfLoggedUsers = 0;
            //check if user is logged in
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                server.Open();
                //if (server.GetSessions().Count() < 1)
                foreach (ITerminalServicesSession session in server.GetSessions())
                {
                    NTAccount account = session.UserAccount;
                    if (account != null)
                    {
                        iNumberOfLoggedUsers++;
                    }
                }

            }
        }

        protected override void OnStop()
        {
        }
    }
}
