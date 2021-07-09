using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEventsss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button1_Click被呼叫");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("button1_MouseClick被呼叫");
            Console.WriteLine($"位置 ({e.X}, {e.Y})");
            switch(e.Button)
            {
                case MouseButtons.Left:
                    Console.WriteLine("左鍵被按下去");
                    break;
                case MouseButtons.Right:
                    Console.WriteLine("右邊被按下去");
                    break;
                default:
                    Console.WriteLine(e.Button);
                    break;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("button1_MouseEnter被呼叫");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("button1_MouseDown被呼叫");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("button1_MouseUp被呼叫");
        }
    }
}
