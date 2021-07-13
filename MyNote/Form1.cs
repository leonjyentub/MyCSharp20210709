using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Note n = new Note() { Title = txtTitle.Text, Content = txtContent.Text };
            lstContent.Items.Add(n.GetFullMessage());
            txtTitle.Clear();
            txtContent.Clear();
        }
    }
}
