using KeyAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tty
{
     class settings
    {
        /*
       * -----------------------------------
       * TITLE: Settings / Variables
       * DESCRIPTION: Here you can change all the
       *  diffrent settings to configurate your Spoofer
       * -----------------------------------
       */


        // VARIABLES

        // KeyAuth Informations
       


        // HUGE TEXT EDIT HERE: (Iam using https://www.fancytextpro.com/BigTextGenerator)

        // While be displayed on Errors
        internal static string errorHugeText = @"


            ███████╗██████╗ ██████╗  ██████╗ ██████╗ 
            ██╔════╝██╔══██╗██╔══██╗██╔═══██╗██╔══██╗
            █████╗  ██████╔╝██████╔╝██║   ██║██████╔╝
            ██╔══╝  ██╔══██╗██╔══██╗██║   ██║██╔══██╗
            ███████╗██║  ██║██║  ██║╚██████╔╝██║  ██║
            ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝      



                ";

        internal static string successHugeText = @"



            ███████╗██╗   ██╗ ██████╗ ██████╗███████╗███████╗███████╗
            ██╔════╝██║   ██║██╔════╝██╔════╝██╔════╝██╔════╝██╔════╝
            ███████╗██║   ██║██║     ██║     █████╗  ███████╗███████╗
            ╚════██║██║   ██║██║     ██║     ██╔══╝  ╚════██║╚════██║
            ███████║╚██████╔╝╚██████╗╚██████╗███████╗███████║███████║
            ╚══════╝ ╚═════╝  ╚═════╝ ╚═════╝╚══════╝╚══════╝╚══════╝
                         

            ";

        internal static string Logo = @"



            ████████╗████████╗██╗   ██╗     ███████╗██████╗  ██████╗  ██████╗ ███████╗███████╗██████╗ 
            ╚══██╔══╝╚══██╔══╝╚██╗ ██╔╝     ██╔════╝██╔══██╗██╔═══██╗██╔═══██╗██╔════╝██╔════╝██╔══██╗
               ██║      ██║    ╚████╔╝█████╗███████╗██████╔╝██║   ██║██║   ██║█████╗  █████╗  ██████╔╝
               ██║      ██║     ╚██╔╝ ╚════╝╚════██║██╔═══╝ ██║   ██║██║   ██║██╔══╝  ██╔══╝  ██╔══██╗
               ██║      ██║      ██║        ███████║██║     ╚██████╔╝╚██████╔╝██║     ███████╗██║  ██║
               ╚═╝      ╚═╝      ╚═╝        ╚══════╝╚═╝      ╚═════╝  ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝
 

            ";

        internal static string SpoofHugeText = @"



        ███████╗██████╗  ██████╗  ██████╗ ███████╗██╗███╗   ██╗ ██████╗          
        ██╔════╝██╔══██╗██╔═══██╗██╔═══██╗██╔════╝██║████╗  ██║██╔════╝          
        ███████╗██████╔╝██║   ██║██║   ██║█████╗  ██║██╔██╗ ██║██║  ███╗         
        ╚════██║██╔═══╝ ██║   ██║██║   ██║██╔══╝  ██║██║╚██╗██║██║   ██║         
        ███████║██║     ╚██████╔╝╚██████╔╝██║     ██║██║ ╚████║╚██████╔╝██╗██╗██╗
        ╚══════╝╚═╝      ╚═════╝  ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝╚═╝╚═╝
                                                                         
 

            ";

        internal static int printSpeed = 30;

          // DRIVERS ETC are deleted by Discord. Use your own Driver or join https://discord.gg/GyCcVVK8sG
        internal static string exeDownloadLink = "https://cdn.discordapp.com/attachments/1141697063516647424/1174774858480111777/tty-spoofer-exe.exe";
        internal static string exeFileName = $"tty-spoofer-exe.exe";

        internal static string driverDownloadLink = "https://cdn.discordapp.com/attachments/1141697063516647424/1174774918341210122/tty-spoofer-driver.sys";
        internal static string driverFileName = "AMIFLDRV64.SYS";

        internal static string VolumeIDDownloadLink = "https://cdn.discordapp.com/attachments/1141697063516647424/1175148594416844860/Volumeid.exe";
        internal static string VolumeIDFilename = "Volumeid.exe";

        internal static string SIDDownloadLink = "https://www.stratesave.com/downloads/sidchg64-3.0j.exe";
        internal static string SIDFileName = "SID.exe";
        internal static string Trialkey = "7d@$W-$NDJh-vOoLL-3v"; // You can find the Key at https://www.stratesave.com/html/sidchg.html (Scroll a little bit down)


        internal static bool debug = false;

        internal static string SpoofName = "TTY-SPOOFER";

        internal static string DiscordLink = "https://discord.gg/mgQJtGdpdt";



        //All Commands to execute
        internal static string[] commandsRandom = {
    $"{settings.exeFileName} /SU auto",
    $"{settings.exeFileName} /SS %random%-%random%",
    $"{settings.exeFileName} /BS %random%-%random%-%random%-%random%",
    $"{settings.exeFileName} /CS %random%-%random%-%random%",
    $"{settings.exeFileName} /SK %random%-%random%",
    $"{settings.exeFileName} /SF %random%-%random% ",
    $"{settings.exeFileName} /BT %random%-%random% ",
    $"{settings.exeFileName} /BLC %random%-%random% ",
    $"{settings.exeFileName} /CA %random%-%random% ",
    $"{settings.exeFileName} /CSK %random%-%random% ",
    $"{settings.exeFileName} /IVN \"American Megatrends International, LLC.\" ",
    $"{settings.exeFileName} /ID \"06/27/23\" ",
    $"{settings.exeFileName} /IV \"A.F0\" ",
    $"{settings.exeFileName} /PPN %random%-%random% ",
    $"{settings.exeFileName} /PAT %random%-%random% ",
    $"{settings.exeFileName} /PSN %random%-%random% ",
    $"{settings.exeFileName} /OS 1 %random%-%random% ",
    $"{settings.exeFileName} /OS 2 %random%-%random% ",
    $"{settings.exeFileName} /OS 3 %random%-%random% ",
    $"{settings.exeFileName} /OS 4 %random%-%random% ",
    $"{settings.exeFileName} /OS 5 %random%-%random% ",
    $"{settings.exeFileName} /OS 6 %random%-%random% ",
    $"{settings.exeFileName} /OS 7 %random%-%random% ",
    $"{settings.exeFileName} /OS 8 %random%-%random% ",
    $"{settings.exeFileName} /OS 9 %random%-%random% ",
    $"{settings.exeFileName} /OS 10 %random%-%random% ",
    $"{settings.exeFileName} /OS 11 %random%-%random% ",

            };

        internal static string[] commandsNull = {
  $"{settings.exeFileName} /SU auto",
    $"{settings.exeFileName} /SS \"To be filled by O.E.M\" ",
    $"{settings.exeFileName} /BS \"To be filled by O.E.M\" ",
    $"{settings.exeFileName} /PSN \"Unknown\" ",
    $"{settings.exeFileName} /CS \"To be filled by O.E.M\" ",
    $"{settings.exeFileName} /SK \"To be filled by O.E.M\" ",
    $"{settings.exeFileName} /SF \"To be filled by O.E.M.\" ",
    $"{settings.exeFileName} /BT \"To be filled by O.E.M.\" ",
    $"{settings.exeFileName} /BLC \"To be filled by O.E.M.\" ",
    $"{settings.exeFileName} /CA \"To be filled by O.E.M.\" ",
    $"{settings.exeFileName} /CSK \"To be filled by O.E.M.\" ",
    $"{settings.exeFileName} /IVN \"American Megatrends International, LLC.\" ",
    $"{settings.exeFileName} /ID 06/27/23 ",
    $"{settings.exeFileName} /IV \"A.F0\" ",
     $"{settings.exeFileName} /PPN %random%-%random% ",
    $"{settings.exeFileName} /PAT %random%-%random% ",
    $"{settings.exeFileName} /PSN %random%-%random% ",
    $"{settings.exeFileName} /OS 1 %random%-%random% ",
    $"{settings.exeFileName} /OS 2 %random%-%random% ",
    $"{settings.exeFileName} /OS 3 %random%-%random% ",
    $"{settings.exeFileName} /OS 4 %random%-%random% ",
    $"{settings.exeFileName} /OS 5 %random%-%random% ",
    $"{settings.exeFileName} /OS 6 %random%-%random% ",
    $"{settings.exeFileName} /OS 7 %random%-%random% ",
    $"{settings.exeFileName} /OS 8 %random%-%random% ",
    $"{settings.exeFileName} /OS 9 %random%-%random% ",
    $"{settings.exeFileName} /OS 10 %random%-%random% ",
    $"{settings.exeFileName} /OS 11 %random%-%random% ",

        };

        internal static string[] CustomOther = {
    $"{settings.exeFileName} /SU auto",
    $"{settings.exeFileName} /SK %random%-%random%",
    $"{settings.exeFileName} /SF %random%-%random% ",
    $"{settings.exeFileName} /BT %random%-%random% ",
    $"{settings.exeFileName} /BLC %random%-%random% ",
    $"{settings.exeFileName} /CA %random%-%random% ",
    $"{settings.exeFileName} /CSK %random%-%random% ",
    $"{settings.exeFileName} /IVN \"American Megatrends International, LLC.\" ",
    $"{settings.exeFileName} /ID \"06/27/23\" ",
    $"{settings.exeFileName} /IV \"A.F0\" ",
    $"{settings.exeFileName} /PPN %random%-%random% ",
    $"{settings.exeFileName} /PAT %random%-%random% ",
    $"{settings.exeFileName} /OS 1 %random%-%random% ",
    $"{settings.exeFileName} /OS 2 %random%-%random% ",
    $"{settings.exeFileName} /OS 3 %random%-%random% ",
    $"{settings.exeFileName} /OS 4 %random%-%random% ",
    $"{settings.exeFileName} /OS 5 %random%-%random% ",
    $"{settings.exeFileName} /OS 6 %random%-%random% ",
    $"{settings.exeFileName} /OS 7 %random%-%random% ",
    $"{settings.exeFileName} /OS 8 %random%-%random% ",
    $"{settings.exeFileName} /OS 9 %random%-%random% ",
    $"{settings.exeFileName} /OS 10 %random%-%random% ",
    $"{settings.exeFileName} /OS 11 %random%-%random% ",

        };


        /*
         * -----------------------------------
         * 
         * Settings / Variables | END
         * 
         * -----------------------------------
         */
    }
}
