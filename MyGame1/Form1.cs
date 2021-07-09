using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int[] dpoints = new int[3]; // 0 - 5 代表 1到6點
        private void ChangePoints(PictureBox pbox, int index)
        {
            dpoints[index] = random.Next(6);
            pbox.Image = imgListDices.Images[dpoints[index]];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] picboxes = { picDice1, picDice2, picDice3 };
            for(int i=0;i<picboxes.Length;i++)
            {
                ChangePoints(picboxes[i], i);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            int sum = 0;
            foreach (int d in dpoints)
                sum += d;
            lblPoint.Text = $"得到：{sum + 3} 點";
        }
    }
}
