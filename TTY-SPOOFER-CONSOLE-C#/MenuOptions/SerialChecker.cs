using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;
using tty;


namespace tty
{
    class SerialChecker
    {
        internal static void CheckSerials()
        {

            framework.ClearConsole();

            settings.printSpeed = 0;

            framework.print($"     ===========[{settings.SpoofName} | SerialChecker]===========\n");
            Thread.Sleep(300);
            framework.print($"     ===========[CPU SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("wmic cpu get serialnumber", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[BASEBOARD SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("wmic baseboard get serialnumber", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[CHASSIS SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("wmic systemenclosure get serialnumber", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[CHASSIS SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("wmic systemenclosure get serialnumber", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[BIOS SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("wmic systemenclosure get serialnumber", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[UUID SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("wmic path win32_computersystemproduct get uuid", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[MAC SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("getmac", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[VOLUMEID SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("vol c:", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            framework.print($"\n     ===========[SID SERIAL]===========\n");
            Thread.Sleep(300);
            functions.CMD("wmic useraccount get sid", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), true);
            Thread.Sleep(300);
            settings.printSpeed = 12;
            framework.print("     [SYSTEM] Press [F1] to go Back");

            while (true)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                if (KeyInfo.Key == ConsoleKey.F1)
                {

                    menus.SerialCheckerMenu();
                    break;
                }

            }


        }

        internal static void SaveSerials()
        {
            string outputFilePath = "output.txt";
            string[] commands = {
            "echo off",

            "echo     ===========[{settings.SpoofName} | SerialChecker]===========",

            "echo     ===========[CPU SERIAL]===========",

            "wmic cpu get serialnumber",

            "echo     ===========[BASEBOARD SERIAL]===========",

            "wmic baseboard get serialnumber",

            "echo     ===========[CHASSIS SERIAL]===========",

            "wmic systemenclosure get serialnumber",

            "echo     ===========[CHASSIS SERIAL]===========",

            "wmic systemenclosure get serialnumber",

            "echo     ===========[BIOS SERIAL]===========",

            "wmic systemenclosure get serialnumber",

            "echo     ===========[UUID SERIAL]===========",

            "wmic path win32_computersystemproduct get uuid",

            "echo     ===========[MAC SERIAL]===========",

            "getmac",

            "echo     ===========[VOLUMEID SERIAL]===========",

            "vol c:",

            "echo     ===========[SID SERIAL]===========",

            "wmic useraccount get sid",
            };


            using (StreamWriter outputFile = new StreamWriter(outputFilePath))
            {
                foreach (string command in commands)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = $"/c {command}";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();


                    string output = process.StandardOutput.ReadToEnd();
                    outputFile.WriteLine($"{output}");

                    process.WaitForExit();
                }
            }

            Console.WriteLine("Commands executed and output saved to output.txt");
        }
    }
}
