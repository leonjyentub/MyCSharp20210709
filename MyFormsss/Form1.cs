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
    public partial class Form1 : Form
    {
        private List<MyScore> scores = new List<MyScore>();
        private bool defaultOrder = true;
        public Form1()
        {
            InitializeComponent();
            scores.Add(new MyScore() { UserName = "JJ", SNo = "001", Score = 100 });
            scores.Add(new MyScore() { UserName = "leon", SNo = "011", Score = 10 });
            scores.Add(new MyScore() { UserName = "May", SNo = "002", Score = 90 });
            scores.Add(new MyScore() { UserName = "test", SNo = "010", Score = 40 });
            scores.Add(new MyScore() { UserName = "ntub", SNo = "003", Score = 60 });
            lstBox.Items.AddRange(scores.ToArray());
            int rowsCount = scores.Count();
            lblRecords.Text = $"{rowsCount}筆";
            double average = scores.Average(x => x.Score);
            lblAverage.Text = $"{average:F2}";
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            using (FormDetail dform = new FormDetail())
            {
                if (dform.ShowDialog() == DialogResult.OK)
                {
                    scores.Add(dform.Score);
                    lstBox.Items.Add(dform.Score.ToString());
                }
            }
        }

        private void btnOrderbyScore_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            if(defaultOrder)
            {
                var result = scores.OrderBy(x => x.Score).ToArray();
                lstBox.Items.AddRange(result);
            }
            else
            {
                var result = scores.OrderByDescending(x => x.Score).ToArray();
                lstBox.Items.AddRange(result);
            }
            defaultOrder = !defaultOrder;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            /*
            lstBox.Items.AddRange(scores.Where(x => x.Score >= 60)
                                        .OrderBy(x => x.Score)
                                        .ToArray());
            */
            var result = from x in scores
                         where x.Score >= 60
                         orderby x.Score descending
                         select x;
            int rowsCount = scores.Where(x => x.Score >= 60).Count();
            double average = scores.Where(x => x.Score >= 60).Average(x => x.Score);
            lstBox.Items.AddRange(result.ToArray());
        }
    }
}
