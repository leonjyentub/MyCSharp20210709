using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDirectGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pic1.Image = imageList1.Images[3];
        }

        int index = 3;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D: case Keys.Right:
                    index = 3;
                    if(pic1.Left + pic1.Width + 30 < this.Width)
                        pic1.Left += 10;
                    break;
                case Keys.A: case Keys.Left:
                    index = 2;
                    pic1.Left -= 10;
                    break;
                case Keys.W: case Keys.Up:
                    index = 0;
                    pic1.Top -= 10;
                    break;
                case Keys.S: case Keys.Down:
                    index = 1;
                    pic1.Top += 10;
                    break;
            }
            pic1.Image = imageList1.Images[index];
        }
    }
}
