using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary
{
    
    static class _GlobalVariables
    {
        //This uses name of connection string in app.config file to retrieve connection info
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString;
            }
        }

    }

    
}
