using System;
using System.Windows.Forms;
using System.IO;

namespace Android_File_Tools
{
    public partial class FormMain : Form
    {
        public string filePath, fileType;
        Utilities tool=new Utilities();
        public FormMain(string path, string type)
        {
            InitializeComponent();
            lblPath.Text = "文件路径:" + path;
            lblType.Text = "文件类型: " + type + "文件";
            filePath = path;
            fileType = type;
            if (type.Equals("JAR"))
            {
                btnDecompile.Enabled = false;
                btnDirectOpen.Text = "直接打开";
            }
            if (type.Equals("XML"))
            {
                btnDecompile.Text = "转换此XML";
            }
            if (type.Equals("ConvertedXML"))
            {
                btnDecompile.Text = "转换此XML";
                btnDecompile.Enabled = false;
                btnDirectOpen.Text = "直接打开";
            }
            string dex2Jar="", jdGui="", AXMLPrinter="";
            bool correct=true;
            try
            {
                string[] temp = tool.readIni();
                dex2Jar = temp[0];
                jdGui = temp[1];
                AXMLPrinter = temp[2];
                if (!File.Exists(dex2Jar) || !File.Exists(jdGui)||!File.Exists(AXMLPrinter)) throw new Exception();
            }
            catch (Exception e)
            {
                correct = false;
            }
            while (!File.Exists("./settings.ini")||!correct)
            {
                MessageBox.Show("初次使用之前或将工具移动以后请先指定使用的工具位置", "提示!");
                /*OpenFileDialog chooseFile = new OpenFileDialog();
                chooseFile.Filter = "d2j-dex2jar.bat|d2j-dex2jar.bat";
                chooseFile.Title = "请选择d2j-dex2jar.bat所在位置";
                chooseFile.ShowDialog();
                dex2Jar = chooseFile.FileName;
                chooseFile.Filter = "jd-gui.exe|jd-gui.exe";
                chooseFile.Title = "请选择jd-gui.exe所在位置";
                chooseFile.ShowDialog();
                jdGui = chooseFile.FileName;
                */
                dex2Jar = getFilePathByDialog("d2j-dex2jar.bat");
                jdGui = getFilePathByDialog("jd-gui.exe");
                AXMLPrinter = getFilePathByDialog("AXMLPrinter2.jar");
                if (!File.Exists(dex2Jar) || !File.Exists(jdGui) || !File.Exists(AXMLPrinter))
                {
                    correct = false;
                    continue;
                }
                else
                {
                    tool.writeIni(dex2Jar, jdGui, AXMLPrinter);
                    correct = true;
                }
            }
            tool.setPath(dex2Jar, jdGui, AXMLPrinter);

        }

        private void btnDecompile_Click(object sender, EventArgs e)
        {
            if (fileType.Equals("XML"))
            {
                if (tool.convertToReadableXml(filePath))
                {
                    btnDecompile.Text = "转换成功";
                    btnDecompile.Enabled = false;
                    btnDirectOpen.Text = "打开此XML";
                }
            }
            else
            {
                if (tool.convertToJar(filePath))
                {
                    btnDecompile.Text = "转换成功";
                    btnDecompile.Enabled = false;
                    btnDirectOpen.Text = "打开此JAR";
                }
            }
        }

        private void btnDirectOpen_Click(object sender, EventArgs e)
        {
            if (fileType.Equals("XML"))
            {
                string xmlPath = filePath.Substring(0, filePath.Length - 4) + ".convert.xml ";
                if (!File.Exists(xmlPath))
                {
                    btnDecompile_Click(sender, e);
                }
                tool.openXml(xmlPath);
            }
            else if (fileType.Equals("ConvertedXML"))
            {
                tool.openXml(filePath);
            }
            else
            {
                string jarPath = filePath.Substring(0, filePath.Length - 4) + ".jar ";
                if (!File.Exists(jarPath))
                {
                    btnDecompile_Click(sender, e);
                }
                tool.openJar(jarPath);
            }
        }

        public string getFilePathByDialog(string fileName)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Filter = fileName+"|"+fileName;
            chooseFile.Title = "请选择"+fileName+"所在位置";
            chooseFile.ShowDialog();
            return chooseFile.FileName;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver0.1\nHarry Chen\n2013-03-06", "关于");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
    }
}
