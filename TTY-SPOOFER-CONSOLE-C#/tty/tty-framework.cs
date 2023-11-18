using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tty
{
    class framework
    {
        internal static void GreenText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        internal static void RedText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        internal static void BlueText()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        internal static void YellowText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        internal static void InvisibleText()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        internal static void ResetText()
        {
            Console.ResetColor();
        }

        internal static void Error(string message)
        {
            RedText();
            Console.WriteLine(tty.settings.errorHugeText);
            Console.WriteLine(message);
        }

        internal static void Success(string message)
        {
            GreenText();
            Console.WriteLine(tty.settings.successHugeText);
            Console.WriteLine(message);
        }

        internal static void LogoText()
        {
            BlueText();
            Console.WriteLine(tty.settings.Logo);
        }

        internal static void SpoofText()
        {
            BlueText();
            Console.WriteLine(tty.settings.SpoofHugeText);
        }

        internal static void ClearConsole()
        {
            Console.Clear();
        }
        internal static void print(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(tty.settings.printSpeed);
            }
        }

        static Random rand = new Random();
        internal static string GenerateRandomString(int len)
        {
            const string alphanum = "0123456789ABCDEF";
            var tmp_s = new StringBuilder(len);

            for (int i = 0; i < len; ++i)
            {
                tmp_s.Append(alphanum[rand.Next(0, alphanum.Length)]);
            }

            return tmp_s.ToString();
        }
    }
}
