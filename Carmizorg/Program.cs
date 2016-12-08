using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Carmizorg
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                // אתחל מערך של חומוס פול
                new Carmi_As_A_Service()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
