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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Employee employee = new Employee() { Name = "珍妮佛", Salary = 30000 };
            Manager manager = new Manager() { Name = "艾利絲", Salary = 40000, Bonus = 20000 };
            lblMsg.Text = employee + "\n====================\n" + manager;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

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

        public override string ToString()
        {
            return $"員工姓名：{this.Name}\n實領薪水：{this.Salary}";
        }
    }

    class Manager : Employee
    {
        private int _bonus = 0;
        public int Bonus
        {
            get { return _bonus; }
            set
            {
                if (value < 10000) value = 10000;
                else if (value >= 50000) value = 50000;
                this._bonus = value;
            }
        }

        public int GetTotal() { return this.Bonus + base.Salary; }

        public override string ToString()
        {
            return $"經理姓名：{base.Name}\n實領薪水：{base.Salary}\n實領獎金：{this.Bonus}\n合計薪資：{this.GetTotal()}";
        }
    }
}