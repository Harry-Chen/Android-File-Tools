using System;
using System.Windows.Forms;
using System.IO;

namespace Android_File_Tools
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            string type="";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length != 1)
            {
                MessageBox.Show("请不要直接打开此程序!","错误!");
                Environment.Exit(-1);
            }
            if (!File.Exists(args[0]))
            {
                MessageBox.Show("文件不存在!", "错误!");
                Environment.Exit(-1);
            }
            if (args[0].EndsWith(".jar"))
            {
                type = "JAR";
            }
            else if(args[0].EndsWith(".dex")){
                type = "DEX";
            }
            else if (args[0].EndsWith(".apk"))
            {
                type = "APK";
            }
            else if (args[0].EndsWith(".convert.xml"))
            {
                type = "ConvertedXML";
            }
            else if (args[0].EndsWith(".xml"))
            {
                type = "XML";
            }
            else
            {
                MessageBox.Show("只能打开jar, apk或dex文件!", "错误!");
                Environment.Exit(-1);
            }
            FormMain formMain = new FormMain(args[0],type);
            Application.Run(formMain);
        }
    }
}
