using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFuncOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add() { }
        private int Add(int a)
        {
            return a;
        }
        private String Add(String s) { return s; }
        private int Add(int a, int b)
        {
            return a + b;
        }

        private String Add(String a, String b)
        {
            return a + b;
        }
        private void Text_Changed(object sender, EventArgs e)
        {
            int a, b;
            if(int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                lblResult.Text = Add(a, b).ToString();
            }
            else
            {
                lblResult.Text = Add(txtA.Text, txtB.Text);
            }
        }
    }
}
