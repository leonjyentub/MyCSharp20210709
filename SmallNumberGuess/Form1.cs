using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallNumberGuess
{
    public partial class Form1 : Form
    {
        private Answer ans;
        public Form1()
        {
            InitializeComponent();
            ans = new Answer();
            lblResult.Text = ans.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ans = new Answer();
            lstLogs.Items.Clear();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(txtInput.TextLength == 4)
            {
                String input = txtInput.Text;
                Result result = ans.Compare(input);
                lstLogs.Items.Add(input + " => " + result.ToString());
                if(result.A == 4)
                {
                    MessageBox.Show("猜對了！是否繼續？", "", MessageBoxButtons.OKCancel); 
                }
                txtInput.Clear();
            }
        }
    }

    class Result
    {
        public int A { get; set; }
        public int B { get; set; }

        public override string ToString()
        {
            return $"{A}A{B}B";
        }
    }
    class Answer
    {
        private char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char[] ans = new char[4];
        private Random random = new Random();
        public Answer()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int t = random.Next(10);
                    char z = nums[j];
                    nums[j] = nums[t];
                    nums[t] = z;
                }
            }
            for (int i = 0; i < 4; i++) ans[i] = nums[i];
        }

        public Result Compare(String input)
        {
            int a = 0, b = 0;
            for (int i = 0; i < ans.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (ans[i] == input[j])
                    {
                        if (i == j) a++;
                        else b++;
                    }
                }
            }
            return new Result() { A = a, B = b };
        }

        public override string ToString()
        {
            String ret = "";
            foreach (char s in ans)
                ret += s;
            return ret;
        }
    }
}
