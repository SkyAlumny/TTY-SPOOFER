using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyAuth;

namespace tty
{
     class protection
    {
        internal static bool CheckAuth()
        {
            Programm.KeyAuthApp.check();
            if (Programm.KeyAuthApp.response.message == "Session is validated.")
            {
                return true;
            }            
            else
            {
                Environment.Exit(0);
                return false;
            }
        }

        internal static void ExecuteAllProtections()
        {
            CheckAuth();
            antivm.Check();
        }
    }
}
