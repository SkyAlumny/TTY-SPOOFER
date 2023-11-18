using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tty
{
    class functions
    {
        internal static bool CMD(string command, string path, bool showoutput = false)
        {

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c @echo off & {command}",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = path
            };
            process.StartInfo = startInfo;
            process.Start();


            if (showoutput)
            {
                framework.print("     " + process.StandardOutput.ReadToEnd());
            }
            process.WaitForExit();
            return true;
        }



    }
}
