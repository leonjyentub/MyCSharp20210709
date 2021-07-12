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
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\leonjye\Downloads\diricons2");
            dirInfo.MoveTo(@"C:\Users\leonjye\Downloads\myicons0304");
            lblMsg.Text = @"移動到C:\Users\leonjye\Downloads\myicons0304";
            //dirInfo.Delete();
        }
    }
}
