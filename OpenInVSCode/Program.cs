using System.Diagnostics;
using System.IO;

namespace OpenInVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var cd = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var arg = "--processStart Code.exe -a=";
            foreach (var s in args)
            {
                arg += "\"" + s + "\" ";
            }

            Directory.SetCurrentDirectory(cd);
            Process.Start("Update.exe", arg);
        }
    }
}
