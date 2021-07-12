using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKeyEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"txtBox keyDown event: {e.KeyCode}");
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine($"txtBox keyPress event: {e.KeyChar}");
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtBox_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"txtBox keyUp event: {e.KeyCode}");
        }

        private void btnTest_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"btnTest keyDown event: {e.KeyCode}");
        }

        private void btnTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine($"btnTest keyPress event: {e.KeyChar}");
        }

        private void btnTest_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"btnTest keyUp event: {e.KeyCode}");
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            Console.WriteLine($"txtBox focused");
        }

        private void btnTest_Enter(object sender, EventArgs e)
        {
            Console.WriteLine($"btnTest focused");
        }
    }
}
