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

namespace MyUselessNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filepath = openFileDialog1.FileName;
                this.Text = filepath;
                txtContent.Clear();
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = "";
                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                            txtContent.AppendText(line + Environment.NewLine);
                    } while (line != null);
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(txtContent.Text);
                }
            }
        }
    }
}
