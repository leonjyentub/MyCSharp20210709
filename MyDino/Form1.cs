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
        private int[] treeLeft = new int[2];
        private Random random = new Random();
        private PictureBox[] trees;
        public Form1()
        {
            InitializeComponent();
            startTop = picDino.Top;
            timerRoad.Enabled = true;
            trees = new PictureBox[2] { picTree, picTree2 };
            treeLeft[0] = trees[0].Left;
            treeLeft[1] = trees[1].Left;
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
            for(int i=0;i<trees.Length;i++)
            {
                PictureBox picTree = trees[i];
                picTree.Left -= 20;
                if (picDino.Bounds.IntersectsWith(picTree.Bounds))
                {
                    this.Text = "失敗~";
                    timerJump.Stop();
                    timerRoad.Stop();
                }
                if (picTree.Left <= 0)
                {
                    if (random.NextDouble() > 0.8D) // 1/5的機率會重新出現
                    {
                        if (random.NextDouble() >= 0.5D)
                            picTree.Image = Properties.Resources.obstacle_1;
                        else
                            picTree.Image = Properties.Resources.obstacle_2;
                        picTree.Left = treeLeft[i];

                    }
                }
            }
        }
    }
}
