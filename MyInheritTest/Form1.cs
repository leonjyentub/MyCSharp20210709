using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInheritTest
{
    class Employee
    {
        public String Name { get; set; }
        private int _salary = 0;
        public int Salary
        {
            get { return this._salary; }
            set // value
            {
                if (value < 20000) value = 20000;
                else if (value >= 40000) value = 40000;
                this._salary = value;
            }
        }
    }

    class Manager : Employee
    {
        private int _bonus = 0;
        public int Bonus
        {
            get { return this.Bonus; }
            set
            {
                if (value < 10000) value = 10000;
                else if (value >= 50000) value = 50000;
                this._bonus = value;
            }
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
