using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MyFileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo fromInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                
                DirectoryInfo targetInfo = new DirectoryInfo(@"C:\Users\leonjye\Downloads\myicons0304-2");
                if (!fromInfo.Exists || targetInfo.Exists)
                {
                    lblMsg.Text = "來源不存在或目的地重覆";
                }
                else
                {
                    fromInfo.MoveTo(targetInfo.FullName);
                    lblMsg.Text = $"從{folderBrowserDialog1.SelectedPath}移動到" + targetInfo.FullName;
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\leonjye\Downloads";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fromfile = openFileDialog1.FileName;
                File.Copy(fromfile, @"C:\Users\leonjye\Downloads\test_out.txt");
            }
        }
    }
}
