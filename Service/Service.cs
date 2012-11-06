using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.ServiceModel;
using System.ServiceProcess;
using System.Configuration;

using Service.Contract;

namespace Microsoft.ServiceModel.Samples
{
    public class MigrationWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public MigrationWindowsService()
        {
            // Name the Windows Service
            ServiceName = "MYOBDataMigration";
        }

        public static void Main()
        {
            ServiceBase.Run(new MigrationWindowsService());
        }

        // Start the Windows service.
        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(ServiceImplementation.SampleServiceImplementation));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }

    
}

