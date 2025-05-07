using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.InteropServices;
using tty;


namespace tty
{
    class Spoof
    {


        // Since we are using the System32 Path we are using a Variable for it without caling always the Enviroment Class
        private static string System32Path = Environment.GetFolderPath(Environment.SpecialFolder.System);

        internal static void Start(int spoofoption)
        {


            protection.ExecuteAllProtections();

            using (WebClient client = new WebClient())
            {
                try
                {

                    // Downloading Files to Spoof
                    if (File.Exists(System32Path + $"\\{settings.exeFileName}"))
                    {
                        File.Delete(System32Path + $"\\{settings.exeFileName}");
                    }
                    if (File.Exists(System32Path + $"\\{settings.driverFileName}"))
                    {
                        File.Delete(System32Path + $"\\{settings.driverFileName}");
                    }

                    client.DownloadFile(settings.exeDownloadLink, System32Path + $"\\{settings.exeFileName}");
                    client.DownloadFile(settings.driverDownloadLink, System32Path + $"\\{settings.driverFileName}");

                    // Executing Spoof Commands
                    if (spoofoption == 1)
                    {
                        foreach (string cmd in settings.commandsRandom)
                        {

                            framework.ClearConsole();
                            framework.SpoofText();
                            framework.InvisibleText();
                            functions.CMD(cmd, System32Path);

                        }
                    }
                    if (spoofoption == 2)
                    {
                        foreach (string cmd in settings.commandsNull)
                        {

                            framework.ClearConsole();
                            framework.SpoofText();
                            framework.InvisibleText();
                            functions.CMD(cmd, System32Path);


                        }
                    }
                    if (spoofoption == 3)
                    {
                        bool selected = false;
                        string SystenSerial;
                        string BaseboardSerial;
                        string ChassisSerial;
                        string CPUSerial;
                        framework.ClearConsole();
                        framework.SpoofText();
                        framework.print("     [SYSTEM] Time to configurate your Serialnumbers \n     [Bios Serial] ENTER WITH FORMAT : XXXXXXX-XXXXXXX\n     ");
                        SystenSerial = Console.ReadLine();
                        framework.ClearConsole();
                        framework.SpoofText();
                        framework.print("     [SYSTEM] Perfect! \n     [Baseboard Serial] ENTER WITH FORMAT : XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXX\n     ");
                        BaseboardSerial = Console.ReadLine();
                        framework.ClearConsole();
                        framework.SpoofText();
                        framework.print("     [SYSTEM] Alright saved that! \n     [Chassis Serial] ENTER WITH FORMAT : XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXX\n     ");
                        ChassisSerial = Console.ReadLine();
                        framework.ClearConsole();
                        framework.SpoofText();
                        framework.print("     [SYSTEM] How about the CPU?! \n     [CPU Serial] ENTER WITH FORMAT : XXXXXXX-XXXXXXX\n     ");
                        CPUSerial = Console.ReadLine();
                        framework.ClearConsole();
                        framework.SpoofText();
                        if (CPUSerial == null || CPUSerial == "" || ChassisSerial == null || ChassisSerial == "" || BaseboardSerial == null || BaseboardSerial == "" || SystenSerial == null || SystenSerial == "")
                        {
                            framework.ClearConsole();
                            framework.Error("     [SYSTEM] One or More Serias are empty! Try Again!");
                            Start(3);
                            return;
                        }
                        else
                        {
                            framework.print("     [SYSTEM] Here is a list off all the Serials you want to Change. If you are okey with everything press [F1]\n");
                            framework.print("     ------------[Bios Serial]------------\n     ");
                            framework.print(SystenSerial);
                            framework.print("\n     ------------[Baseboard Serial]------------\n     ");
                            framework.print(ChassisSerial);
                            framework.print("\n     ------------[Chassis Serial]------------\n     ");
                            framework.print(BaseboardSerial);
                            framework.print("\n     ------------[CPU Serial]------------\n     ");
                            framework.print(CPUSerial);
                            while (!selected)
                            {
                                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

                                if (KeyInfo.Key == ConsoleKey.F1)
                                {
                                    selected = true;
                                    foreach (string cmd in settings.CustomOther)
                                    {

                                        framework.ClearConsole();
                                        framework.SpoofText();
                                        framework.InvisibleText();
                                        functions.CMD(cmd, System32Path);


                                    }
                                    framework.ClearConsole();
                                    framework.SpoofText();
                                    framework.InvisibleText();
                                    functions.CMD($"{settings.exeFileName} /SS " + SystenSerial, System32Path);
                                    functions.CMD($"{settings.exeFileName} /CS " + ChassisSerial, System32Path);
                                    functions.CMD($"{settings.exeFileName} /BS " + BaseboardSerial, System32Path);
                                    functions.CMD($"{settings.exeFileName} /PSN " + CPUSerial, System32Path);
                                }
                            }
                        }




                    }
                    // Spoof Process is done
                    if (File.Exists(System32Path + $"\\{settings.exeFileName}"))
                    {
                        File.Delete(System32Path + $"\\{settings.exeFileName}");
                    }
                    if (File.Exists(System32Path + $"\\{settings.driverFileName}"))
                    {
                        File.Delete(System32Path + $"\\{settings.driverFileName}");
                    }
                    SpoofVolumeID();
                    MacSpoof();
                    ApplySpoof();
                    framework.ClearConsole();
                    framework.Success("     [SYSTEM] You have sucessfully spoofed! I will bring you back to the Main Menu!");
                    Thread.Sleep(2000);
                    framework.ClearConsole();
                    menus.SpoofMenu();

                }
                catch (Exception ex)
                {
                    framework.ClearConsole();
                    framework.Error("     [SYSTEM] " + ex.Message);
                    Thread.Sleep(1500);
                    framework.ClearConsole();
                    menus.SpoofMenu();

                }
            }

        }


        internal static void SpoofFortnite()
        {
            protection.ExecuteAllProtections();
            framework.ClearConsole();
            framework.SpoofText();
            framework.InvisibleText();
            using (WebClient client = new WebClient())
            {
                try
                {
                    if (File.Exists(Path.GetTempPath() + $"\\{settings.SIDFileName}"))
                    {
                        File.Delete(Path.GetTempPath() + $"\\{settings.SIDFileName}");
                    }
                    client.DownloadFile(settings.SIDDownloadLink, Path.GetTempPath() + $"\\{settings.SIDFileName}");


                    functions.CMD($"{settings.SIDFileName} /KEY={settings.Trialkey} /R", Path.GetTempPath());
                    framework.ClearConsole();
                    framework.Error("     [SYSTEM] Please restart your PC and Spoof Fortnite Tourney Again"); // Some times the SID Software needs restarts and idk its wierd but it works sometimes.
                    Thread.Sleep(9000);
                    menus.MainMenu();

                }
                catch (Exception ex)
                {
                    framework.ClearConsole();
                    framework.Error("     [SYSTEM] " + ex);
                    Thread.Sleep(1500);
                    framework.ClearConsole();
                    menus.SpoofMenu();

                }

            }
        }

        internal static bool SpoofVolumeID()
        {
            protection.ExecuteAllProtections();
            using (WebClient client = new WebClient())
            {
                try
                {
                    if (File.Exists(System32Path + $"\\{settings.VolumeIDFilename}"))
                    {
                        File.Delete(System32Path + $"\\{settings.VolumeIDFilename}");
                    }
                    client.DownloadFile(settings.driverDownloadLink, System32Path + $"\\{settings.VolumeIDFilename}");
                    DriveInfo[] allDrives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in allDrives)
                    {

                        framework.ClearConsole();
                        framework.SpoofText();
                        framework.InvisibleText();
                        functions.CMD($"{settings.VolumeIDFilename} {drive.Name} {framework.GenerateRandomString(4)}-{framework.GenerateRandomString(4)}", System32Path);
                        // Made by https://github.com/SkyAlumny
                    }


                    return true;
                }
                catch (Exception ex)
                {
                    framework.ClearConsole();
                    framework.Error("     [SYSTEM] " + ex);
                    Thread.Sleep(1500);
                    framework.ClearConsole();
                    menus.SpoofMenu();
                    return false;
                }

            }


        }

        internal static bool MacSpoof()
        {
            protection.ExecuteAllProtections();
            try
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                ManagementObjectCollection networkAdapters = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapter WHERE PhysicalAdapter=True").Get();
                foreach (ManagementObject adapter in networkAdapters)
                {
                    string netConnectionID = adapter["NetConnectionID"].ToString();
                    string caption = adapter["Caption"].ToString();
                    string name = adapter["Name"].ToString();
                    string deviceId = adapter["DeviceID"].ToString().PadLeft(4, '0');
                    if (caption.Contains("Bluetooth") || name.Contains("Bluetooth") || netConnectionID.Contains("Bluetooth"))
                    {
                        continue;
                    }
                    byte[] macAddress = new byte[6];
                    random.NextBytes(macAddress);
                    string spoofedMacAddress = string.Concat(macAddress.Select(x => string.Format("{0}", x.ToString("X2"))).ToArray()).Insert(2, "-").Insert(5, "-").Insert(8, "-").Insert(11, "-").Insert(14, "-");
                    using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey($"SYSTEM\\CurrentControlSet\\Control\\Class\\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\\{deviceId}", true))
                    {
                        registryKey.SetValue("NetworkAddress", spoofedMacAddress);
                    }
                    Process disableProcess = new Process();
                    disableProcess.StartInfo.FileName = "netsh.exe";
                    disableProcess.StartInfo.Arguments = $"interface set interface \"{netConnectionID}\" admin=disable";
                    disableProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    disableProcess.Start();
                    disableProcess.WaitForExit();
                    Process enableProcess = new Process();
                    enableProcess.StartInfo.FileName = "netsh.exe";
                    enableProcess.StartInfo.Arguments = $"interface set interface \"{netConnectionID}\" admin=enable";
                    enableProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    enableProcess.Start();
                    enableProcess.WaitForExit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                framework.ClearConsole();
                framework.Error("     [SYSTEM] " + ex);
                Thread.Sleep(1500);
                framework.ClearConsole();
                menus.SpoofMenu();
                return false;
            }
            return false;
        }

        internal static bool ApplySpoof()
        {
            try
            {
                // | SITE NOTE |
                // I got the Regisry part from https://github.com/sohomxz/Perm-HWID-unban
                // If you reset the netsh stuff everything appls already. for what that is?
                // Idk didnt check but since it looks like it changes some windows informations its good to go.

                functions.CMD("REG ADD HKLM\\SOFTWARE\\Microsoft\\Cryptography /v MachineGuid /t REG_SZ /d %random%%random%-%random%-%random%-%random% /f", System32Path);
                functions.CMD("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v ProductId /t REG_SZ /d %random%%random%-%random%-%random%-%random% /f", System32Path);
                functions.CMD("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v InstallDate /t REG_SZ /d %random%%random% /f", System32Path);
                functions.CMD("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v InstallTime /t REG_SZ /d %random% /f", System32Path);
                functions.CMD("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v InstallTime /t REG_SZ /d %random% /f", System32Path);
                functions.CMD("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v BuildLabEx /t REG_SZ /d %random% /f", System32Path);
                functions.CMD("REG ADD HKLM\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware\" \"Profiles\\0001 /v HwProfileGuid /t REG_SZ /d {%random%%random%-%random%-%random%-%random%%random%} /f", System32Path);


                functions.CMD("wmic computersystem where name=%computername% call rename=%random%", System32Path);

                functions.CMD("netsh winsock reset", System32Path);
                functions.CMD("netsh winsock reset catalog", System32Path);
                functions.CMD("netsh int ip reset", System32Path);
                functions.CMD("netsh advfirewall reset", System32Path);
                functions.CMD("netsh int reset all", System32Path);
                functions.CMD("netsh int ipv4 reset", System32Path);
                functions.CMD("netsh int ipv6 reset", System32Path);
                functions.CMD("ipconfig /release", System32Path);
                functions.CMD("ipconfig /renew", System32Path);
                functions.CMD("ipconfig /flushdns", System32Path);
                functions.CMD("WMIC PATH WIN32_NETWORKADAPTER WHERE PHYSICALADAPTER=TRUE CALL DISABLE >nul 2>&1", System32Path);
                functions.CMD("WMIC PATH WIN32_NETWORKADAPTER WHERE PHYSICALADAPTER=TRUE CALL ENABLE >nul 2>&1", System32Path);
                functions.CMD("net stop winmgmt /y", System32Path);
                functions.CMD("net start winmgmt /y", System32Path);
                functions.CMD("sc stop winmgmt ", System32Path);
                functions.CMD("sc start winmgmt", System32Path);
                framework.ClearConsole();
                framework.Success("     [SYSTEM] You have sucessfully spoofed! I will bring you back to the Main Menu!");
                Thread.Sleep(2000);
                framework.ClearConsole();
                menus.SpoofMenu();
                return true;
            }
            catch (Exception ex)
            {
                framework.ClearConsole();
                framework.Error("     [SYSTEM] " + ex);
                Thread.Sleep(1500);
                framework.ClearConsole();
                menus.SpoofMenu();
                return false;
            }

        }

    }
}
