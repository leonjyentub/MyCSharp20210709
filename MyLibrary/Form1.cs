using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class Form1 : Form
    {
        String[] data = { "C#", "Java", "C++", "Python", "Julia", "Rust", "Dart" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chklistLeft.Items.AddRange(data);
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            for(int i= chklistLeft.CheckedIndices.Count-1; i >=0; i--)
            {
                int index = chklistLeft.CheckedIndices[i];
                chklistRight.Items.Add(chklistLeft.Items[index]);
                //chklistLeft.Items.Remove(chklistLeft.Items[index]);
                chklistLeft.Items.RemoveAt(index);
            }
        }
        ///////  請自行寫寫看從右邊移到左邊的程式喔 :D
    }
}
