using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tty;

namespace tty
{
    class menus
    {
        

        internal static void SpoofMenu()
        {
            protection.ExecuteAllProtections();
            settings.printSpeed = 17;
            framework.ClearConsole();
            framework.ResetText();
            framework.BlueText();
            framework.LogoText();
            framework.print("     [SYSTEM] Welcome to the Spoof Menu! here are all Options you have: \n");
            framework.print("     [F1] Random Serials\n");
            framework.print("     [F2] Nulled Serials\n");
            framework.print("     [F3] Custom Serials\n");
            framework.print("     [F4] Fortnite Tourney Fix\n");
            framework.print("     [F5] Go Back\n");
            framework.print("     [SYSTEM] Press a FX Key to Spoof. ");
            settings.printSpeed = 30;
            while (true)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

                if (KeyInfo.Key == ConsoleKey.F1)
                {
                    
                    Spoof.Start(1);
                    break;
                }
                else if (KeyInfo.Key == ConsoleKey.F2)
                {
                   
                    Spoof.Start(2);
                    break;
                }
                else if (KeyInfo.Key == ConsoleKey.F3)
                {
                    
                    Spoof.Start(3);
                    break;
                }
                else if (KeyInfo.Key == ConsoleKey.F4)
                {
                    Spoof.SpoofFortnite();
                }
                else if (KeyInfo.Key == ConsoleKey.F5)
                {
                   
                    MainMenu();
                    break;
                }
            }

        }

        internal static void MainMenu()
        {
            protection.ExecuteAllProtections();
            framework.ClearConsole();
            framework.ResetText();
            framework.BlueText();
            framework.LogoText();
            framework.print($"     [SYSTEM] Welcome to {settings.SpoofName}! Where do you want to go: \n");
            framework.print("     [F1] Spoof Menu\n");
            framework.print("     [F2] Serial Menu\n");
            framework.print("     [F3] Discord\n");
            framework.print("     [F4] Exit\n");
            framework.print("     [SYSTEM] Press a FX Key to Spoof. ");

            while (true)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

                if (KeyInfo.Key == ConsoleKey.F1)
                {
                    SpoofMenu();
                    break;
                }
                else if (KeyInfo.Key == ConsoleKey.F2)
                {
                    SerialCheckerMenu();
                }
                else if (KeyInfo.Key == ConsoleKey.F3)
                {
                    Process.Start(new ProcessStartInfo(settings.DiscordLink) { UseShellExecute = true });


                }
                else if (KeyInfo.Key == ConsoleKey.F4)
                {
                    Environment.Exit(0);
                }
               
            }
        }

        internal static void SerialCheckerMenu()
        {
            protection.ExecuteAllProtections();
            framework.ClearConsole();
            framework.ResetText();
            framework.BlueText();
            framework.LogoText();
            framework.print($"     [SYSTEM] Lets Check your Serials: \n");
            framework.print("     [F1] SerialChecker\n");
            framework.print("     [F2] SerialSaver\n");
            framework.print("     [F3] Go Back\n");
            framework.print("     [SYSTEM] Press a FX Key to Spoof. ");

            while (true)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

                if (KeyInfo.Key == ConsoleKey.F1)
                {
                    SerialChecker.CheckSerials();
                    break;
                }
                else if (KeyInfo.Key == ConsoleKey.F2)
                {
                    SerialChecker.SaveSerials();
                    break;
                }
                else if (KeyInfo.Key == ConsoleKey.F3)
                {
                    MainMenu();
                }
                
            }
        }

    }
}
