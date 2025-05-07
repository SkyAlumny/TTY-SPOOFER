using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using tty;
using KeyAuth;


namespace KeyAuth
{
    class Programm
    {

        // Enter your KeyAuth Detials here
        public static api KeyAuthApp = new api(name: "", ownerid: "", secret: "", version: "1.0");



       




        // Start
        static void Main(string[] args)
        {
            // Init KeyAuth
            
            KeyAuthApp.init();
            if(!KeyAuthApp.response.success)
            {
                framework.ClearConsole();
                framework.Error("     [AUTH] Could not connect to Authentication Server");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            framework.LogoText();
            string license;
            framework.print("     [SYSTEM] Welcome to TTY Spoofer \n     [AUTH] Please enter your License Key: ");
            license = Console.ReadLine();
            framework.print("     [AUTH] Checking your License key...");
            if (license == null || license == "")
            {
                framework.ClearConsole();
                framework.Error("     [AUTH] License Key can not be empty");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            KeyAuthApp.license(license);

            if(!KeyAuthApp.response.success)
            {
                framework.ClearConsole();
                framework.Error("     [AUTH] " + KeyAuthApp.response.message);
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            framework.ClearConsole();
            framework.Success("     [AUTH] License valid, redirecting...");
            Thread.Sleep(2000);
            menus.MainMenu();

        }

        
// Made by https://github.com/SkyAlumny


       


       
    }
}
