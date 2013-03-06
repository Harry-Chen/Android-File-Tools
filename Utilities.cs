using System;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace Android_File_Tools
{
    public class Utilities
    {
        public const string FILENAME = "./settings.ini";
        public const string SECTION = "AppPath";
        [DllImport("kernel32")] private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")] private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private String dex2Jar, jdGui, AXMLPrinter;

        public bool convertToJar(string path)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe" ;
            p.StartInfo.Arguments= "/c "+ dex2Jar + " -o \"" + path.Substring(0, path.Length - 4) + ".jar\" \"" + path +"\"";
            p.StartInfo.UseShellExecute = false;
            p.Start();
            while (!p.HasExited){
                continue;
            }
            if (p.ExitCode == 0) return true;
            else return false;
        }

        public void openJar(string path)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = jdGui;
            p.StartInfo.Arguments = path;
            p.StartInfo.UseShellExecute = false;
            p.Start();
        }

        public bool convertToReadableXml(string filePath)
        {
            string convertedXMLPath=filePath.Substring(0, filePath.Length - 4) + ".convert.xml";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "java.exe";
            p.StartInfo.Arguments = "-jar " + AXMLPrinter + " " + filePath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            StreamWriter file = File.CreateText(convertedXMLPath);
            file.Write(output);
            file.Close();
            while (!p.HasExited)
            {
                continue;
            }
            if (p.ExitCode == 0)
            {
                return true;
            }
            else return false;
        }

        public void openXml(string path)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "notepad.exe";
            p.StartInfo.Arguments = path;
            p.StartInfo.UseShellExecute = false;
            p.Start();
        }

        public void writeIni(string dex2JarPath, string jdGuiPath, string AXMLPrinterPath)
        {
            WritePrivateProfileString(SECTION, "Dex2Jar", dex2JarPath, FILENAME);
            WritePrivateProfileString(SECTION, "Jd-Gui", jdGuiPath, FILENAME);
            WritePrivateProfileString(SECTION, "AXMLPrinter", AXMLPrinterPath, FILENAME);
        }

        public string[] readIni()
        {
            string[] path = new string[3];
            StringBuilder sb = new StringBuilder(1000);
            GetPrivateProfileString(SECTION, "Dex2Jar", "", sb, 500, FILENAME);
            path[0] = sb.ToString();
            sb = new StringBuilder(1000);
            GetPrivateProfileString(SECTION, "Jd-Gui", "", sb, 500, FILENAME);
            path[1] = sb.ToString();
            sb = new StringBuilder(1000);
            GetPrivateProfileString(SECTION, "AXMLPrinter", "", sb, 500, FILENAME);
            path[2] = sb.ToString();
            return path;
        }


        public void setPath(string _dex2Jar, string _jdGui, string _AXMLPrinter)
        {
            dex2Jar = _dex2Jar;
            jdGui = _jdGui;
            AXMLPrinter = _AXMLPrinter;
        }
    }
}
