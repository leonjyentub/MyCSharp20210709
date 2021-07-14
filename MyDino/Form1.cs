using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDino
{
    public partial class Form1 : Form
    {
        private bool isUp = false;
        private int startTop = 0;
        private int treeLeft = 0;
        public Form1()
        {
            InitializeComponent();
            startTop = picDino.Top;
            treeLeft = picTree.Left;
            timerRoad.Enabled = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                isUp = true;
                timerJump.Enabled = true;
            }
        }

        private void timerJump_Tick(object sender, EventArgs e)
        {
            if (picDino.Top < 30) 
                isUp = false;
            picDino.Top += isUp ? -10 : 10;
            if (picDino.Top >= startTop)
                timerJump.Enabled = false;
        }

        private void timerRoad_Tick(object sender, EventArgs e)
        {
            picTree.Left -= 20;
            if(picDino.Bounds.IntersectsWith(picTree.Bounds))
            {
                this.Text = "失敗~";
                timerJump.Stop();
                timerRoad.Stop();
            }
            if(picTree.Left <= 0)
            {
                picTree.Left = treeLeft;
            }
        }
    }
}
