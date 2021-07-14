using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormsss
{
    public partial class FormDetail : Form
    {
        private MyScore _score;
        public MyScore Score 
        { 
            get { return _score; } 
        }
        public FormDetail()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _score = new MyScore()
            {
                Score = (int)numScore.Value,
                UserName = txtName.Text,
                SNo = txtNo.Text
            };
        }
    }
}
